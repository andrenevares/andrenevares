# Mensagens

## tipos de messages
- messages.debug
- messages.info
- messages.sucess
- messages.warning
- messages.error

[link django](https://docs.djangoproject.com/pt-br/3.0/_modules/django/contrib/messages/api/)

## views.py

Para usar é precido importar o módulo messages
```python
from django.contrib import messages
```

## Ajustar o template

```jinja2
{% if messages %}
  {% for message in messages %}
    <div class="alert alert-{{ message.tags }}"> 
      {{ message }}
    </div>
  {% endfor %}
{% else %}

{% endif %}
(...)
{% block content %} {% endblock content %}
```

> Como o Bootstrap e o Django tem nomenclatura igual, podemos usar as tags da mensagem para complementar o HTML.   Dessa forma se a tag da mensagem for ```sucess``` a class vai ficar ```alert-sucess```.  se a tag da mensagem for ```warning``` a class vai ficar ```alert-warning```... 
