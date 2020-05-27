# .children() vs. .descendants()

## .children()

#### Exemplo:
```
from urllib.request import urlopen
from bs4 import BeautifulSoup

url = urlopen('http://www.pythonscraping.com/pages/page3.html')
soup = BeautifulSoup(url, 'html.parser')

for elemento in soup.find('table', {'id': 'giftList'}).children:
    print(elemento)
```

#### Output:
Irá restornar __apenas os filhos__ da tag ```<table>``` que contenham a ```id``` igual a ```giftList```

## .descendants()
### Exemplo:
```
from urllib.request import urlopen
from bs4 import BeautifulSoup

url = urlopen('http://www.pythonscraping.com/pages/page3.html')
soup = BeautifulSoup(url, 'html.parser')

for elemento in soup.find('table', {'id': 'giftList'}).descendants:
    print(elemento)
```
#### Output:
Irá restornar __Todos os elementos descentes__ da tag ```<table>``` que contenham a ```id``` igual a ```giftList``` __não apenas os filhos__
