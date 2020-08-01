# Ajustes a fazer de modo a exibir o login e logout.

#### navbar
```jinja2
<!-- Navigation-->
<nav class="navbar navbar-expand-lg navbar-light fixed-top" id="mainNav">
    <div class="container">
        <a class="navbar-brand js-scroll-trigger" href="#page-top">Nome_do_Projeto</a>
        <button class="navbar-toggler navbar-toggler-right" type="button" data-toggle="collapse"
            data-target="#navbarResponsive" aria-controls="navbarResponsive" aria-expanded="false"
            aria-label="Toggle navigation">
            Menu
            <i class="fas fa-bars"></i>
        </button>
        <div class="collapse navbar-collapse" id="navbarResponsive">
            <ul class="navbar-nav ml-auto">
                {% if user.is_authenticated %}
                  <li class="nav-item"><a class="nav-link js-scroll-trigger" href="{% url 'logout' %}">Logout</a></li>
                  <li class="nav-item"><a class="nav-link js-scroll-trigger" href="{% url 'profile' %}">Perfil</a></li>
                {% else %}
                  <li class="nav-item"><a class="nav-link js-scroll-trigger" href="{% url 'login' %}">Login</a></li>
                  <li class="nav-item"><a class="nav-link js-scroll-trigger" href="{% url 'register' %}">Cadastre-se</a></li>
                {% endif %}
            </ul>
        </div>
    </div>
</nav>
```
