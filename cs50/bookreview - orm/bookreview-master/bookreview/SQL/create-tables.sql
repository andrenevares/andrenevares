CREATE TABLE users (
    id SERIAL PRIMARY KEY,
    username VARCHAR NOT NULL UNIQUE,
    password VARCHAR NOT NULL
    review_id INTEGER REFERENCES reviews
);

CREATE TABLE reviews (
    id SERIAL PRIMARY KEY,
    username VARCHAR NOT NULL,
    password VARCHAR NOT NULLs
);

CREATE TABLE books (
    id SERIAL PRIMARY KEY,
    isbn VARCHAR NOT NULL,
    title VARCHAR NOT NULL,
    author VARCHAR NOT NULL,
    book_year VARCHAR NOT NULL
);

INSERT INTO users 
    (id, username, password)
    VALUES (1, 'andrenevares', '123')
