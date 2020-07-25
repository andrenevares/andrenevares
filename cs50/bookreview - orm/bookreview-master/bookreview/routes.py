import os
import secrets
from flask import render_template, url_for, flash, redirect, request, abort
from bookreview import SQLAlchemy, app, db, bcrypt, and_, create_engine, scoped_session, sessionmaker
from bookreview.forms import *
from bookreview.models import *
from flask_login import login_user, current_user, logout_user, login_required


######################
##       MAIN       ##
######################

@app.route("/")
@app.route("/home", methods=['GET', 'POST'])
def home():
    books = Book.query.all()
    return render_template('home.html', title='Home', books=books)


######################
##      SEARCH      ##
######################


@app.route("/search", methods=['POST'])
def search():
    user_search_for = request.form['search']
    s_isbns = Book.query.filter(Book.isbn.like('%{}%'.format(user_search_for))).all()
    n_s_isbns = Book.query.filter(Book.isbn.like('%{}%'.format(user_search_for))).count()
    s_titles = Book.query.filter(Book.title.like('%{}%'.format(user_search_for))).all()
    n_s_titles = Book.query.filter(Book.title.like('%{}%'.format(user_search_for))).count()
    s_authors = Book.query.filter(Book.author.like('%{}%'.format(user_search_for))).all()
    n_s_authors = Book.query.filter(Book.author.like('%{}%'.format(user_search_for))).count()
    s_years = Book.query.filter(Book.year.like('%{}%'.format(user_search_for))).all()
    n_s_years = Book.query.filter(Book.year.like('%{}%'.format(user_search_for))).count()
    return render_template('search.html', title='About', user_search_for=user_search_for, s_isbns=s_isbns, s_titles=s_titles, s_authors=s_authors, s_years=s_years, n_s_isbns=n_s_isbns, n_s_titles=n_s_titles, n_s_authors=n_s_authors, n_s_years=n_s_years)

@app.route("/searchresults", methods=['GET', 'POST'])
def searchresults():
    return render_template('searchresults.html', title='searchresults')


######################
## LOG AND REGISTER ##
######################


@app.route("/register", methods=['GET', 'POST'])
def register():
    if current_user.is_authenticated:
        return redirect(url_for('home'))
    form = RegistrationForm()
    # If the register is valid on submit then
    if form.validate_on_submit():
        # First let´s hash the password so we can store
        user_check = User.query.filter_by(username=form.username.data).first()
        if user_check:
            flash('This user is already taken and try again', 'danger')
            return redirect(url_for('register')) 
        else:
            ### Hash password to encrypt and have security
            hashed_password = bcrypt.generate_password_hash(form.password.data).decode('utf-8')
            ###
            user = User(username=form.username.data, password=hashed_password)
            db.session.add(user)
            db.session.commit() 
            flash('Account created! Please log in!', 'success')
            return redirect(url_for('login')) 
    return render_template('register.html', title='Register', form=form)

@app.route("/login", methods=['GET', 'POST'])
def login():
    if current_user.is_authenticated:
        return redirect(url_for('home'))
    form = LoginForm()
    if form.validate_on_submit():
        user = User.query.filter_by(username=form.username.data).first()
        if user and bcrypt.check_password_hash(user.password, form.password.data):
            login_user(user)
            flash('You are logged into BookReview!', 'success')
            return redirect(url_for('home'))
        else:
            flash('Login Unsuccessful. Please check username and password', 'danger')
    return render_template('login.html', title='Login', form=form)

@app.route("/logout")
def logout():
    logout_user()
    return redirect(url_for('home'))

######################
##      BOOKS       ##
######################

@app.route("/book/new", methods=['GET', 'POST'])
@login_required
def new_book():
    form = BookForm()
    if form.validate_on_submit():
        book = Book(isbn=form.isbn.data, title=form.title.data, author=form.author.data, year=form.year.data)
        db.session.add(book)
        db.session.commit()
        flash('You have inserted a new book into our database!  Thanks!!!', 'success')
        return redirect(url_for('home'))
    return render_template('create_book.html', title='New Book', form=form)

@app.route("/books/<book_id>", methods=['GET', 'POST'])
@login_required
def book(book_id):
    reviews = Review.query.filter_by(book_id=book_id).all()
    book = Book.query.get_or_404(book_id)
    return render_template('book.html', reviews=reviews, book=book)

######################
##     REVIEWS      ##
######################

@app.route("/makereview/<int:book_id>", methods=['GET', 'POST'])
def makereview(book_id):
    form = ReviewForm()
    book = Book.query.get_or_404(book_id)
    current_user_id = current_user.id
    if form.validate_on_submit():
        reviews = Review.query.all()
        review_author = current_user.username
        review = Review(title=form.title.data, content=form.content.data, rating=form.rating.data, review_author=review_author, review_author_id=review_author_id, book_id=book_id)
        db.session.add(review)
        db.session.commit()
        flash('Your have made a review!', 'success')
        return redirect(url_for('home'))
    return render_template('makereview.html', book=book, form=form)

@app.route("/updatereview")
def updatereview():
    pass

######################
##      OTHERS      ##
######################

@app.route("/about", methods=['GET', 'POST'])
def about():
    engine = create_engine("postgres+psycopg2://chjzrrwvocfyun:6c767d53f89a96526ac9f34f9824fb72b38789bc547689982362ae408450fd3e@ec2-107-22-238-217.compute-1.amazonaws.com:5432/d7886b851q5qft")
    db = scoped_session(sessionmaker(bind=engine))
    test = db.execute("SELECT * from user")

    

    




    #if test != None:
        #print('Exists')
    return render_template('about.html', title='About', test=test)


