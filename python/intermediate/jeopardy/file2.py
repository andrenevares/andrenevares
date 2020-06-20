import sqlite3

con = sqlite3.connect('jeopardy.db')
cur = con.cursor()

cur.execute("SELECT text, answer, value FROM clue LIMIT 10")
results = cur.fetchall()

for clue in results:
    text = clue[0]
    answer = clue[1]
    value = clue[2]

    # [$200]
    # Question: kjslkdj ALSD
    # value: What is 'sadfapdofiadfad sfp'

    print("[$%s]" % (value,))
    print("Question: %s" % (text,))
    print("Answer: What is '%s'" % (answer,))
    print()

con.close()
