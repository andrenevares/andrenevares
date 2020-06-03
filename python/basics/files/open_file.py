f = open("countries.txt", "r")

countries = []  # explicit an empty list

for line in f:
    line = line.strip()  # remove white spaces
    countries.append(line)  # add the line into a list

f.close()

print(len(countries))

# print countries that starts from a T
for country in countries:
    if country[0] == "T":
        print(country)
