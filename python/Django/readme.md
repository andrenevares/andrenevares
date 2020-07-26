<img src="https://www.djangoproject.com/m/img/logos/django-logo-negative.png" align="right" width="300px">

# Django

Este repositório contém anotações, playlists, materiais e códigos referentes ao estudo do Framework Django. 

## Preparando o ambiente
- [Criar diretório sincronizar com GIT HUB](https://github.com/andrenevares/andrenevares/blob/master/python/Django/tuts/sincronizar_com_git.md)
- [Criar / Ativa um Ambiente virtual (Virtual Enviroment)](https://github.com/andrenevares/andrenevares/blob/master/python/Django/tuts/virtual_env_criar_ativar.md)
- [Subcomandos Django](https://github.com/andrenevares/andrenevares/blob/master/python/Django/tuts/subcomandos.md)

## Intro Django
- [Instalação](https://github.com/andrenevares/andrenevares/blob/master/python/Django/tuts/instalando_django.md)
- [Start Project - Iniciando um projeto](https://github.com/andrenevares/andrenevares/blob/master/python/Django/tuts/iniciando-projeto-django.md)
- [Estrutura de um projeto Django](https://github.com/andrenevares/andrenevares/blob/master/python/Django/tuts/estrutura-projeto-django..md)
- [Listar Comandos django-admin](https://github.com/andrenevares/andrenevares/blob/master/python/Django/tuts/comandos-admin.md)
- [Comando Runserver](https://github.com/andrenevares/andrenevares/blob/master/python/Django/tuts/comando-runserver.md)
- [Apps](https://github.com/andrenevares/andrenevares/blob/master/python/Django/tuts/apps.md)
- [App simples com HttpResponse](https://github.com/andrenevares/andrenevares/blob/master/python/Django/tuts/app_com_http_response.md)
- [Urls](https://github.com/andrenevares/andrenevares/blob/master/python/Django/tuts/urls.md)
- Templates
- Forms
- [documentação models](https://docs.djangoproject.com/en/3.0/ref/models/fields/#field-types)

## Criar app
1. ```python manage.py startpp nome_do_app```
2. adicionar nome_do_app no urls.py dentro do arquivo settings

## Class
```python
from django.db import models

class Project(models.Model):
    title = models.CharField(max_length=100)
    description = models.CharField(max_length=250)
    image = models.ImageField(upload_to='portfolio/images')
    url = models.URLField(blank=True)
```
## Migrations
Todas as vezes que criar/alterar uma class dentro do models.py temos que fazer:
1. ```python manage.pi migrate```
2. ```python manage.pi makemigrations```

## Criar um super user
Para se logar no ```localhost:8000/admin``` nós temos que criar um usuário.  Para isso:

1. ```python manage.py createsuperuser```
2. username: ```seu_super_user_name```
3. email: ```seu_email``` _opcional_
4. password: ```sua_senha``` 

Para mudar a senha do superuser
```python manage.py nome_usuário```

## Admin
Dentro de cada app temos um arquivo ```admin```.  Será aqui que definiremos o que será exibido no painel do admin!

Se criamos um model chamado __Post__ que fica dentro do app __blog__ teremos que fazer

```python
from .models import Post

admin.site.register(Post)
```
> o ```.``` significa que estamos referenciando a mesma pasta.


## Imagens 

Temos que ajustar 
1. ```settings.py``` do projeto
2. ```urls.py``` do projeto

#### ```settings.py```
1. Vá até o arquivo __settings.py__
2. digitar o endereço no final do arquivo utilizando a seguinte sintaxe: ```MEDIA_ROUTE = ''```

Para que funcione em qualquer computador, seja linux, windows, mac... devemos usar a sintace de sistema operacional.

Podemos colar do __DATABASES__ que fica dentro do __settings.py__

```python
MEDIA_URL = '/imagens/' 
MEDIA_ROOT = os.path.join(BASE_DIR, 'media')
```
- MEDIA_URL: será a URL que será exibida no navegador 
- MEDIA_ROOT: será onde ela será salva de fato, seja no servidor, seja na sua máquina

## ```urls.py``` do projeto

```python
(...)
from django.conf.urls.static import static
from django.conf import settings
(...)
urlpatterns += static(settings.MEDIA_URL, document_root=settings.MEDIA_ROOT)
```

## views.py do app
```python
from .models import Nome_do_model

admin.site.register(Nome_do_model)
```



- [Notes Corey Shaeffer](https://github.com/andrenevares/andrenevares/blob/master/python/Django/cursoCoreyShaeffer/readme.md)
