# Criar um app com HTTP response


Desafio:  Criar um projeto e colocar duas páginas.  Uma home e outra Sobre.


Pré-requisitos: 
- Se houver Virtual Enviromenyt, que ele esteja ativado
- Ter o Django Instalado;
- Ter o um projeto django criado


Solução:
1. Criar __nome_app__
2. nome_projeto > __urls.py__ 
3. nome_app > __views.py__ 

## 1. criar nome_app

```django-admin startapp nome_app```

## 2. Ajustes nome_projeto > __urls.py__

```
(...)
from nome_app import views

path ('', views.home)
path ('sobre', views.sobre)
```

## 3. Ajustes nome_app > __views.py__ 

```
from django.shortcuts import render
from django.http import HttpResponse

def home(request):
  return HttpResponse('Olá eu sou uma home page bem simples...')
  
def sobre(request):
  return HttpResponse('Eu não sei o que dizer, então vou falar sobre') 
```

VOILÁ!

