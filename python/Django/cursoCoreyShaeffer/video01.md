# Python Django Tutorial: Full-Featured Web App Part 1 

## Getting Started

### Resumo do que temos aqui

- [Link do vídeo 01]()
- [Abrir o Editor de Texto]()
- [Criar diretório para os Projetos Django]()
- [Ajustes do GitHub]()
- [Criar um Ambiente Virtual]()
- [Ativar Ambiente Virtual]()
- [Instalar o Django]()
- [Confirmando se a instalação teve sucesso]()
- [Indo para o diretório onde criarei o meu projeto]()
- [Como saber os Subcomandos do Django]()
- [Iniciando um projeto Django]()
- [Estrutura do projeto meu projeto Django]()
- [Vamos até o diretório onde está o ```manage.py]()
- [Comando runserver]()
- [urls.py]()
- [Parar o servidor]()

### Link do Video
[Python Django Tutorial: Full-Featured Web App Part 1 - Getting Started](https://youtu.be/UmljXZIypDc)

### Abrir seu editor de texto
Comecei abrindo o meu VSCODE

### Criar um diretório para seus projetos do django
Fui até a raiz do meu HD ```D:``` e criei uma pasta chamada ```django```
```
D:\django
```
### Sincronizar com GITHUB
Depois fui até meu github e criei um repositório chamado ```gitone```

Agora vou fazer o meu ```git clone``` de modo a trazer para minha máquina o repositório do github.  Com isso eu posso deixar a cópia do meu código na WEB... Se eu quiser acessar esse projeto de outro lugar, basta eu fazer um ```git clone``` e boa!

com um terminal aberto vou até o diretório ```D:\django```

Se você estiver usando o VSCODE pode usar o <kbd>ctrl</kbd>+<kbd>'</kbd> que será aberto um terminal no próprio VSCODE.

```D:\django> git clone https://github.com/andrenevares/DjangoOne.git```

```
D:\django
      | - DjangoOne
```

### Criar um Ambiente virtual (Virtual Enviroment)
Vou criar um virtual enviroment dentro do Django!

Se você não tem instalado [virtual enviroment](https://github.com/andrenevares/andrenevares/blob/master/venv/virtual_enviroment.md) e quiser saber um pouco mais eu coloco aqui link de uma anotação de como criar [virtual enviroment](https://github.com/andrenevares/andrenevares/blob/master/venv/virtual_enviroment.md).

Sendo assim...

Vou criar um virtual enviroment chamado venv:  ```D:\django> virtualenv venv```

```
D:\django
      | - DjangoOne
      | - venv
```

### Ativar o seu ambiente virtual

Comando para ativar um ambiente virtual: ```venv\Scripts\activate```

```D:\django> venv\Scripts\activate```

O resultado deverá ser algo mais ou menos assim:

```(venv) PS D:\django>```

### Instalando Django

Comando para instalar o django via pip:```pip install django```

```(venv) PS D:\django>pip install django```

### Confirmando se a instalação teve sucesso

Comando para saber a versão do django: ```python -m django --version```

```
(venv) PS D:\django> python -m django --version
3.0.8
```

No momento em que estamos fazendo essa anotação a versão do Django está em __3.0.8__

### Indo para o diretório onde criarei o meu projeto

```
D:\django
      | - DjangoOne  # quero criar aqui meu projeto!
      | - venv
```

```cd DjangoOne```


### Subcomandos do Django
No terminal digite ```django-admin```

### Iniciando um projeto Django
No terminal digite ```django-admin startproject [nome_do_projeto]```.

Se o seu projeto for blog irá digitar ```django-admin startproject blogproject```
```
D:\django
      | - DjangoOne  
      |     | - blogproject
      |     |     | - blogproject
      |     |     |     | - __init__.py 
      |     |     |     | - asgi.py  
      |     |     |     | - settings.py  
      |     |     |     | - urls.py  
      |     |     |     | - wsgi.py  
      |     | - manage.py  
      | - venv
```

Para ficar mais claro vamos trabalhar somente com a parte do projeto ok?

- O diretório ```D:\django``` foi criado para deixar o que for de Djando dentro dele
- O diretório ```D:\DjangoOne``` foi criado para poder trabalhar com o GIT 
- O diretório ```D:\venv``` está fora do ```D:\DjangoOne``` logo não será clonado para o GIT

### Estrutura do projeto meu projeto Django

```
- blogproject
    | - blogproject
    |     | - __init__.py 
    |     | - asgi.py  
    |     | - settings.py  
    |     | - urls.py  
    |     | - wsgi.py  
- manage.py  
```

### Vamos até o diretório onde está o ```manage.py```

Vamos até o diretório onde está o manage.py

```cd blogproject```

Chagamos ao diretório ```(venv) PS D:\django\DjangoOne\blogproject>```

### Comando runserver

Agora vamos rodar o comando: ```python manage.py runserver```


Starting development server at http://127.0.0.1:8000/

- ```http://127.0.0.1``` é a mesma coisa que ```http://localhost```
- vamos usar então ```http://localhost:8000/```


### urls.py

Se analisarmos o código dentro do arquivo url.py veremos que é ele que permite que designa a aplicação.
```
from django.contrib import admin
from django.urls import path

urlpatterns = [
    path('admin/', admin.site.urls),
]
```

### Parar o servidor

<kbd>Ctrl</kbd>+<kbd>C</kbd>
