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






### settings.py


