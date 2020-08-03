# App com render

## Passos
1. Criar um arquivo ```urls.py``` dentro do app
2. Apontar o projeto > ```urls.py``` para o app > ```urls.py``` usando ```path('', include('nome_do_app.urls'))
3. Apontar o app > ```urls.py``` para o uma view.


### projeto > ```urls.py```
1. fazer import da função ```include```
2. seguir o modelo
```
from django.contrib import admin
from django.urls import path, include

urlpatterns = [
    path('admin/', admin.site.urls),
    path('', include('nome_do_app.urls')),
]
```

#### app > ```urls.py```
1. criar um arquivo ```urls.py```
2. importar as views desse app
3. usar o seguinte modelo

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
