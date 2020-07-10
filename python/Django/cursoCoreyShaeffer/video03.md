# Part 3 - Templates
> Python Django Tutorial: Full-Featured Web App Part 3 - Templates

## O que veremos
- Como usar templates de modo a ter uma apresentação melhor de Layout
- Bem como passar variáveis para os respectivos templates

## Templates

### Criando diretório ```templates```
- Para usar templates tempos que criar um diretório chamado ```templates``` dentro do nosso diretório ```blog```.
- Por padrão o django vai procurar um diretório chamado ```templates``` em cada app instalado.
- Como ainda não instalamos ainda nenhum app...
- Por padrão tempos que criar um novo diretório ```[com_mesmo_nome_do_app]``` dentro do diretório ```templates```.
- Logo vamos criar um  diretório chamado ```blog``` dentro do diretório ```templates```

### Estrutura ```tree```
```
├───blog
│   ├───migrations
│   ├───templates
│   │   └───blog
│   └───__pycache__
└───blogproject
    └───__pycache__
```

### Criando primeiro template

Vamos criar template:
- Um para homepage --> (
- Outro para nossa página about --> 



### Inserir nosso app dentro de ```settings.py```



1. Vamos abrir o arquivo ```blog > apps.py```

O conteúdo do nosso arquivo é:
```
from django.apps import AppConfig

class BlogConfig(AppConfig):
    name = 'blog'
```

Quando criamos o nosso app foi criada ```class BlogConfig(AppConfig):```

2. Vamos pegar esse ```BlogConfig``` app e copiar para ```blogproject > settings.py```

3. Vamos abrir ```blogproject > settings.py```

Nosso ```blogproject > settings.py``` contém:
```
INSTALLED_APPS = [
    'django.contrib.admin',
    'django.contrib.auth',
    'django.contrib.contenttypes',
    'django.contrib.sessions',
    'django.contrib.messages',
    'django.contrib.staticfiles',
]
```

4. Vamos adcionar o ```BlogConfig``` app.
- Está dentro de blog > apps >  BlogConfig
- Dessa forma vamos adcionar 
- ```'blog.apps.BlogConfig',```

Nosso vódigo ficará:
```
INSTALLED_APPS = [
    'blog.apps.BlogConfig',
    'django.contrib.admin',
    'django.contrib.auth',
    'django.contrib.contenttypes',
    'django.contrib.sessions',
    'django.contrib.messages',
    'django.contrib.staticfiles',
]
```

### Não esqueça de sempre inserir dentro do ```settings.py``` do projeto:
Porque???

Ora... Django precisa saber onde procurar !

Será com essa configuração que o DJANGO irá saber onde procurar
- Templates
- Modules (banco de dados)



### Apontar as views do ```blog > views.py``` para o template

Vamos abrir o arquivo ```blog > views.py```.

Ele está assim no momento:
```
from django.shortcuts import render
from django.http import HttpResponse

def home(request):
    return HttpResponse('<h1>Blog Homepage</h1>')

def about(request):
    return HttpResponse('<h1>Blog About Page</h1>')
```

Vamos usar somente ```render``` que o próprio django cria para gente quando criamos o app.


#### Vamos alterar a função ```home()```
```
def home(request):
    return render(request, 'blog/home.html')
```
A função ```render``` tem 03 argumentos :
1. recebe o objeto ```request``` como primeiro argumento
2. O nome do template que queremos renderizar.  A maneira que usamos para especificar é: 1º subdiretório dentro do diretório ```templates```, que no nosso caso é ```blog```... depois usamos o nome do nosso template... que no caso é ```home.html``` ... Logo o segundo argumento será ```'blog/home.html'```
3. ```context``` _opcional_:  é como passaremos a informação para o nosso template



### Removemos o ```HttpResponse```

O nosso ```views.py``` está assim:

```
from django.shortcuts import render

def home(request):
    return render(request, 'blog/home.html')

def about(request):
    return render(request, 'blog/home.html')
```

### Usando sample dada para testes...

- Vamos criar uma lista com um conteúdo qualquer... 
- Essa lista vai ser uma lista de dicionários
- Cada dicionário será uma lista associada a um post! 

```
posts = [
    {
        'author': 'André Nevares',
        'title': 'Blog Post 01',
        'content': 'Primeiro conteúdo do Blog',
        'date_posted': '28/10/2016'
    },
    {
        'author': 'André1 Nevares',
        'title': 'Blog Post 02',
        'content': 'Segundo conteúdo do Blog',
        'date_posted': '28/10/2017'
    }
]
```

- Dentro da nossa função home vamos criar um dicionário chamado ```context```
- vamos criar uma __chave__ chamada de __posts__
- o valor que nós vamos usar será a lista de posts que nós criamos no topo do arquivo
- dessa forma será: ```'posts' (chave): posts(lista de valores)```

A sintaxe do dicionário:
```
context = {
    'posts': posts
}
```

Agora podemos usar dentro da função ```render```
- Fazendo isso nós passamos os valores para a função ```render```
- Isso vai nos permitir usar esses valores dentro do template
```
return render(request, 'blog/home.html', context)
```



Dessa forma nossa função home fica
```
from django.shortcuts import render

posts = [
    {
        'author': 'André Nevares',
        'title': 'Blog Post 01',
        'content': 'Primeiro conteúdo do Blog',
        'date_posted': '28/10/2016'
    },
    {
        'author': 'André1 Nevares',
        'title': 'Blog Post 02',
        'content': 'Segundo conteúdo do Blog',
        'date_posted': '28/10/2017'
    }
]

def home(request):
    context = {
        'posts': posts
    }
    return render(request, 'blog/home.html', context)

def about(request):
    return render(request, 'blog/home.html')
```

No nosso template vamos usar:
```
{% for post in posts %}
    <h3>{{ post.title }}</h3>
    <p>{{ post.content }}</p>
    <p>em {{ post.date_posted }} por {{ post.author }} </p>
{% endfor %}
```

```
```
