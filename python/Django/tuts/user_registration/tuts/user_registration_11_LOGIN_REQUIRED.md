# Login Required

É uma maneira de fazer com que alguma rota fique restrita somente para usuários autenticados.

## users > ```views.py```

```python

(...)
def profile(request):
    return render(request, 'users/profile.html'  
```

## criar um template para o profile
```
users
 |-templates
      |-users
          |-register.html
          |-login.html
          |-logout.html
          |-profile.html
```
## profile.html template

```jinja2
{% entends 'blog/base.html' %}
{% load crispy_forms_tags %}

{% block content %}
    <h1>{{ user.username }}</h1>
{% endblock %}
```

## urls.py

```python
urlpatterns = [
    (...)
    path('profile/', views.profile, name='profile'),
]
```
