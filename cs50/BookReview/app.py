import os
import requests
import json
from checklogin import *
from sqlalchemy import create_engine
from sqlalchemy.orm import scoped_session, sessionmaker
from flask import Flask, render_template, url_for, request, flash, redirect, session, jsonify
from forms import RegistrationForm, LoginForm, SearchForm, ReviewForm
from flask_session import Session


app = Flask(__name__)
app.config['SECRET_KEY'] = '95db58c701edcd1529b6f553c4b30353'

# Configure my session to use a filesystem the project
app.config["SESSION_PERMANENT"] = False
app.config["SESSION_TYPE"] = "filesystem"
Session(app)

# Config my Postgree database with an virtual env variable
engine = create_engine(os.getenv("DATABASE_URL"))
db = scoped_session(sessionmaker(bind=engine))

# Homepage > If you are not logged in you will
# be redirect into LOG IN page
@app.route("/", methods=['GET', 'POST'])
@login_required
def home():
    username = session.get('username')
    number_of_posts = db.execute("select * from posts").rowcount
    books = db.execute(
        "select books.id, books.title, books.author, books.year, books.isbn, round(avg(posts.rating),1) as average from posts join books ON books.id = posts.book_id GROUP BY books.id, books.title, books.author, books.year, books.isbn ORDER BY average desc").fetchall()
    return render_template("home.html", pagetitle='Books and Books...', navbar='x', username=username, number_of_posts=number_of_posts, books=books)

# Search Page
@app.route("/search", methods=['GET', 'POST'])
@login_required
def search():
    form = SearchForm()
    username = session.get('username')
    books = db.execute("SELECT * FROM books WHERE lower(title) like lower('%' || :search || '%') OR lower(author) like lower('%' || :search || '%') OR lower(isbn) like lower('%' || :search || '%') OR lower(year) like lower('%' || :search || '%') ORDER BY title ASC",
                        {"search": form.search.data}).fetchall()
    contagem = len(books)
    if contagem is 0 and form.search.data is not None:
        flash('No results found', 'danger')
    return render_template("search.html", pagetitle='Search', navbar='x', username=username, form=form, contagem=contagem, books=books)

@app.route("/books/<book_id>", methods=['GET', 'POST'])
@login_required
def book(book_id):
    username = session.get('username')
    book = db.execute("SELECT * FROM books WHERE id = :id",
                      {"id": book_id}).fetchone()
    rating = db.execute(
        "SELECT ROUND(avg(rating),1) from posts WHERE book_id = :book_id GROUP BY posts.book_id", {"book_id": book.id}).fetchone()
    if rating is None:
        rating = "No reviews yet"
        review_counter = 0
    else:
        rating = float(rating[0])
        review_counter = db.execute("SELECT COUNT(rating) from posts WHERE book_id = :book_id", {"book_id": book_id}).fetchone()
        review_counter = int(review_counter[0])
    res = requests.get("https://www.goodreads.com/book/review_counts.json", params={"key": "FGNPjra4ZgnnfoHUKQ", "isbns": book.isbn})
    if res.status_code != 200:
        raise Exception("Error Api request unsuccessful")
    goodreview_average_rating = res.json()['books'][0]['average_rating']
    goodreview_ratings_count=res.json()['books'][0]['work_ratings_count']
    reviews = db.execute("SELECT header, content, rating, username FROM posts JOIN users on posts.user_id = users.id where book_id = :book_id", {"book_id": book.id}).fetchall()
    review_check = len(reviews)
    return render_template('book.html', book=book, pagetitle=book.title, navbar='x', username=username, reviews=reviews, review_check=review_check, rating=rating, goodreview_average_rating=goodreview_average_rating, goodreview_ratings_count=goodreview_ratings_count, review_counter=review_counter)

@app.route("/review/<book_id>", methods=['GET', 'POST'])
@login_required
def review(book_id):
    form = ReviewForm()
    username = session.get('username')
    user = db.execute("SELECT * FROM users WHERE username = :username",
                      {"username": str(username)}).fetchone()
    book = db.execute("SELECT * FROM books WHERE id = :id",
                      {"id": int(book_id)}).fetchone()
    user_id = int(user.id)
    book_id = int(book.id)
    if db.execute("SELECT * FROM posts WHERE user_id = :user_id and book_id = :book_id",
                  {"user_id": user_id, "book_id": book_id, }).rowcount != 0:
        flash('Sorry... You can make just one review for each book', 'danger')
        return redirect(url_for('yourpost', book_id=book.id))
    if form.validate_on_submit():
        db.execute("INSERT INTO posts (header, content, rating, book_id, user_id) VALUES (:header, :content, :rating, :book_id, :user_id)",
                   {"header": form.header.data, "content": form.content.data, "rating": int(form.rating.data), "user_id": int(user.id), "book_id": int(book.id)})
        db.commit()
        flash('Posted with sucess', 'success')
        book_id = book.id
        return redirect(url_for('book', book_id=book.id))
    return render_template('review.html', book=book, pagetitle=book.title, navbar='x', form=form, username=username, user=user, user_id=user_id, book_id=book.id)

@app.route("/yourpost/<book_id>", methods=['GET', 'POST'])
@login_required
def yourpost(book_id):
    username = session.get('username')
    user = db.execute("SELECT * FROM users WHERE username = :username",
                      {"username": str(username)}).fetchone()
    book = db.execute("SELECT * FROM books WHERE id = :id",
                      {"id": book_id}).fetchone()
    user_id = int(user.id)
    book_id = int(book.id)
    review = db.execute("SELECT * FROM posts WHERE book_id = :book_id and user_id = :user_id",
                        {"book_id": book_id, "user_id": user_id}).fetchone()
    return render_template('yourpost.html', book=book, pagetitle='You already have have made a review for this book', navbar='x', username=username, user=user, user_id=user_id, book_id=book_id, review=review)

@app.route("/register", methods=['GET', 'POST'])
def register():
    form = RegistrationForm()
    if form.validate_on_submit():
        username_form = form.username.data
        if db.execute("SELECT * FROM users WHERE username = :username", {"username": username_form}).rowcount == 0:
            username = form.username.data
            password = form.password.data
            db.execute("INSERT INTO users (username, password) VALUES (:username, :password)",
                       {"username": username, "password": password})
            db.commit()
            flash('Account created! Please Login', 'success')
            return redirect(url_for('login'))
        else:
            flash('Username already taken', 'danger')
    return render_template("register.html", pagetitle='Register', navbar='', form=form)

@app.route("/login", methods=['GET', 'POST'])
def login():
    form = LoginForm()
    if form.validate_on_submit():
        if db.execute("SELECT * FROM users WHERE username = :username", {"username": form.username.data}).rowcount == 0:
            flash('User do not exist!', 'danger')
            return redirect(url_for('login'))
        else:
            passwords_db = db.execute(
                "SELECT password FROM users WHERE username = :username", {"username": form.username.data}).fetchone()
            for password_db in passwords_db:
                if password_db == form.password.data:
                    flash('You have successfully logged in!', 'success')
                    username = form.username.data
                    session["username"] = username
                    user_id = db.execute("SELECT id FROM users WHERE username = :username", {
                        "username": username}).fetchone()
                    return redirect(url_for('home'))
                else:
                    flash('You type a wrong password!', 'danger')
    return render_template("login.html", pagetitle='Login', navbar='', form=form)

@app.route("/logout")
def logout():
    session.clear()
    flash('You have successfully logged out!', 'success')
    return redirect(url_for("login"))

@app.route("/api/<isbn>", methods=['GET'])
def book_api(isbn):
    book = db.execute("SELECT * FROM books WHERE isbn = :isbn",
                      {"isbn": isbn}).fetchone()
    if book is None:
        return jsonify({"error": "Invalid ISBN CODE"}), 422                      
    else:
        rating = db.execute(
            "SELECT ROUND(avg(rating),1) from posts WHERE book_id = :book_id GROUP BY posts.book_id", {"book_id": book.id}).fetchone()
        if rating is None:
            rating = "No reviews yet"
            review_counter = 0
        else:
            rating = float(rating[0])
            review_counter = db.execute("SELECT COUNT(rating) from posts WHERE book_id = :book_id", {"book_id": book.id}).fetchone()
            review_counter = int(review_counter[0])
        if book is None:
            return jsonify({"error": "Invalid isbn code!"}), 422
        return jsonify({
        "title": book.title,
        "author": book.author,
        "year": book.year,
        "isbn": book.isbn,
        "review_count": review_counter,
        "average_score": rating
    })
    return render_template("api.html", pagetitle='api', navbar='')

    
    