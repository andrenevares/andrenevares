# Alterar a ordem dos campos

## Padrão para inserir model no admin:
```
from django.contrib import admin
from .models import Tutorial

admin.site.register(Tutorial, TutorialAdmin)
```

## Ordem Inicial:
1. Title
2. content
3. Date Publishef

## Código para alterar a ordem
```python
from django.contrib import admin
from .models import Tutorial

class TutorialAdmin(admin.ModelAdmin):
    fields = ["tutorial_published",
              "tutorial_title",
              "tutorial_content"]

admin.site.register(Tutorial, TutorialAdmin)
```

## Vide imagem
![Alterar a ordem dos campos na imagem](https://github.com/andrenevares/andrenevares/blob/master/python/Django/tuts_images/admin_reodena%C3%A7%C3%A3o%20de%20campos.JPG)
