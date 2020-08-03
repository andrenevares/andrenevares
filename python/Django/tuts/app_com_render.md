# App com render

## Com HttpResponse
```
from django.shortcuts import render
from django.http import HttpResponse

def home(request):
    return HttpResponse('<h1>Se aparece funcionou</h1>')
```

## Com render
1. Ajustar uma URL que apontará para uma view
2. 
 

### urls.py

#### do projeto
1. Colocar o include
2. apontar para o seu app
```
from django.contrib import admin
from django.urls import path, include

urlpatterns = [
    path('admin/', admin.site.urls),
    path('', include('nome_do_app.urls')),
]
```

#### do app
1. criar um arquivo urls.py
2. colocar a seguinte sintaxe:
```
from django.urls import path
from . import views

urlpatterns = [
    path('', views.home, name='home'),
]
```
### Views.py
```
from django.shortcuts import render

def home(request):
    return render(request, 'main/home.html')
```

### templates
```
nome_do_app
  |-templates
      |-nome_do_app
          |-home.html
```
