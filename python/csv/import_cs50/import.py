import csv
import os

from sqlalchemy import create_engine
from sqlalchemy.orm import scoped_session, sessionmaker

DB_URL = 'postgres+psycopg2://chjzrrwvocfyun:6c767d53f89a96526ac9f34f9824fb72b38789bc547689982362ae408450fd3e@ec2-107-22-238-217.compute-1.amazonaws.com:5432/d7886b851q5qft'

engine = create_engine('postgres+psycopg2://chjzrrwvocfyun:6c767d53f89a96526ac9f34f9824fb72b38789bc547689982362ae408450fd3e@ec2-107-22-238-217.compute-1.amazonaws.com:5432/d7886b851q5qft')
db = scoped_session(sessionmaker(bind=engine))

def main():
    f = open("flights.csv")
    reader = csv.reader(f)
    for origin, destination, duration in reader:
        db.execute("INSERT INTO flights (origin, destination, duration) VALUES (:origin, :destination, :duration)",
                    {"origin": origin, "destination": destination, "duration": duration})
        print(f"Added flight from {origin} to {destination} lasting {duration} minutes.")
    db.commit()

if __name__ == "__main__":
    main()
