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

```python
{% if messages %}

{% else %}

{% endif %}
```
