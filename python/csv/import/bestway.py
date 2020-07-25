import psycopg2

conn = psycopg2.connect(
            host="ec2-107-22-238-217.compute-1.amazonaws.com",
            database="d7886b851q5qft",
            user="chjzrrwvocfyun",
            password="6c767d53f89a96526ac9f34f9824fb72b38789bc547689982362ae408450fd3e",
            port="5432")
cur = conn.cursor()
with open('books.csv', 'r') as f:
    # Notice that we don't need the `csv` module.
    next(f) # Skip the header row.
    cur.copy_from(f, 'book2', sep=',')
    conn.commit()