import bs4
from urllib.request import urlopen as uReq
from bs4 import BeautifulSoup as soup

my_url = 'https://www.kabum.com.br/'

# Opening a connection, grabbing the Page
uClient = uReq(my_url)
# Storage in Variable
page_html = uClient.read()
# Close Connection
uClient.close()

# Html Parsing
pagesoup = soup(page_html, "html.parser")

containers = page_soup.findAll("div", {"class": "sc-fzqARJ eITELq"})
