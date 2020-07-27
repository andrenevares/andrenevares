# Apps include

Vamos colocar um exemplo.   Imaginemos que eu criei um app chamdo de blog.  

```python
python manage.py startapp blog
```

O que eu tenho que fazer?
1. Tenho que [incluir settings > INSTALLED_APPS](https://github.com/andrenevares/andrenevares/blob/master/python/Django/tuts/adicionar_app_a_INSTALLED_APPS.md)
2. Tenho que colocar as urls!

## ```urls.py``` do projeto

__Passo 1__. Adcionar ```include``` aos imports 

```python
(..)
from django.urls import path, include
```

__Passo 2__. Adcionar ```static``` aos imports 

```python
(..)
from django.conf.urls.static import static
```

__Passo 3__. Adcionar ```path```  

```python
urlpatterns = [
  (..)
  path('blog/', include('blog.urls')),
]
```

## ```urls.py``` do app

__Passo 1__ Criar dentro do seu app um novo arquivo chamado de ```urls.py```

```
blog
  |- urls.py
  |- (...)
```  
