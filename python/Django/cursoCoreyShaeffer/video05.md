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

#### Vamos criar um model ```Post```
```
class Post(models.Model):
```
#### Campos
Os campos da tabela ```Post``` serão:
- title
- content
- date_posted
- author (Será nossa chave estrangeira)

##### Campo ```title```
Podemos colocar restrições... No caso vamos colocar que o título tenha no máximo 100 caracteres...
```
title = models.CharField(max_length=100)
```

##### Campo ```content```
```CharField``` e ```TextField``` são praticamente os mesmos campos.  No entanto ```TextField``` é um campo sem restrições...

```
content = models.TextField()
```
##### Campo ```date_posted```

Temos duas opções:
- ```date_posted = models.DateTimeField(auto_now_add=True)``` ou
- ```date_posted = models.DateTimeField(default=timezone.now)```

Com ```auto_now``` nós vamos dizer que a data do post é o momento que foi criado...  Mas se você quer a possibilidade de colocar a data, e caso não seja preenchida, a mesma seja considerada como agora... bem, neste caso você deverá usar ```default=timezone.now```

Para trabalhar com o date posted nós vamos importar do __django utils__ >>> timezone

```
from django.utils import timezone
```

assim podemos definir nosso campo ```date_posted``` como a hora que o usuário estiver submetendo o post, dessa forma temos usaremos ```timezone.now```

O campo será definido assim:

```
date_posted = models.DateTimeField(default=timezone.now)
```

Note que usamos ```timezone.now``` ao invés de ```timezone.now()``` com ```()```.  Porque?
- Ao colocar ```()``` estaremos usando a função.
- Como queremos atribuir a uma variável o valor de ```timezone.now``` não usaremos o ```()```


##### Campo ```user```

```
from django.contrib.auth.models import User
```

```
author = models.ForeignKey(User, on_delete=models.CASCADE)
```

```on_delete=models.CASCADE``` define que se um usuário for excluído, todos os posts relacionados àquele usuário serão excluídos também.

### ```Post``` model concluído
```
from django.db import models
from django.utils import timezone
from django.contrib.auth.models import User

class Post(models.Model):
    title = models.CharField(max_length=100)
    content = models.TextField()
    date_posted = models.DateTimeField(default=timezone.now)
    author = models.ForeignKey(User, on_delete=models.CASCADE)
```

### Agora que nós temos o arquivo pronto temos que fazer o processo de ```migrate```
Para atualizar as tabela e relações nós precisamos fazer o que?  

1. Criar ```migrations```  ---> ```python manage.py makemigrations```
2. Executar as ```migrations``` ---> ```python manage.py migrate```

#### 1. Criar ```migrations```
Primeiramente criamos uma ```migration```, para depois executar essa ```migration```

```python manage.py makemigrations```

O output será:
```
Migrations for 'blog':
  blog\migrations\0001_initial.py
    - Create model Post
```

#### Se você quiser ver como o comando SQL é feito...

```python manage.py sqlmigrate [nome_do_app] [nº_do_migrate]```

Como no nosso caso o o app se chama ```blog``` e o migrate foi ```blog\migrations\0001_initial.py``` nosso comando vai ser:

```python manage.py sqlmigrate blog 0001```

O Output desse comando será:
```
BEGIN;
--
-- Create model Post
--
CREATE TABLE "blog_post" ("id" integer NOT NULL PRIMARY KEY AUTOINCREMENT, "title" varchar(100) NOT NULL, "content" text NOT NULL, "date_posted" datetime NOT NULL, "author_id" integer NOT NULL REFERENCES "auth_user" ("id") DEFERRABLE INITIALLY DEFERRED);
CREATE INDEX "blog_post_author_id_dd7a8485" ON "blog_post" ("author_id");
COMMIT;
```

#### 2. Executar as ```migrations```

```python manage.py migrate```

As ```migrations``` são uma coisa muito importante.  Nós podemos alterar as tabelas e o banco de dados mesmo que haja dados nele!

### Como podemos fazer nossas quereis com os Models do Django?

A interface ORM do Django permite que façamos interações com o banco de dados por meio de classes (também).


Para mostrar esse processo vai rodar um comando de forma a ver o processo linha a linha por meio da interface de comando

Para isso vamos rodar o comando:  ```python manage.py shell```

Será aberto um console parecido com o do __Python__.  Na verdade ele é um console __python__ mas que também permite interações com __Django__

