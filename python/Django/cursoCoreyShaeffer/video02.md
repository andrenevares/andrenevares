# Python Django Tutorial: Full-Featured Web App Part 2 
> Notes from Mscorey, made by André Nevares 
## Applications and Routes

### Youtube - Video 02 - Link
[Python Django Tutorial: Full-Featured Web App Part 2 - Applications and Routes](https://youtu.be/a48xeeo5Vnk)

### Resumo
- Vamos criar o Django APP
- Adcionar URLS

### Apps no Django
- Você pode ter vários apps em um projeto
- Você pode ter um site, além disso você pode ter um e-commerce
- Na verdade você pode ter vários apps dentro de um mesmo projeto

Podemos elencar duas coisas de positivo:
- Você pode separar os Apps 
- Você pode usar um app em um outro projeto, por exemplo.

### Como começar um App

#### Esteja certo que está no local certo!
Você deve estar no mesmo diretório que o seu projeto... onde fica o ```manage.py```
```
D:\django
      | - DjangoOne  
      |     | - blogproject  # Você deve estar aqui
      |     |     | - blogproject
      |     |     |     | - __init__.py 
      |     |     |     | - asgi.py  
      |     |     |     | - settings.py  
      |     |     |     | - urls.py  
      |     |     |     | - wsgi.py  
      |     | - manage.py  
      | - venv
```

Um jeito fácil de saber é fazendo um ```dir``` no caso de você estar em um prompt de comando do windows, ou ```ls``` no caso de estar em uma plataforma linux.

#### Comando ```startapp```

```python manage.py startapp [nome_do_app]```

Se você quer criar um app chamdo __blog__ deverá digitar

```python manage.py startapp blog```

### Estrutura do projeto com APP criado

```
> blogproject
    | > blog
    |     | > migrations
    |     |       | - __init__.py
    |     | - __init__.py
    |     | - admin.py
    |     | - apps.py
    |     | - models.py
    |     | - tests.py
    |     | - view.py
    | > blogproject
    |     | - __init__.py 
    |     | - asgi.py  
    |     | - settings.py  
    |     | - urls.py  
    |     | - wsgi.py  
- manage.py  
```

### Blog > Views.py

Quando abrimos o ```views.py``` nós encontramos:

```
from django.shortcuts import render
```

#### Importar ```Http.Response```
Vamos adcionar o ```Http.Response```

Dessa forma nosso arquivo ```views.py``` fica assim:

```
from django.shortcuts import render
from django.http import HttpResponse
```
#### Criar a primeira função home 
Agora vamos criar uma nova função, vamos chamar essa função de HOME. 
- Essa função HOME vai cuidar das requisições feitas para a HOMEPAGE do nosso blog.
- Essa função precisa do ```request``` argument para que a função funcione

Nossa função ficaria assim:
```
def home(request):
    return HttpResponse('<h1>Blog Homepage</h1>')
```

### Criar Blog > ```urls.py```

Bem nós definimos a lógica quando um usuári for para nossa homepage.... No entanto, não mapeamos as URLS de modo que o djago saiba como fazer isso. 

Então nós temos que criar um novo módulo chamado ```urls.py``` dentro do nosso app Blog.

Será nesse arquivo que vamos colocar qual URL corresponderá a que função. 

```
> blogproject
    | > blog
    |     | > migrations
    |     |       | - __init__.py
    |     | - __init__.py
    |     | - admin.py
    |     | - apps.py
    |     | - models.py
    |     | - tests.py
    |     | - view.py
    |     | - urls.py  # esse url.py é do APP
    | > blogproject
    |     | - __init__.py 
    |     | - asgi.py  
    |     | - settings.py  
    |     | - urls.py  # esse url.py é do Projeto
    |     | - wsgi.py  
- manage.py  
```




