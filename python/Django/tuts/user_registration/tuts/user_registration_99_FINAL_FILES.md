# Arquivos finais

## views.py
```
from django.shortcuts import render, redirect
from django.contrib import messages
from .forms import UserRegisterForm
from django.contrib.auth.decorators import login_required


def register(request):
    if request.method == 'POST':
        form = UserRegisterForm(request.POST)
        if form.is_valid():
            form.save()
            username = form.cleaned_data.get('username')
            messages.success(request, f'Sua conta foi criada com sucesso você já pode se logar')
            return redirect('login')
    else:    
        form = UserRegisterForm()
    return render(request, 'users/register.html', {'form': form})

@login_required
def profile(request):
  return render(request, 'users/profile.html')
```

## Templates

### register.html
```
{% extends "blog/base.html" %}
{% load crispy_forms_tags %}

{% block content %}
<div class="content-section">
    <form method="POST">
        {% csrf_token %}
        <fieldset class="form-group">
            <legend class="border-bottom mb-4">Join Today</legend>
            {{ form|crispy }}
        </fieldset>
        <div class="form-group">
            <button class="btn btn-outline-info" type="submit">Sign Up</button>
        </div>
    </form>
    <div class="border-top pt-3">
        <small class="text-muted">
            Já possui uma conta? <a class="ml-2" href="{% url 'login' %}">Faça seu Login</a>
        </small>
    </div>
</div>
{% endblock content %}
```
### login.html
```
{% extends "blog/base.html" %}
{% load crispy_forms_tags %}

{% block content %}
<div class="content-section">
    <form method="POST">
        {% csrf_token %}
        <fieldset class="form-group">
            <legend class="border-bottom mb-4">Log in</legend>
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

### logout.html
```
{% extends "blog/base.html" %}
{% block content %}
<h2>Logout bem sucedido</h2>
<div class="border-top pt-3">
    <small class="text-muted">
        <a href="{% url 'login' %}">Faça seu login novamente</a>
    </small>
</div>
{% endblock  %}
```


### profile.html
```
{% extends "blog/base.html" %}
{% load crispy_forms_tags %}

{% block content %}
<h1>{{ user.username }}</h1>
{% endblock content %}
```

### urls.py
```
from django.contrib import admin
from django.contrib.auth import views as auth_views
from django.urls import path, include
from users import views as users_views

urlpatterns = [
    path('admin/', admin.site.urls),
    path('', include('blog.urls')),
    path('register/', users_views.register, name='register'),
    path('login/', auth_views.LoginView.as_view(template_name='users/login.html'), name='login'),
    path('logout/', auth_views.LogoutView.as_view(template_name='users/logout.html'), name='logout'),
    path('profile/', users_views.profile, name='profile'),
]
```
