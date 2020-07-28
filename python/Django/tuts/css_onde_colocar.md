# Onde colocar o CSS

```
nome_do_app
    |- static
        |- nome_do_app
            |- main.css
```

sendo que no arquivo base usaremos:

No início do arquivo:
```html
{% load static %}
<head>
    <link rel="stylesheet" type="text/css" href="{% static 'blog/main.css' %}">
</head>
```

##### No base:

```html
{% load static %}
<head>
    <link rel="stylesheet" type="text/css" href="{% static 'blog/main.css' %}">
</head>
```
