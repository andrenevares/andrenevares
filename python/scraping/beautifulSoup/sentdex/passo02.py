from bs4 import BeautifulSoup
import requests

page = "https://en.wikipedia.org/wiki/Main_Page"

page_text = requests.get(page).text

soup = BeautifulSoup(page_text, 'lxml')

# print(soup)
links = []
links = soup.find_all("a")
print(links)

# print(soup.get_text())
