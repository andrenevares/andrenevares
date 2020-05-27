from urllib.request import urlopen
from bs4 import BeautifulSoup

url = urlopen('http://www.pythonscraping.com/pages/warandpeace.html')
soup = BeautifulSoup(url, 'html.parser')

# Vai retornar todos os que tiverem esses títulos
names = soup.find_all(['h1', 'h2', 'h3', 'h4', 'h5', 'h6'])
for name in names:
    print(name.get_text())
