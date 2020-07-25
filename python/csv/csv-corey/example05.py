import csv

with open('names.csv', 'r') as csv_file:
    csv_reader = csv.DictReader(csv_file)
    
    with open('new_names_2', 'w') as new_file:
        fieldnames = ['isbn', 'title', 'author', 'year']
        
        csv_writer = csv.DictWriter(new_file, fieldnames=fieldnames, delimiter='\t', lineterminator = '\n')
        csv_writer.writeheader()
        
        for line in csv_reader:
            csv_writer.writerow(line)


