# Criando app ```user```

## Views nativas de ```login``` e ```logout```
Um sistema de autenticação basicamente possui:

1. Registre-se
2. Login __```*```__
3. Logout __```*```__
4. Verifica se está logado __```*```__

__```*```__  São modelos nativos do django.

## Criar um app ```user```
De modo a tornar a aplicação mais escalável, faz mais sentido que criemos um app ```user``` dentro de cada projeto Django.  Assim, toda a parte de login, logout suas lógicas ficam dentro de um mesmo diretório!

```linux
python manage.py startapp users
```

Toda vez que criar um app __adcionar em settings.py__ a url.

```python
INSTALLED_APPS = [
    (...)
    'nome_do_app.apps.AlgumaCoisaConfig',
]
```
## users > ```views.py```

```python
(...)
from django.contrib.auth.formsimport UserCreationForm

def register(request):
    form = UserCreationForm()
    return render(request, 'users/register.html', {'form': form} )
```

## criar os templates para users
Estrutura:
```
users
 |-templates
      |-users
          |-register.html
          |-login.html
```


## No projeto

## projeto > ```urls.py``` importar módulos nativos

projeto > ```urls.py```

Importaremos as views ```login``` e ```logout``` nativas do django.

Sintaxe:
```python
from django.contrib.auth import views as auth_views
```


##### Começando a sintaxe ```login``` e ```logout```: 
```python
path('login/', auth_views.LoginView.as_view(), name='login'),
path('logout/', auth_views.LogoutView.as_view(), name='logout'),
```

Ao invés de criarmos um app para ```login```e outro app para ```logout``` podemos usar o app ```users``` o que faz mais sentido.

Para isso precisamos dizer ao Django isso...  Nós vamos dizer ao django onde olhar pelos templates

Então dentro da função ```as_view()``` vamos colocar 
```python
.as_view(template_name='users/login.html')
```

#### Sintaxes finais ```login``` e ```logout```: 

```python
path('login/', auth_views.LoginView.as_view(template_name='users/login.html'), name='login'),
path('logout/', auth_views.LogoutView.as_view(template_name='users/logout.html'), name='logout'),
```

### Criar template ```login```
Vamos copiar o código html do ```register.html``` para servir de base para o nosso template.

Fazer alguns ajustes

```html
{% extends "blog/base.html" %}
{% load crispy_forms_tags %}

{% block content %}
<div class="content-section">
    <form method="POST">
        {% csrf_token %}
        <fieldset class="form-group">
            <legend class="border-bottom mb-4">Log in/legend>
                {{ form|crispy }}
        </fieldset>
        <div class="form-group">
            <button class="btn btn-outline-info" type="submit">Log in</button>
        </div>
    </form>
    <div class="border-top pt-3">
        <small class="text-muted">
            Ainda não possui uma conta? <a class="ml-2" href="{% url 'register' %}">Cadastre-se agora!</a>
        </small>
    </div>
</div>
{% endblock content %}
```

### Ajustar o ```{% url '...' %}```
- As páginas precisam ser ajustadas para serem redirecionadas de forma dinâmica
- A página __register.html__ deve ter um link para ```{% url 'login' %}```
- A página __login.html__ deve ter um link para```{% url 'register' %}```

### Template ```login```

Se digitarmos um usuário que não esteja correto, nós vamos receber a mensagem de erro.

Mas ao mesmo tempo, se digitarmos um usuário correto, vamos ter outro tipo de erro

### Mudar redirect do login no ```settings.py```
O Django de forma nativa irá redirecionar o usuário para a página do seu perfil.  Acontece que ainda não criamos essa parte da aplicação ainda... E mesmo que tivéssemos criado, não parece uma boa idéia redirecionar para a página de profile tão logo o usuário tenha se logado. Nós podemos mudar o redirecionamento nativo do django relativo ao login no nosso ```settings.py``` para isso

1. Abrir o ```settings.py```
2. ```LOGIN_REDIRECT_URL = 'blog-home'```

Ainda não temos a mensagem de sucesso... Mas vamos ajustar isso

### Register --> Login
Quando um usuário tiver sucesso ao se logar ele deve ser redirecionado para a página de login... Faz muito mais sentido que ele faça o LOGIN logo tão logo ele crie uma conta

Dessa forma vamsos ajustar o nosso ```users > views.py```


```python
  messages.success(request, f'Sua conta foi criada com sucesso você já pode se logar')
  return redirect('login')
```

### Logout nativo
Dentro do nosso urls.py temos para o logout

```python
path ('logout/', auth_views.LogoutView.as_view(template_name=('users/logout.html', name='logout'), name='logout'),
```

E se tirássemos ```template_name=('users/logout.html', name='logout')```

ficando assim:  

```python
path ('logout/', auth_views.LogoutView.as_view(template_name=(), name='logout'),
```

Vamos examinar o comportamento padrão do django...

ao irmos para a url ```localhost:8000/logout/``` realmente conseguimos fazer logout... No entanto estamos com a interface visual do Django... 

Temos inclusive um link para que façamos o nosso login... Ao clicarmos ali nós somos direcionados para a página de login nativo do Django!

Para que isso não aconteça nós precisamos :
1. criar um template logout 
2. fazer com que a view do logout utilize esse template

Vamos voltar com 
```python
path ('logout/', auth_views.LogoutView.as_view(template_name=('users/logout.html', name='logout'), name='logout'),
```

#### Template Logout

```html
{% extends "blog/base.html" %}
{% block content %}
<h2>Logout bem sucedido</h2>
<div class="border-top pt-3">
    <small class="text-muted">
        <a href="{% url 'login' %}">Faça seu login novamente</a>
    </small>
</div>
{% endblock  %}
```

Vamos tentar fazer o login e logout.

### user.is_authenticated

Só queremos que a navbar mostre o __login__ e __cadastra-se__ se o usuário não estiver logado.  Caso ele não esteja logado faz mais sentido que apareça algo como __Meu Perfil__

Para isso o Django possui uma ```user variable``` que contém o ```current user``` sendo que esta variável possui um atributo ```is_authenticated``` o qual permite que o Django saiba se um usuário está logado ou não!
```
{% if user.is_authenticated %}

{% else  %}

{% endif  %}
```

### Profile

```views.py``` temos a nossa view register.

vamos criar uma chamada ```profile```

```
def profile(request):
  return render(request, 'users/profile.html')
```

#### Template profile


#### urls.py
   
```python
path('profile/', users_views.profile, name='profile'),
```
 
#### ajustar a navbar do ```base.html```
```html
<a class="nav-item nav-link" href={% url 'profile' %}>profile</a>
<a class="nav-item nav-link" href={% url 'logout' %}>Logout</a>
```

#### @login_required 
Entrar no ```views.py``` do app ```users```
```python
from django.contrib.auth.decorators import login_required
(...)
```

Colocando o decorator...
```python
@login_required
def profile(request):
  return render(request, 'users/profile.html')
```

Irá retornar erro pois estará procurando por ```localhost:8000/accounts/login/?next=/profile/``` 

Esse é o padrão onde o django irá verificar as routes...

Mas acontece que nós decidimos colocar a nossa route em outro lugar

Precisaremos ajustar o ```settings.py``` para verificar onde o django irá procurar

```
LOGIN_URL = 'login'
```

Perceba que o Django está guarndando o local que precisa ser acessado com o LOGIN.  Quando um sistema diz que você precisa se logar para acessar àquela página... Ele vai te mandar para uma página de Login... O que você espera?  Acredito que você deseje que a página depois do login seja aquela que você estava tentando acessar antes!!! 

```localhost:8000/accounts/login/?next=/profile/``` 

Agora nós vemos o profile


Nossos arquivos:

### views.py
```
from django.shortcuts import render, redirect
from django.contrib import messages
from .forms import UserRegisterForm
from django.contrib.auth.decorators import login_required


def register(request):
    if request.method == 'POST':
        form = UserRegisterForm(request.POST)
        if form.is_valid():
            form.save()
            username = form.cleaned_data.get('username')
            messages.success(request, f'Sua conta foi criada com sucesso você já pode se logar')
            return redirect('login')
    else:    
        form = UserRegisterForm()
    return render(request, 'users/register.html', {'form': form})

@login_required
def profile(request):
  return render(request, 'users/profile.html')
```
### register.html
```
{% extends "blog/base.html" %}
{% load crispy_forms_tags %}

{% block content %}
<div class="content-section">
    <form method="POST">
        {% csrf_token %}
        <fieldset class="form-group">
            <legend class="border-bottom mb-4">Join Today</legend>
            {{ form|crispy }}
        </fieldset>
        <div class="form-group">
            <button class="btn btn-outline-info" type="submit">Sign Up</button>
        </div>
    </form>
    <div class="border-top pt-3">
        <small class="text-muted">
            Já possui uma conta? <a class="ml-2" href="{% url 'login' %}">Faça seu Login</a>
        </small>
    </div>
</div>
{% endblock content %}
```
### login.html
```
{% extends "blog/base.html" %}
{% load crispy_forms_tags %}

{% block content %}
<div class="content-section">
    <form method="POST">
        {% csrf_token %}
        <fieldset class="form-group">
            <legend class="border-bottom mb-4">Log in</legend>
            {{ form|crispy }}
        </fieldset>
        <div class="form-group">
            <button class="btn btn-outline-info" type="submit">Log in</button>
        </div>
    </form>
    <div class="border-top pt-3">
        <small class="text-muted">
            Ainda não possui uma conta? <a class="ml-2" href="{% url 'register' %}">Cadastre-se agora!</a>
        </small>
    </div>
</div>
{% endblock content %}
```


### logout.html
```
{% extends "blog/base.html" %}
{% block content %}
<h2>Logout bem sucedido</h2>
<div class="border-top pt-3">
    <small class="text-muted">
        <a href="{% url 'login' %}">Faça seu login novamente</a>
    </small>
</div>
{% endblock  %}
```


### profile.html
```
{% extends "blog/base.html" %}
{% load crispy_forms_tags %}

{% block content %}
<h1>{{ user.username }}</h1>
{% endblock content %}
```

### urls.py
```
from django.contrib import admin
from django.contrib.auth import views as auth_views
from django.urls import path, include
from users import views as users_views

urlpatterns = [
    path('admin/', admin.site.urls),
    path('', include('blog.urls')),
    path('register/', users_views.register, name='register'),
    path('login/', auth_views.LoginView.as_view(template_name='users/login.html'), name='login'),
    path('logout/', auth_views.LogoutView.as_view(template_name='users/logout.html'), name='logout'),
    path('profile/', users_views.profile, name='profile'),
]
```

### settings.py alterações

```
LOGIN_REDIRECT_URL = 'blog-home'

LOGIN_URL = 'login'
```
