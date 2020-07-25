# Importing data from CSV into Postgree
> By André Nevares for CS50 web programming with python and javascript

## The original File
The original file : import.py 
Course: CS50 Web Programming with Python and JavaScript
Subject: SQL

## Problem 01
I was unable to parse data using psycopg2 extension... Why?
Cause some books have commas ....
So, i tried to change the delimiter...
The solution was ok... But something do not match... if you know what i mean...

## Problem 02
This specif file do not find the csv file... 
The csv file was in the directory, you can check...

The solution:  type the role path into the code

## Problem 03
Conncetions problems using virtual enviroment variable.
So... i had to write the full URL...
I Know it´s not safe... but it works...

## Create Data Base on Adminer
You can see all the SQL codes that have created the tables inside 

## Code to parse data:
```
import csv
import os

from sqlalchemy import create_engine
from sqlalchemy.orm import scoped_session, sessionmaker

DB_URL = 'postgres://chjzrrwvocfyun:6c767d53f89a96526ac9f34f9824fb72b38789bc547689982362ae408450fd3e@ec2-107-22-238-217.compute-1.amazonaws.com:5432/d7886b851q5qft'

engine = create_engine('postgres+psycopg2://chjzrrwvocfyun:6c767d53f89a96526ac9f34f9824fb72b38789bc547689982362ae408450fd3e@ec2-107-22-238-217.compute-1.amazonaws.com:5432/d7886b851q5qft')
db = scoped_session(sessionmaker(bind=engine))

def main():
    f = open("books.csv")
    reader = csv.reader(f)
    next(reader)
    
    for isbn, title, author, year in reader:
        db.execute("INSERT INTO book (isbn, title, author, year) VALUES (:isbn, :title, :author, :year)",
                    {"isbn": isbn, "title": title, "author": author,"year": year})
        print(f"Added book with {isbn} -- {title} -- {author} -- {year}.")
    db.commit()

if __name__ == "__main__":
    main()
```

## Final
I felt that the code is too slow...
Maybe on the future i will be able to write a better code.
Now... i am trying to understand what i am doing...
Sometimes, lik



