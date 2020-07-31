# Criar template ```login```
Vamos copiar o código html do ```register.html``` para servir de base para o nosso template.

Fazer alguns ajustes

```html
{% extends "blog/base.html" %}
{% load crispy_forms_tags %}

{% block content %}
<div class="content-section">
    <form method="POST">
        {% csrf_token %}
        <fieldset class="form-group">
            <legend class="border-bottom mb-4">Log in/legend>
                {{ form|crispy }}
        </fieldset>
        <div class="form-group">
            <button class="btn btn-outline-info" type="submit">Log in</button>
        </div>
    </form>
    <div class="border-top pt-3">
        <small class="text-muted">
            Ainda não possui uma conta? <a class="ml-2" href="{% url 'register' %}">Cadastre-se agora!</a>
        </small>
    </div>
</div>
{% endblock content %}
```
