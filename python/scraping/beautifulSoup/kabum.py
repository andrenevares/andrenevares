from bs4 import BeautifulSoup
import requests

pagina = "https://www.youtube.com/user/BrunoSalgueiro2010/videos"

fonte = requests.get(pagina).text

soup = BeautifulSoup(fonte, 'lxml')

itens = soup.find('div', class_='contents')

print(itens)
