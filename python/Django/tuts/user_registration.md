# Criando um user registration 
 
 Tutorial para criar um user registration sem que o usuário acesse o backend.
 
 ## ```urls.py``` do projeto
 
 ``` python
 from django.contrib import auth
 ```
 
 ``` python
  	(...)
    path('signup', views.SignUp.as_view(), name='signup'),
    path('login', auth.views.LoginView.as_view(), name='login'),
    path('logout', auth.views.LogoutView.as_view(), name='logout'),
 ```
 
 
 ## ```view.py`` 

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

 
 
