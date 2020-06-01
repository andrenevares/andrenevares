from bs4 import BeautifulSoup
import requests

pagina = "https://br.ebay.com/b/HVAC-Refrigeration/42909/bn_2312341"

fonte = requests.get(pagina).text

soup = BeautifulSoup(fonte, 'lxml')

print(soup)
