# Criando um user registration 
 
 Tutorial para criar um user registration sem que o usuário acesse o backend.
 
 ## ```urls.py``` do projeto
 
 ``` python
 from django.contrib import auth
 from django.contrib.auth import views as auth_views
 ```
 
 ``` python
  	(...)
    path('signup', views.SignUp.as_view(), name='signup'),
    path('login', auth_views.LoginView.as_view(), name='login'),
    path('logout', auth_views.LogoutView.as_view(), name='logout'),
 ```
 
 
 ## ```view.py``` 

```python
(..)
from django.urls import reverse_lazy
from django.views imoport generic
from django.contrib.auth.forms import UserCreationForm

(..)

class SignUp(generic.CreateView):
  form_class = UserCreationForm
  sucess_url = reverse_lazy('home')
  template_name = 'regustration/signup.html'
```

## Ajustar estrutura de pastas do template
```
meu_projeto
 |- nome_do_app
      |-templates
          |- nome_do_app
          |    |-base.html
          |    |-home.html
          |    |-(..)
          |- registration 
               |-signup.html
               |-login.html
```

## signup.html

```html
<div class="container">
    <h2>Sign Up</h2>
    <form method="post">
    {% csrf_token %}
    {{ form }}
    <button type="submit" class="btn btn-primary">Sign Up<button> 
    </form>
</div>
```
> para melhorar um pouco o estilo podemos usar o {{ form.as_p }}  
 
## login.html
```html
<div class="container">
    <h2>Login</h2>
    <form method="post">
    {% csrf_token %}
    {{ form }}
    <button type="submit" class="btn btn-primary">Login<button> 
    </form>
</div>
```

## settings.py

```
LOGIN_URL = 'login'
LOGIN_REDIRECT = 'home'
LOGOUT_REDIRECT = 'home'
```
