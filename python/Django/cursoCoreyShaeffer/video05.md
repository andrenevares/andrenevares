# Parte 05
> Anotações de André Nevares

## Database and Migrations
- [Python Django Tutorial: Full-Featured Web App Part 5 - Database and Migrations](https://youtu.be/aHC3uTkT9r8)

### Django ORM
Diferentemente de flask, que usa Flask-SqlAlchemy, o Django tem sua própria estrutura ORM - Oriented Relational Mapping.

- Nós vamos respresentar essas estruturas como ```classes``` do python
- Mas vamos chamar essas ```classes``` como ```models```.

### ```blog > models.py```
Quando criamos o APP, o Django já cria o arquivo ```[nome_do_app] > models.py```
```
from django.db import models
```


### Criando um model para o post

#### Vamos criar um model ```Post```
```
class Post(models.Model):
```

#### Definindo title
Podemos colocar restrições... No caso vamos colocar que o título tenha no máximo 100 caracteres...
```
from django.db import models

class Post(models.Model):
  title = models.CharField(max_lenght=100)
```

#### Definindo campo content 
```CharField``` e ```TextField``` são praticamente os mesmos campos.  No entanto ```TextField``` é um campo sem restrições...

```
from django.db import models

class Post(models.Model):
  title = models.CharField(max_lenght=100)
  content = models.TextField()
```
#### Definido o campo date_posted
Para trabalhar com o date posted nós vamos importar do __django utils__ >>> timezone

```
from django.utils import timezone
```

assim podemos definir nosso campo ```date_posted``` como a hora que o usuário estiver submetendo o post, dessa forma temos usaremos ```timezone.now```

O campo será definido assim:

```
date_posted = models.DateTimeField(default=timezone.now)
```

Nosso código até agora está:
```
from django.db import models

class Post(models.Model):
  title = models.CharField(max_lenght=100)
  content = models.TextField()
```
#### Definido relação com o campo user

Agora temos que criar uma relaçã
Mas ainda precisamo


### Rodar ```migrate```

```
python manage.py makemigrations
```

### Ver o comando SQL feito 

```python manage.py sqlmigrate [nome_do_app] [nº_do_migrate]```

### Como fazer as queries

```python manage.py shell```
