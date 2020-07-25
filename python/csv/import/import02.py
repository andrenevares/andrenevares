# Thanks for Hussein Nasser
import psycopg2
import csv

def main()
    f = open("flights.csv")
    reader = csv.reader(f)

    print(reader)


#connect into the db
con = psycopg2.connect(
            host="ec2-107-22-238-217.compute-1.amazonaws.com",
            database="d7886b851q5qft",
            user="chjzrrwvocfyun",
            password="6c767d53f89a96526ac9f34f9824fb72b38789bc547689982362ae408450fd3e",
            port="5432")

#cursor
cur = con.cursor()

#execute query
cur.execute('select * from "user"')

#rows = cur.fetchall()

for isbn in rows:
    print (f"id {r[0]} - {r[1]} - {r[2]}" )

#Close the cursor
cur.close()

#close the connection
con.close()

if __name__ == "__main__":
    main()

