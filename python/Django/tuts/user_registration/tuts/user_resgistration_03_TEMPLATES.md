## criar os templates para users
Estrutura:
```
users
 |-templates
      |-users
          |-register.html
          |-login.html
```

## app > templates register form 

```jinja2
{% extends "blog/base.html" %}
{% load crispy_forms_tags %}

{% block content %}
<div class="content-section">
    <form method="POST">
        {% csrf_token %}
        <fieldset class="form-group">
            <legend class="border-bottom mb-4">Crie uma conta...</legend>
                {{ form|crispy }}
        </fieldset>
        <div class="form-group">
            <button class="btn btn-primary" type="submit">Enviar</button>
        </div>
    </form>
    <div class="border-top pt-3">
        <small class="text-muted">
            Se você já tem uma conta, <a class="ml-2" href="{% url 'login' %}">faça seu login!</a>
        </small>
    </div>
</div>
{% endblock content %}
```

Ver csrf token >>> 

Ver crispy forms >>> 
