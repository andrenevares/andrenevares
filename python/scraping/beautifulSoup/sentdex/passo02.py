from bs4 import BeautifulSoup
import requests

pagina = "https://pythonprogramming.net/parsememcparseface/"

fonte = requests.get(pagina).text

soup = BeautifulSoup(fonte, 'lxml')

# print(soup)

# for paragrafo in soup.find_all('p'):
#     print(paragrafo.text)

print(soup.get_text())
