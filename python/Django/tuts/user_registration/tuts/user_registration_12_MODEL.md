# Profile

Relacionamento: 1 perfil para 1 usuário,  __one to one__

## users > ```models.py```

```python
from django.db import models
from django.contrib.auth.models import User

class Profile(models.Model)
  user = models.OneToOneField(User, on_delete=models.CASCADE)
  image = models.ImageField(default='default.jpg', upload_to='profil_pics'
  
  def __str__(self):
    return f'{self.user.username} Profile'
```
> ```on_delete=models.CASCADE``` se apagarmos o usuário vamos apagar o profile
> Mas se apagarmos o profile __não vamos apagar__ o user.

__ATENÇÃO__: Se for trabalhar com imagem não esquecer de fazer o ```pip install pillow```

## Se quiser ver no admin

admin.py
```python
from django.contrib import admin
from .models import Profile

admin.site.register(Profile)
```
