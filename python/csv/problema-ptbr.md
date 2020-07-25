# Problema para inserir dados no Postgree via Python usando psycopg2

Estou tentando de tudo quanto é jeito...
Se alguém puder me dar uma foeça fico grato!

Eu estou rodando esse código... 

Consegui me conectar ao Banco de Dados sem problemas...

## CSV File Link
https://github.com/andrenevares/bookreview/blob/master/project1/books.csv

## Error Message
.... Mas quando eu tento rodar esse código de forma a inserir dados no banco....


```
Traceback (most recent call last):
  File "import.py", line 26, in <module>
    cur.execute('INSERT INTO "book" (isbn, title, author, year_published) VALUES ((isbn), (title), (author), (year_published))')
psycopg2.errors.UndefinedColumn: column "isbn" does not exist
LINE 1: ...k" (isbn, title, author, year_published) VALUES ((isbn), (ti...
                                                             ^
HINT:  There is a column named "isbn" in table "book", but it cannot be referenced from this part of the query.

```


## Meu código

```
import csv
import psycopg2

#connect into the db
con = psycopg2.connect(
            host="...",
            database="...",
            user="...",
            password="...",
            port="5432")

with open('books.csv', 'r') as csv_file:
    csv_reader = csv.reader(csv_file)
    next(csv_reader)

    for line in csv_reader:
        #index 2 print just the third columns it just shows the author
        #our csv contains isbn[0] / title[1] / author[2] / year[3] 
        isbn = line[0]
        title = line[1]
        author = line[2]
        year_published = line[3]
        #cursor
        cur = con.cursor()  
        #execute query
        cur.execute('INSERT INTO "book" (isbn, title, author, year_published) VALUES (isbn, title, author, year_published)')
        #Close the cursor
        cur.close()
#close the connection
con.close()
```

Alguém aí consegue me dar um HELP?
