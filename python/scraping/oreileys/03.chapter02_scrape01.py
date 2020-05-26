from urllib.request import urlopen
from bs4 import BeautifulSoup

url = urlopen('http://www.pythonscraping.com/pages/warandpeace.html')
soup = BeautifulSoup(url, 'html.parser')

names = soup.find_all('span', class_={'green'})
for name in names:
    print(name.text)
