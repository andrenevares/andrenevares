# Parte 06 
> Notes from Mscorey, made by André Nevares 
## User Registration

### Youtube - Video - Link
[Python Django Tutorial: Full-Featured Web App Part 6 - User Registration](https://www.youtube.com/watch?v=q4jPR-M0TAQ&list=PL-osiE80TeTtoQCKZ03TU5fNfx2UY6U4p&index=6)

### O que veremos
- Como usar formulários
- Como Validar Entradas de usuários
- A parte de registro de usuários deve ficar em uma outra aplicação.


### Criar um app específico para user registration

1. Vamos até o diretório do projeto... É onde fica o ```manage.py```
2. Criamos o app ```user``` por meio do comando ```python manage.py startapp user```
3. Toda vez que criamos um app precisamos adicionar o app dentro da lista de ```INSTALLED_APPS = []``` que fica dentro do ```projeto > settings.py```
4. Vamos primeiro abrir o ```apps.py``` que fica dentro do nosso novo app, no caso ```users > apps.py```
5. Haverá uma __class__ criada automaticamente quando criamos o app com o ```startapp```.
6. Perceba que esta class fica dentro do diretório ```blog```, dentro do arquivo ```apps.py``` e com o nome de ```UsersConfig```... 

O que fica assim:

```
└───blog
    ├───apps.py
           └───(...)
```

... sendo assim a sintaxe usada para inserir nosso app na lista de apps instalados será ```'users.apps.UsersConfig',```.   Ou seja, dentro ```INSTALLED_APPS```  colocaremos essa sintaxe!

### Ajustando a ```users > views.py```

O arquivo views.py vai cuidar da lógica desse app

### Criamos a register view

```
from django.shortcuts import render

def register(request):
```

### Criar os forms: ```UserCreationForm```

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


### Template do users

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
        {% csrf_token %}
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
> ```{% csrf_token %}``` é uma questão de segurança de modo a proteger a aplicação de determinados ataques.  É uma exigência do Django, sem isso não vai funcionar!!!

### ```urls.py```

O nosso projeto está com a seguinte url.

#### ```blogproject > urls.py```


Poderíamos incluir as __urls__ de duas maneiras.

A primeira seria fazendo da mesma forma que no __blog__, ou seja, fazer um ```user > urls.py``` e inserir ```path('', include('blog.urls')```.

Mas de forma contrária vamos fazer isso __direto__ dentro do __urls.py do projeto__

Nosso __```blogproject > urls.py```__ estava assim:

```
urlpatterns = [
    path('admin/', admin.site.urls),
    path('', include('blog.urls')),
]
```
__Agora__ ele ficará assim:

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

### Reiniciar novamente o servidor...

Vamos rodar o nosso servidor: ```python manage.py runserver```

Quando rodamos percebemos que o layout não fica muito bonito...

Nós faremos alguns ajustes...

### {{ form.as_p }}

- Ao invés de ```{{ form }}``` vamos colocar ```{{ form.as_p }}```
- isso faz que o conteúdo seja renderizado como parágrafos

Ainda está bem ruim... mas já houve uma melhora...

### Modificando a class ```register```

Quando submetermos nosso formulário, não acontece nada...

Estamos fazendo nosso POST e entrando no nosso form mas ele está vazio!

Como não especificamos o que fazer com os dados no POST o que está ocorrendo é que os dados inseridos pelo usuário estão sendo enviados via POST para mesma route

```
def register(request):
    form = UserCreationForm()
```

#### Primeira Condição: ```if request.method == 'POST':```

```
def register(request):
    if request.method == 'POST':
        form = UserCreationForm(request.POST)
    else:    
        form = UserCreationForm()
    return render(request, 'users/register.html', {'form': form})
```

- Se a requisição for ```POST``` então os dados serão passados
- Se não apenas instancia um novo form vazio 

#### Segunda condição: ```if form.is_valid():```

```
def register(request):
    if request.method == 'POST':
        form = UserCreationForm(request.POST)
        if form.is_valid():
            username = form.cleaned_data.get('username')
    else:    
        form = UserCreationForm()
    return render(request, 'users/register.html', {'form': form})
```

### Flash Messages - Alertas para o usuário

#### Tipos de message:
- messages.debug
- messages.info
- messages.sucess
- messages.warning
- messages.error

#### Nosso código...

Para usar flash messages precisamos importar o módulo ```messages```
```from django.contrib import messages``` 

Assim nosso ```views.py``` está assim:
```
from django.shortcuts import render
from django.contrib.auth.forms import UserCreationForm
from django.contrib import messages

def register(request):
    if request.method == 'POST':
        form = UserCreationForm(request.POST)
        if form.is_valid():
            username = form.cleaned_data.get('username')
    else:    
        form = UserCreationForm()
    return render(request, 'users/register.html', {'form': form})
```


#### Syntaxe usada
```messages.sucess(request, f'Conta criada para {username}')```

#### Código até agora
```
from django.shortcuts import render
from django.contrib.auth.forms import UserCreationForm
from django.contrib import messages

def register(request):
    if request.method == 'POST':
        form = UserCreationForm(request.POST)
        if form.is_valid():
            username = form.cleaned_data.get('username')
            messages.sucess(request, f'Conta criada para {username}')
    else:    
        form = UserCreationForm()
    return render(request, 'users/register.html', {'form': form})
```

#### Redirecionar

Agora que já conseguimos:
- Validar
- Converter os dados para um dicionário python
- Criar mensagens de validação

Nós precisamos fazer com que o usuário seja redirecionado para uma outra página.  Imagine que o usuário conseguiu se logar na aplicação, mas ele continua na tela de login... Isso não faz muito sentido.

No nosso exemplo vamos redirecionar para a home.

Para isso precisamos usar o ```redirect``` 

Faremos isso importando ```from django.shortcuts import redirect```

Como já temos um import do ```django.shortcuts``` podemos colocar:

```from django.shortcuts import render, redirect```

### Atualizar o Template para mostrar as mensagens de validação!

Nós colocamos na função ```register``` para criar um mensagem, certo?  Mas isso ainda não vai funcionar!   Nós ainda não ajustamos nossos templates para isso.

A opção mais interessante nesse momento seria colocar no __template base__... Assim, a mensagem seria exibida em todas as páginas.

```blog > templates > blog > base.html```

Vamos colocar uma condicional logo acima do bloco ```{% content %}```
- Se houver mensagem --> então exiba mensagem
- Colocamos um for dentro para podermos usar diferentes mensagens!

```
{% if messages %}
    {% for message in messages %}
    <div class="alert alert-{{ message.tags}}">
        {{ message }}
    </div>
    {% endfor %}
{% endif %}

{% block content %}{% endblock %}
```

Vamos testar para ver se funciona!

Algumas observações...

- O form ainda não está salvando no banco
- O form se obtém sucesso está entrando no ```if form.is_valid():``` 
- Dessa forma está ocorrendo o alerta visual via flash message
- No entanto, quando não é válido... O Django, de forma nativa, mostra o erro dentro do form... Mas não está muito visivel
- Além disso precisamos fazer alguns ajustes de Layout

### ```form.save()``` salvar os dados no banco de dados
Muito simples... ```form.save()```

Nosso código até aqui é:
```
from django.shortcuts import render, redirect
from django.contrib.auth.forms import UserCreationForm
from django.contrib import messages

def register(request):
    if request.method == 'POST':
        form = UserCreationForm(request.POST)
        if form.is_valid():
            form.save()
            username = form.cleaned_data.get('username')
            messages.success(request, f'Conta criada para {username}')
            return redirect('blog-home')
    else:    
        form = UserCreationForm()
    return render(request, 'users/register.html', {'form': form})
```

#### Testando: 
Vamos criar um usuário e depois logar no admin para ver se está rolando?
1. Criar usuário
2. Ser redirecionado para HOME e ser exibida a mensagem de Sucesso
3. Logar no Admin ```http://127.0.0.1:8000/login``` e 
4. Verificar se o usuário foi criado no BD

#### Resultado 
- Sucesso
- Só que não há o campo e-mail colocado...
- Afinal isso não foi solicitado

Então precisamos colocar um campo customizado!!!!

### Adicionando mais campos para Registration Form

#### criar ```forms.py```

Vamos criar um arquivo ```users > forms.py```.

```
from django import forms
from django.contrib.auth.models import User
from django.contrib.auth.forms import UserCreationForm

class UserRegisterForm(UserCreationForm):
    email = forms.EmailField()

    class Meta:
        model = User
        fields = ['username', 'email', 'password1', 'password2']
```
