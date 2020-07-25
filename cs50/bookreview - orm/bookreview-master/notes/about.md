# About this Project

## Creating Database
I have made BY SQL....  by i drop all and created again with python classes
For this i used the classes 

``` 
from flask import Request
from datetime import datetime
from bookreview import db


class User(db.Model):
    __tablename__ = 'user'
    id = db.Column(db.Integer, primary_key=True)
    username = db.Column(db.String(100), unique=True, nullable=False)
    password = db.Column(db.String(60), nullable=False)
    reviews = db.relationship('Review', backref='author', lazy=True)

    def __repr__(self):
        return f"User('{self.username}', '{self.password}')"


class Review(db.Model):
    __tablename__ = 'review'
    id = db.Column(db.Integer, primary_key=True)
    title = db.Column(db.String(100), nullable=False)
    date_posted = db.Column(db.DateTime, nullable=False, default=datetime.utcnow)
    content = db.Column(db.Text, nullable=False)
    rating = db.Column(db.Integer, nullable=False)
    user_id = db.Column(db.Integer, db.ForeignKey('user.id'), nullable=False)
    book_id = db.relationship('Book', backref='isbn', lazy=True)

    def __repr__(self):
        return f"Reviews('{self.title}', '{self.date_posted}')"

class Book(db.Model):
    __tablename__ = 'book'
    id = db.Column(db.Integer, primary_key=True)
    isbn = db.Column(db.String(100), nullable=False)
    title = db.Column(db.String(100), nullable=False)
    author = db.Column(db.String(100), nullable=False)
    year_published = db.Column(db.String(4), nullable=False)
    review_id = db.Column(db.Integer, db.ForeignKey('review.id'), nullable=False)

    def __repr__(self):
        return f"Books('{self.title}', '{self.date_posted}')"

``` 

On the comand line i have made this:
```
$ python
>>> from bookreview.models import User
>>> db.create_all()
```