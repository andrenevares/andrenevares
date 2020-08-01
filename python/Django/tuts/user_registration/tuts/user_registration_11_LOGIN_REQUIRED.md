# Login Required

É uma maneira de fazer com que alguma rota fique restrita somente para usuários autenticados.

## users > ```views.py```

```python
(...)
from django.contrib.auth.decorators import login_required
(...)
@login_required
def profile(request):
    return render(request, 'users/profile.html')  
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

## Ajustar no settings ```LOGIN_URL```

Quando usamos o login required e não temos acesso, o django vai procurar onde fica o login.

Pode acontecer de aparecer uma tela de erro.

Para evitar esse erro, basta configurar no ```settings.py```:

```python
LOGIN_URL = 'login' # login é o nome que demos para o path da url do login!
```
