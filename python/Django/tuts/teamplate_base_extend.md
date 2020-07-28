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
{% block content %}
  Seu conteúdo deve entrar aqui
{% endblock content %}
```
