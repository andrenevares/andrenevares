# Adcionando um editor de texto no Admin

## Instalar 
```pip install django-tinymce4-lite```

## settings.py 
```python
INSTALLED_APPS = [
    (..)
    'tinymce',
]
```


```
TINYMCE_DEFAULT_CONFIG = {
    'height': 360,
    'width': 1120,
    'cleanup_on_startup': True,
    'custom_undo_redo_levels': 20,
    'selector': 'textarea',
    'theme': 'modern',
    'plugins': '''
            textcolor save link image media preview codesample contextmenu
            table code lists fullscreen  insertdatetime  nonbreaking
            contextmenu directionality searchreplace wordcount visualblocks
            visualchars code fullscreen autolink lists  charmap print  hr
            anchor pagebreak
            ''',
    'toolbar1': '''
            fullscreen preview bold italic underline | fontselect,
            fontsizeselect  | forecolor backcolor | alignleft alignright |
            aligncenter alignjustify | indent outdent | bullist numlist table |
            | link image media | codesample |
            ''',
    'toolbar2': '''
            visualblocks visualchars |
            charmap hr pagebreak nonbreaking anchor |  code |
            ''',
    'contextmenu': 'formats | link image',
    'menubar': True,
    'statusbar': True,
    }
```

## project > ```urls.py```
```
urlpatterns = patterns('',
    ...
    path('tinymce/', include('tinymce.urls')),
    ...
)
```
## app > ```admin.py```

imports
```python
from tinymce.widgets import TinyMCE
from django.db import models
```

```python
    formfield_overrides = {
        models.TextField: {'widget': TinyMCE()},
        }
```


```python
from django.contrib import admin
from .models import Tutorial
from tinymce.widgets import TinyMCE
from django.db import models

class TutorialAdmin(admin.ModelAdmin):
    fieldsets = [
        ("Bloco 01", {"fields": ["tutorial_title", "tutorial_published"]}),
        ("Bloco 02", {"fields": ["tutorial_content"]})
    ]

    formfield_overrides = {
        models.TextField: {'widget': TinyMCE()},
        }
    
admin.site.register(Tutorial, TutorialAdmin)
```
