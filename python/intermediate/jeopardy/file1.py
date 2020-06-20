import sqlite3

con = sqlite3.connect("jeopardy.db")
cur = con.cursor()
cur.execute("SELECT name FROM category LIMIT 10")
results = cur.fetchall()

print("Example of categories:\n")

for category in results:
    print(category[0])

con.close()
