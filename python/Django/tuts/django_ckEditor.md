# Django CK-EDITOR

## Como instalar
```
pip install django-ckeditor
```

## Configurações necessárias

### models.py 
```
from ckeditor.fields import RichTextField
```

dentro da class do nosso model onde tenha o textfield

```
body = RichTextField(blank=True, null=true)
```




### forms



### settings.py


