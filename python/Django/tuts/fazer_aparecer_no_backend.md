# Fazer com que o modelo apareça no Admin

Uma vez criado o modelo, pode ser que você queira que ele esteja acessivo no Backend do Django

Para isso você terá que ajustar o arquivo __admin.py__

## ajustando o __admin.py__

Imaginemos que você criou um modelo chamado de __Post__.

Os modelos ficam no model.py.

O arquivo ```admin.py``` se encontra no mesmo diretório do seu arquivo ```models.py```

Por isso, ao importamos um Modelo do ```models.py``` usaremos o sinal de ```  .   ```

Logo a sintaxe:

```python
from django.contrib import admin
from .models import Project

admin.site.register(Post)
```
