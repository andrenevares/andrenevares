import csv

with open('books.csv', 'r') as csv_file:
    csv_reader = csv.reader(csv_file)
    
    for line in csv_reader:
        #index 2 print just the third columns it just shows the author
        #our csv contains isbn[0] / title[1] / author[2] / year[3] 
        print(line[2])