# Crispy forms

Vai permitir que o utilizemos poucos códigos de modo a estilizar o nosso formulário alinhado com o bootstrap.

## Passo a passo
1. Instalar o crispy
2. Colocar o crispy no ```INSTALLED_APPS``` no settings.py
3. Configurar ```CRISPY_TEMPLATE_PACK``` no settings.py
4. No template do form, usar ```{% load crispy_forms_tags %}```
5. Utilizar o crispy como filtro: ```{{ form|crispy }}```

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
    {% csrf_token %}
    {{ form|crispy }}
  </form>
</div>
{% endblock %}
```
