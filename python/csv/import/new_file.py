import psycopg2

class DatabaseConnection:
    def __init__(self):
        try:
            self.connection = psycopg2.connect(
                host="ec2-107-22-238-217.compute-1.amazonaws.com",
                database="d7886b851q5qft",
                user="chjzrrwvocfyun",
                password="6c767d53f89a96526ac9f34f9824fb72b38789bc547689982362ae408450fd3e",
                port="5432")
            self.connection.autocommit = True
            self.cursor = self.connection.cursor()
        except:
            print("Cannot connect to the Postgree DataBase")
    
    def create_table(self)
        create_table_command = 'CREATE TABLE "pet" (id serial PRIMARY KEY, name varchar(100), age integer NOT NULL)'
        self.cursor.execute(create_table_command)

    def insert_new_record(self):
        new_record = ("misa meo2", "9")
        inser_command = 'INSERT INTO "pet" VALUES ('" + new_record[0] + "', '" + new_record[1] + "')'
        print(inser_command)
        self.cursor.execute(inser_command)

if __name__ = 'main':
    database_connection = DatabaseConnection()   
    database_connection.create_table()