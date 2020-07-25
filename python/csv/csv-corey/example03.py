import csv

with open('books.csv', 'r') as csv_file:
    csv_reader = csv.reader(csv_file)

# next will jump the first line
# so if it has a header, like our csv, we do not insert these into our database

    next(csv_reader)

    for line in csv_reader:
        #index 2 print just the third columns it just shows the author
        #our csv contains isbn[0] / title[1] / author[2] / year[3] 
        isbn_value = line[0]
        title_value = line[1]
        author_value = line[2]
        year_value = line[3]

        print (f"The book with {isbn_value} has the title of {title_value} was written by {author_value} in {year_value}")
