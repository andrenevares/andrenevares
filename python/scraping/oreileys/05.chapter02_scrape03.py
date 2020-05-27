from urllib.request import urlopen
from bs4 import BeautifulSoup

url = urlopen('http://www.pythonscraping.com/pages/warandpeace.html')
soup = BeautifulSoup(url, 'html.parser')

# vai retornar os elementos com tag span que tiverem tanto green como red nos seus atributos
names = soup.find_all('span', class_={'green', 'red'})
for name in names:
    print(name.get_text())
