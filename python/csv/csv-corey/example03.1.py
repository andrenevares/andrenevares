import csv
import os
from flask import Flask, request
from flask_sqlalchemy import SQLAlchemy, session

app = Flask(__name__)


app.config['SQLALCHEMY_TRACK_MODIFICATIONS'] = False
app.config['SECRET_KEY'] = '5791628bb0b13ce0c676dfde280ba245'
# postgresql://username:password@host:port/database
app.config['SQLALCHEMY_DATABASE_URI'] = 'postgres://chjzrrwvocfyun:6c767d53f89a96526ac9f34f9824fb72b38789bc547689982362ae408450fd3e@ec2-107-22-238-217.compute-1.amazonaws.com:5432/d7886b851q5qft''
db = SQLAlchemy(app)

class Book(db.Model):
    __tablename__ = 'book'
    id = db.Column(db.Integer, primary_key=True)
    isbn = db.Column(db.String(100), nullable=False)
    title = db.Column(db.String(100), nullable=False)
    author = db.Column(db.String(100), nullable=False)
    year_published = db.Column(db.String(4), nullable=False)


with open('books.csv', 'r') as csv_file:
    csv_reader = csv.reader(csv_file)

    next(csv_reader)

    for line in csv_reader:
        isbn_value = line[0]
        title_value = line[1]
        author_value = line[2]
        year_value = line[3]

        book = Book(isbn=isbn_value, title=title_value, author=author_value, year_published=year_value)
        db.session.add(user)
        db.session.commit() 
        
        #print (f"The book with {isbn_value} has the title of {title_value} was written by {author_value} in {year_value}")
