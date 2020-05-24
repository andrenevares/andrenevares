from bs4 import BeautifulSoup
import requests

pagina = "https://pythonprogramming.net/parsememcparseface/"

fonte = requests.get(pagina).text

soup = BeautifulSoup(fonte, 'lxml')

print(soup)
