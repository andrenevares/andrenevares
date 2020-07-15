# Parte 06 
> Notes from Mscorey, made by André Nevares 
## User Registration

### Youtube - Video - Link
[Python Django Tutorial: Full-Featured Web App Part 6 - User Registration](https://www.youtube.com/watch?v=q4jPR-M0TAQ&list=PL-osiE80TeTtoQCKZ03TU5fNfx2UY6U4p&index=6)

### O que veremos
- Como usar formulários
- COmo Validar Entradas de usuários

### Criar um app específico para user registration

1. Vamos até o diretório do projeto... É onde fica o ```manage.py```
2. Criamos o app ```user``` por meio do comando ```python manage.py startapp user```
3. Toda vez que criamos um app precisamos adicionar o app dentro da lista de ```INSTALLED_APPS = []``` que fica dentro do ```projeto > setiings.py```
4. Vamos primeiro abrir o ```apps.py``` que fica dentro do nosso novo app, no caso ```users > apps.py```
5. Haverá uma class criada automaticamente por meio do startapp.
6. Perceba que ela esta dentro do diretório ```blog```, dentro do arquivo ```apps.py``` e com o nome de ```UsersConfig```... sendo assim a string que deveremos adcionar ao ```INSTALLED_APPS``` será ```'users.apps.UsersConfig',```

### Ajustando a ```users > views.py```

O arquivo views.py vai cuidar da lógica desse app

### Criamos a register view

```
from django.shortcuts import render

def register(request):
```

### Agora precisamos criar os forms...

1. Importamos o módulo ```from django.contrib.auth.forms import UserCreationForm```
2. Ajustamos a nossa class:

```
def register(request):
    form = UserCreationForm()
```

```
def register(request):
    form = UserCreationForm()
    return render(request, 'users/register.html', {'form': form})
```


### Template do user

Para criar um template temos que ter a pasta ```templates``` dentro do nosso ```app```... E dentro desse app nós temos que criar a pasta ```[nome_do_app]```...

Dessa forma, dentro de ```users > templates > users``` vamos criar ```register.html```


O que fica assim:

```
└───users
    ├───migrations
    └───templates
        └───users
              └───register.html
```

Vamos herdar as configurações do template que já exista

No Django nós podemos herdar de outro app sem problemas...

### HTML

```
{% extends "blog/base.html" %}

{% block content %}
<div class="content-section">
    <form method="POST">
        {% csrf_token %} # sem isso não vai funcionar... Questão de segurança
        <fieldset class="form-group">
            <legend class="border-botton mb-4">Crie sua conta</legend>
            {{ form }}
        </fieldset>
        <div class="form-group">
            <button class="btn btn-outline-info" type="submit">Criar conta</button>
        </div>

    </form>
    <div class="border-top pt-3">
        <small class="text-muted">Já possui uma conta?<a class="ml-2" href="">Faça seu Login</a></small>
    </div>
</div>
```

### urls

O nosso projeto está com a seguinte url.

blogproject > urls.py
```
urlpatterns = [
    path('admin/', admin.site.urls),
    path('', include('blog.urls')),
]
```

14m +_ 15 m

Ajustaremos para:

```
from django.contrib import admin
from django.urls import path, include
from users import views as users_views

urlpatterns = [
    path('admin/', admin.site.urls),
    path('', include('blog.urls')),
    path('register/', users_views.register, name='register'),
]
```

Vamos rodar o nosso servidor: ```python manage.py runserver```

Quando rodamos percebemos que o layout não fica muito bonito...

Nós faremos alguns ajustes...

### {{ form.ap_p }}

- Ao invés de ```{{ form }}``` vamos colocar ```{{ form.ap_p }}```
- isso faz que o conteúdo seja renderizado como parágrafos

Ainda está bem ruim... mas já houve uma melhora...




