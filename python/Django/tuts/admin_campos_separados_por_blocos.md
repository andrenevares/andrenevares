# Separar os campos em blocos

## Padrão para inserir model no admin:
```
from django.contrib import admin
from .models import Tutorial

admin.site.register(Tutorial, TutorialAdmin)
```
## Código para separar em bloco e trocar a ordem se quiser
```python
from django.contrib import admin
from .models import Tutorial

class TutorialAdmin(admin.ModelAdmin):
    fieldsets = [
        ("Bloco 01", {"fields": ["tutorial_title", "tutorial_published"]}),
        ("Bloco 02", {"fields": ["tutorial_content"]})
    ]

admin.site.register(Tutorial, TutorialAdmin)
```

## Vide imagem
![Separar os campos em blocos](https://github.com/andrenevares/andrenevares/blob/master/python/Django/tuts_images/admin_separados_por_blocos.JPG)
