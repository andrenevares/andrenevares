# Alterar a ordem dos campos

## Padrão para inserir model no admin:
```
from django.contrib import admin
from .models import Tutorial

admin.site.register(Tutorial, TutorialAdmin)
```

```python
from django.contrib import admin
from .models import Tutorial

class TutorialAdmin(admin.ModelAdmin):
    fields = ["tutorial_published",
              "tutorial_title",
              "tutorial_content"]

admin.site.register(Tutorial, TutorialAdmin)
```

```![Alt Text](Url da Imagem "Título da Imagem")```
