# Templates Base e Extend sintaxe

## Base
```html
{% load static %}
  <link rel="stylesheet" type="text/css" href="{% static 'personal/main.css' %}">
{% block content %}

{% endblock content %}
```

## Extends...
```html
{% extends "nome_do_app/base.html" %}
{% block content %}
  Seu conteúdo deve entrar aqui
{% endblock content %}
```
> sendo ```nome_do_app``` o diretório onde se encontra o template de onde você quer herdar.
