# Crispy forms

Vai permitir que o utilizemos poucos códigos de modo a estilizar o nosso formulário alinhado com o bootstrap.

## instalar crispy forms

```python
pip intall django-crispy-forms
```

## colocar o crispy forms no settings

``` python
INSTALLED_APPS = [
  (...)
  'crispy_forms',
  (...)
]
```

## no settings colocar qual o framework que o crispy tem que estilizar
> Costumava ser o Bootstrap2 mas...

```python
CRISPY_TEMPLATE_PACK = 'bootstrap4'
```

## colocar no template dos forms que queremos usar 

Exemplo: _register.html_
```jinja2
{% extends "blog/base.html" %}
{% load crispy_forms_tags %}
{% block content %}
<div class="container">
  <form method="POST>
    (...)
  </form>
</div>
{% endblock %}
```
