from urllib.request import urlopen
from bs4 import BeautifulSoup

url = urlopen('http://www.pythonscraping.com/pages/page3.html')
soup = BeautifulSoup(url, 'html.parser')

"""
Filhos são diferentes de descententes

Filhos: São o nível imediatamente abaixo dos pais

Descendentes: Em qualquer lugar abaixo dos pais (inclusive filhos)
"""

for child in soup.find('table', {'id': 'giftList'}).children:
    print(child)
