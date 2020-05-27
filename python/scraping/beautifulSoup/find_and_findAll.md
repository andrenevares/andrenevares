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
É um elemento do tipo Boolean ou seja terá valor ```True``` ou ```False```.
- Por padrão o BeatutifulSoup adota o padrão ```True```

- ```True```: Ao usar ```find.all()``` com valor de recursividade = ```True``` será feita uma busca em todos os elementos descendentes...  Isto é filhos, filhos dos filhos.... E assim por diante
- ```False```: Ao usar ```find.all()``` com valor de recursividade = ```False``` será feita uma busca __apenas nos filhos__. Ous seja nos elementos imediatamente abaixo. 


#### string
> O livro _Web Scraping with Python, 2nd Edition_ utiliza a nomenclatura __Text__.  No entanto ao analisar a documentação do BeautifulSoup (27/05/2020) encontramos o termo __String__

- Trata-se de algo extremamente específico.
- O livro _Web Scraping with Python, 2nd Edition_ traz o exemplo de uma página HTML onde há determinados termos destacados por meio de ```<span></span>``` 
- Dessa forma se colocarmos:

```
names = soup.find_all(text='the prince')
print(len(names))
```
- iremos buscar o a expressão *__the prince__* que  esteja dentro de tags.
- procuramos algo como ```<span>the prince</span>``` ou ```<h1>the prince</h1>```

#### limit

#### keywords

