# criar os templates para users
## Estrutura:
```
users
 |-templates
      |-users
          |-register.html
          |-login.html
          |-logout.html
```

## app > ```templates``` 

### ```register.html```

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


### ```login.html```

```jinja2
{% extends "blog/base.html" %}
{% load crispy_forms_tags %}

{% block content %}
    <div class="content-section">
        <form method="POST">
            {% csrf_token %}
            <fieldset class="form-group">
                <legend class="border-bottom mb-4">Login</legend>
                    {{ form|crispy }}
            </fieldset>
            <div class="form-group">
                <button class="btn btn-primary" type="submit">Login</button>
            </div>
        </form>
        <div class="border-top pt-3">
            <small class="text-muted">
                Se você ainda não tem uma conta, <a class="ml-2" href="{% url 'register' %}">crie uma conta agora!</a>
            </small>
        </div>
    </div>
{% endblock content %}
```

### ```logout.html```

```jinja2
{% extends "blog/base.html" %}


{% block content %}
   <h2>Logout realizado com sucesso.  Esperamos ver você em breve</h2> 
   <div class="border-top pt-3">
       <small class="text-muted">
           <a class="ml-2" href="{% url 'register' %}">Faça o seu login novamente!</a>
       </small>
   </div>
{% endblock content %}
```
