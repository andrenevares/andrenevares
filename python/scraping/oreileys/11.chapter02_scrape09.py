from urllib.request import urlopen
from bs4 import BeautifulSoup
import re

html = urlopen('http://www.pythonscraping.com/pages/page3.html')
soup = BeautifulSoup(html, 'html.parser')

images = soup.find_all('img', src=re.compile('.*.(jpg|png|svg)'))
for image in images:
    print(image.attrs['src'])
