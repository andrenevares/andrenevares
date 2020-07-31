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
