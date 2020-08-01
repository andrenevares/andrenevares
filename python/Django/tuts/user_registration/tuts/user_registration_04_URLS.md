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
    path('login/', views.LoginView(template_name='users/login.html'), name='login'),  
    path('logout/', views.LogoutView(template_name='users/logout.html'), name='logout'),  
]
```

```LoginView``` e ```LogoutView``` são class base views!!!
