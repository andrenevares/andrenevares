# Parte 08
> Notes from Mscorey, made by André Nevares 

## Youtube link
- [Python Django Tutorial: Full-Featured Web App Part 8 - User Profile and Picture](https://youtu.be/FdVuKt_iuSI)

## User Profile and Picture
- Expandir o app user
- Django Signals

### Foto
- Por padrão o Django não possui o campo para uma foto
- Como conseguiremos fazer isso?
- Será dentro de ```users > models.py```

#### ```user > models.py```

Nosso codigo está assim:
```
from django.db import models
```

1. Inicalmente vamos trazer o ```user model``` nativo do Django: ```from django.contrib.auth.auth.models import User```
2. criamos o model e vamos herdar de models.Model ```class Profile(models.Model):```
3. Temos uma foto para cada perfil, então será ```OneToOneField()```
4. Será uma relação entre ```Profile``` e ```User``` logo será ```OneToOneField(User)```
5. A sintaxe fica ```user = models.OneToOneField(User)```
6. Se o ```User``` for apagado então também apague o ```Profile```, para isso vamos usar: ```on_delete=models.CASCADE```... Mas se o profile for apagado, o usuário não será apagado
7. Você pode colocar quantos perfis a mais você quiser,

O código até agora de ```user > models.py```
```
from django.db import models
from django.contrib.auth.models import User

class Profile(models.Model):
    user = models.OneToOneField(User, on_delete=models.CASCADE)
    image = models.ImageField(default='default.jpg', upload_to='profile_pics')

    def __str__(self):
        return f'{self.user.username} Profile'
  
```

#### Migration time!
Toda vez que criamos ou alteramos models nós temos que fazer o processo de migration.

1. Esteja certo de que está no diretório onde fica o ```manage.py```
2. Make Migrations: ```python manage.py makemigrations```
3. Executar a Migration: ```python manage.py migrate```

#### Erro - Instalar Pillow

Ao rodar o comando ```python manage.py makemigrations``` teremos: 

```
SystemCheckError: System check identified some issues:

ERRORS:
users.Profile.image: (fields.E210) Cannot use ImageField because Pillow is not installed.
        HINT: Get Pillow at https://pypi.org/project/Pillow/ or run command "python -m pip install Pillow".
```

Pillow é uma bliblioteca python para lidar com imagens.

Então instalamos o pillow: ```pip install pillow```

Vamos tentar rodar ```python manage.py makemigration```

Agora tivemos sucesso!

Vamos então à Migration: ```python manage.py migrate```

### Registrar no adm file do nosso APP
Para que possamos ver no nossa admin

#### users > admin.py
Vamos lembrar como fizermos o registro do nosso model Post???

```
from django.contrib import admin
from .models import Post

admin.site.register(Post)
```

Então nosso código será muito parecido... Só que ao invés de __Post__ vamos usar __Profile__

```
from django.contrib import admin
from .models import Profile

admin.site.register(Profile)
```

Vamos entrar no Admin?

```python manage.py runserver```

Entrando no ```localhost:8000/admin``` veremos que dentro do ADMIN nós temos o RUNSERVER.


### Adcionar Perfis via Admin

Vamos adcionar dois perfis.  Um com foto e outro sem.

### Vamos acessar via shell

- <kbd>Ctrl</kbd>+<kbd>C</kbd>
- ```python manage.py shell```

```
>>> from django.contrib.auth.models import User
>>> user = User.objects.filter(username='andre').first() 
>>> user
<User: andre>
```


### Diretório criado

Ao fazermos isso criamos o django cria uma pasta na nossa raiz chamada ```profile_pics```

```
projeto
├───blog
├───blogproject
├───profile_pics
└───users
```

O local de armazenamento das ```profile_pics``` não me parece muito bom...  O nosso sistema pode vir a fazer upload de outras imagens e toda vez que fizermos esse upload acabaremos por criar novo diretório na raiz...  Isso poderia poluir nossa raiz!
