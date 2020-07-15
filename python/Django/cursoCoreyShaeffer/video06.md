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


Criar um Template que use esse form

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




