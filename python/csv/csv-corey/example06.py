import csv
from flask import Flask
from flask_sqlalchemy import SQLAlchemy
from flask_bcrypt import Bcrypt
from flask_login import LoginManager


app = Flask(__name__)
app.config['SQLALCHEMY_TRACK_MODIFICATIONS'] = False
app.config['SECRET_KEY'] = '5791628bb0b13ce0c676dfde280ba245'
# postgresql://username:password@host:port/database
app.config['SQLALCHEMY_DATABASE_URI'] = 'postgresql://chjzrrwvocfyun:6c767d53f89a96526ac9f34f9824fb72b38789bc547689982362ae408450fd3e@ec2-107-22-238-217.compute-1.amazonaws.com:5432/d7886b851q5qft'
db = SQLAlchemy(app)



with open('names.csv', 'r') as csv_file:
    csv_reader = csv.DictReader(csv_file)
    
    with open('new_names_2', 'w') as new_file:
        fieldnames = ['isbn', 'title', 'author', 'year']
        
        print(csv_reader.isbn)
        
                
        for line in csv_reader:
            csv_writer.writerow(line)


