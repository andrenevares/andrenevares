# Project 01 - CS 50 web programming with python and javascript
## Author: André Nevares on 2020

## Links:
1. [Code to create tables]()
2. [Code to import data from csv]()

## To do
    [ ] make a better homepage
    
    [ ] In README.md, include a short writeup describing your project, what’s contained in each file, and
        (optionally) any other additional information the staff should know about your project.
    [ ] If you’ve added any Python packages that need to be installed in order to run your web application, be sure
        to add them to requirements.txt!

 /api/<isbn>
```
{
    "title": "Memory",
    "author": "Doug Lloyd",
    "year": 2015,
    "isbn": "1632168146",
    "review_count": 28,
    "average_score": 5.0
}
```



## Done
    [ x ] Postgree Config
    [ x ] You should be using raw SQL commands (as via SQLAlchemy’s execute method) in order to make database
        queries.
        You should not use the SQLAlchemy ORM (if familiar with it) for this project.
    [ x ] Registration: Users should be able to register for your website, providing (at minimum) a username and
        password.
    [ x ] Login: Users, once registered, should be able to log in to your website with their username and password.
    [ x ] Logout: Logged in users should be able to log out of the site.
    [ x ] Import: Provided for you in this project is a file called books.csv
    [ x ] Search for books
    [ x ] Search: Once a user has logged in, they should be taken to a page where they can search for a book. Users
        should be able to type in the ISBN number of a book, the title of a book, or the author of a book. If the user
        typed in only part of a title, ISBN, or author name, your search page should find matches for those as well!
    [ x ] Leave revies for individual books
    [ x ] Review Submission: On the book page, users should be able to submit a review: consisting of a rating on a
    scale of 1 to 5, as well as a text component to the review where the user can write their opinion about a book.
    Users should not be able to submit multiple reviews for the same book.
    [ x ] Book Page: When users click on a book from the results of the search page, they should be taken to a book
    page, with details about the book: its title, author, publication year, ISBN number, and any reviews that users
    have left for the book on your website.
    [ x ] See Review made by others
    [ x ] Calculate avg of rating on BookReview
    [ x ] API by Goodreads
    [ x ] Goodreads Review Data: On your book page, you should also display (if available) the average rating and
    number of ratings the work has received from Goodreads.
    [ x ] query for book details and book reviews programmatically via your website’s API