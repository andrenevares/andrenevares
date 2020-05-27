from urllib.request import urlopen
from bs4 import BeautifulSoup

url = urlopen('http://www.pythonscraping.com/pages/warandpeace.html')
soup = BeautifulSoup(url, 'html.parser')

# Vamos criar um exemplo onde contemos quantas vezes aparece
# 'the prince' entre tags!!!
names = soup.find_all(text='the prince')
print(len(names))
