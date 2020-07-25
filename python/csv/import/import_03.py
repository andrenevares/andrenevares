import csv
import psycopg2

#connect into the db
con = psycopg2.connect(
            host="ec2-107-22-238-217.compute-1.amazonaws.com",
            database="d7886b851q5qft",
            user="chjzrrwvocfyun",
            password="6c767d53f89a96526ac9f34f9824fb72b38789bc547689982362ae408450fd3e",
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