# User Registration e Post

```python
from django.db import models # criado sempre que criamos um app
from django.utils import timezone # para usarmos no campo de data
from django.contrib.auth.models import User # para importar o usuário criado pelo django!

class Post(models.Model)
  title = models.CharField(max_lenght=100)
  content = models.TextField()
  date_posted = models.DateTimeField(default=timezone.now)
  author = models.ForeignKey(User, on_delete=models.CASCADE)
```

### ```on_delete=models.CASCADE```
Se apagarmos o usuário, os posts relacionados a ele serão apagados também!
