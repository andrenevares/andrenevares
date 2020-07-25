import csv
import os

from sqlalchemy import create_engine
from sqlalchemy.orm import scoped_session, sessionmaker

# i try to use  Virtual Enviroment with name DATABASE_URL
# It fails
# I have to type HARDCODE...
engine = create_engine(
    "postgres+psycopg2://chjzrrwvocfyun:6c767d53f89a96526ac9f34f9824fb72b38789bc547689982362ae408450fd3e@ec2-107-22-238-217.compute-1.amazonaws.com:5432/d7886b851q5qft")
db = scoped_session(sessionmaker(bind=engine))


def main():
    # the csv is the same diretory, but the .py file
    # just can not find it.
    # So i type the full path... and it works
    f = open("d:/codigos/cs50/99.projects/BookReview/import_books/books.csv")
    reader = csv.reader(f)
    next(reader)  # Use this to skip header from CSV... Otherwise you will insert into your database the header of your CSV
    n = 1
    for isbn, title, author, year in reader:
        n = n + 1
        db.execute("INSERT INTO books (isbn, title, author, year) VALUES (:isbn, :title, :author, :year)",
                   {"isbn": isbn, "title": title, "author": author, "year": year})
        print(
            f"Added book with {isbn} -- {title} -- {author} -- {year} -- {n}.")

    db.commit()


if __name__ == "__main__":
    main()
