# Django CK-EDITOR

## Passo 01 - Como instalar
```
pip install django-ckeditor
```

## Depois...Configurações necessárias

### models.py 
```
from ckeditor.fields import RichTextField
```

dentro da class do nosso model onde tenha o textfield

```
body = RichTextField(blank=True, null=true)
```

### migrations
```
python manage.py makemigrations
```

```
python manage.py migrate
```

### setttings.py

```
INSTALLED_APPS = [
  ...,
 'ckeditor',
]
```

__Somente com isso, se entrarmos no admin, o TEXTFIELD já deve ter a interface de um editor de texto__

### templates

Provavelmente estamos usando 
```
{% csrf_token %}
{{ form.as_p }}
```

Devemos mudar para:
```
{% csrf_token %}
{{ form.media }}
{{ form.as_p }}

```


### Usar SAFE
Um editor de texto simplesmente coloca as tags HTML.

Por padrão, o Django utiliza o método __unsafe__.  Isso porque um usuário poderia escrever um script malicioso.  Mas se você tem segurança de que aquele conteúdo pode ser renderizado e não vai ter nenhum problema ```{{ form|safe }}```

Com isso será exibido o seu conteúdo!

É isso aí...
