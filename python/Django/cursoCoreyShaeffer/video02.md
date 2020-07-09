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

### Comparando ```urls.py``` 

Agora temos:
- ```urls.py``` do app
- ```urls.py``` do projeto

O ```urls.py``` do app está em branco.  Enquanto que o ```urls.py``` do projeto contém esse código:

```
from django.contrib import admin
from django.urls import path

urlpatterns = [
    path('admin/', admin.site.urls),
]
```

### Código do ```urls.py``` do app

Copiamos o trecho do código do ```urls.py``` do projeto e colamos no nosso ```urls.py``` do app.
```
from django.urls import path

urlpatterns = [
    path('admin/', admin.site.urls),
]
```

Nós também estaremos usando a funçao home dentro do nosso ```urls.py``` do app.  Dessa forma precisamos importar o módulo ```views.py``` para dentro do ```urls.py``` do app.

Para iso vamos usar:
```from . import views``` 
> ponto significa o diretório atual

```
from django.urls import path
from . import views

urlpatterns = [
    path('admin/', admin.site.urls),
]
```

Temos que ajustar o ```path```.  Como nós queremos que seja home, podemos trocar:

```path('admin/', admin.site.urls),```

por 

```path('', views.home, name='blog-home')```
- Temos um path vazio
- Apontando para a função home dentro de views
- Com nome = 'blog-home'



OK... Agora já temos o arquivo ```blog > urls.py``` apontando para a função ```home``` que está dentro do nosso arquivo ```views.py```

Mas isso ainda não vai fucionar... Precisamos ajustar o ```blogproject > urls.py``` de modo a apontar para o ```blog > urls.py```.

Para isso vamos abrir ```blogproject > urls.py```.

Nosso ``blogproject > urls.py``` está assim:
```
from django.contrib import admin
from django.urls import path

urlpatterns = [
    path('admin/', admin.site.urls),
]
```

Vamos falar pro django onde estão as urls do nosso app.

Para isso precisamos importar ```include```.

```from django.urls import path, include```

Agora com o include nós podemos colocar as urls do app.
```
from django.contrib import admin
from django.urls import path, include

urlpatterns = [
    path('admin/', admin.site.urls),
    path('blog/', include('blog.urls')),
]
```

Agora que fizemos todo esse trabalho vamos testar para ver se funciona!

```python manage.py runserver```
