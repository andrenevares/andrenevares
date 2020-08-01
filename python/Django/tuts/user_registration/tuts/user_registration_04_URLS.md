# urls.py


## Colocando as urls dentro do ```urls.py``` do projeto

Se você quiser criar um ```urls.py``` dentro do app ```users``` você precisará fazer isso:

##### projeto > urls.py 
```python
from django.contrib import admin
from django.urls import path, include

(...)
urlspatterns = [
    path('', include('users.urls')),
]
```

##### users > urls.py 
```python
from django.contrib import admin
from django.urls import path
from django.contrib.auth import views
(...)
urlspatterns = [
    path('register/', views.register, name='register'),
    path('login/', views.LoginView, name='login'),  
    path('logout/', views.LogoutView, name='logout'),  
]
```


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
