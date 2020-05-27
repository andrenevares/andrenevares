from urllib.request import urlopen
from bs4 import BeautifulSoup

html = urlopen('http://www.pythonscraping.com/pages/page3.html')
soup = BeautifulSoup(html, 'html.parser')
print(soup.find('img',
                src='../img/gifts/img2.jpg')
      .parent.previous_sibling.get_text())
