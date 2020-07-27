# Apps include

Vamos colocar um exemplo.   Imaginemos que eu criei um app chamdo de blog.  

```python
python manage.py startapp blog
```

O que eu tenho que fazer?
1. Tenho que [incluir settings > INSTALLED_APPS](https://github.com/andrenevares/andrenevares/blob/master/python/Django/tuts/adicionar_app_a_INSTALLED_APPS.md)
2. Tenho que colocar as urls!


```python
urlpatterns = [
  (..)
  path('blog/', include('blog.urls')),
]
```

Criar dentro do seu app um novo arquivo chamado de ```urls.py```

```
blog
  |- urls.py
  |- (...)
```  
