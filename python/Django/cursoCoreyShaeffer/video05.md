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

### Tabelas do nosso banco de dados
- User (criada pelo backend do Django)
- Posts (esta nós vamos criar!!!)

__Observação__:  Nós temos que estabelecer uma relação de entre as tabelas.  Será o que chamamos de ```one-to-many``` ou ```um-pra-muitos```.  Isto porque um ```author``` pode ter muitos ```posts```, no entanto um ```post``` só pode ter um ```author```.

### Criando um model para o post

#### Campos
Os campos da tabela ```Post``` serão:
- title
- content
- date_posted
- author (Será nossa chave estrangeira)

#### Vamos criar um model ```Post```
```
class Post(models.Model):
```

#### Definindo title
Podemos colocar restrições... No caso vamos colocar que o título tenha no máximo 100 caracteres...
```
title = models.CharField(max_lenght=100)
```

#### Definindo campo content 
```CharField``` e ```TextField``` são praticamente os mesmos campos.  No entanto ```TextField``` é um campo sem restrições...

```
content = models.TextField()
```
#### Definido o campo date_posted

Temos duas opções:
- ```date_posted = models.DateTimeField(auto_now)``` ou
- ```date_posted = models.DateTimeField(default=timezone.now)```

Com ```auto_now``` nós vamos dizer que a data do post é o momento que foi criado...  Mas se você quer a possibilidade de colocar a data, e caso não seja preenchida, a mesma seja considerada como agora... bem, neste caso você deverá usar ```default=timezone.now```

Note que usamos ```timezone.now``` ao invés de ```timezone.now()``` com ```()```.  Porque?
- Ao colocar ```()``` estaremos usando a função.
- Como queremos atribuir a uma variável o valor de ```timezone.now``` não usaremos o ```()```

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
from django.utils import timezone

class Post(models.Model):
  title = models.CharField(max_lenght=100)
  content = models.TextField()
  date_posted = models.DateTimeField(default=timezone.now)
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
