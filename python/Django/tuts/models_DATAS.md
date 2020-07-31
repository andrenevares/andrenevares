# Models - Campos de data
> Estamos falando do arquivo ```models.py```

Vamos pegar o exemplo de um Post de Blog.

Quando escrevemos:

```python
class Post(models.Model):
  title = models.Charfield(max_lenght=100)
  content = modens.TextField()
  date_posted = models.DateTimeField(auto_now_add=True)
```

## ```auto_now_add=True``` --> ```default=timezone.now```
 ```auto_now_add=True``` não permite que coloquemos uma data manualmente!!!

Dessa forma a documetação do django ([neste link](https://docs.djangoproject.com/en/3.0/ref/models/fields/#django.db.models.DateField.auto_now)) fala para usarmos:


#### Ao invés de usarmos um valor que não podemos editar
```python
  date_posted = models.DateTimeField(auto_now_add=True)
```

#### Usaremos um valor padrão colocado como now...no entanto, se quisermos, podemos definir um valor para ele! 
```python
from django.utils import timezone
  date_posted = models.DateTimeField(default=timezone.now)
```
