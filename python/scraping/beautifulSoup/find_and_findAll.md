# find() and find_all() no BeautifulSoup

```find_all(tag, attributes, recursive, string, limit, keywords)```

#### tag
exemplo: 
```.find_all(['h1','h2','h3'])```
Nesse caso vamos buscar __header1__, __header2__, __header3__

#### attributes
```.find_all('span', {'class':{'green', 'red'}})```
é a mesma coisa que

```.find_all('span', class_='green')```
> class é uma palavra reservada.  Então o Beuatiful soup encontrou duas maneiras de permitir o uso da palavra. A primeira usando dentro de colchetes 
```{ }``` a outra é utilizando um *__undersore__*
#### recursive

#### string

#### limit

#### keywords

