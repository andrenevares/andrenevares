from urllib.request import urlopen
from bs4 import BeautifulSoup

url = urlopen('http://www.pythonscraping.com/pages/page3.html')
soup = BeautifulSoup(url, 'html.parser')

# a tabela possui um cabeçalho com:
# Item Title | 	Description | Cost | Image
# usando next.siblings nós pulamos este!
# segundo o autor objetos não podem ser irmãos deles mesmos
# e também temos a expressão next!

for sibling in soup.find('table', {'id': 'giftList'}).tr.next_siblings:
    print(sibling)
