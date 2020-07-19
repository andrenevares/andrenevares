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

```
>>> user.profile
<Profile: andre Profile>
>>> user.profile.image
<ImageFieldFile: profile_pics/GITHUB-LOGO.png>
>>> user.profile.image.url
'profile_pics/GITHUB-LOGO.png'
```

```
>>> exit()
\ python manage.py runserver
```
### Mundando onde a imagem é salva

Quando criamos perfis, verificamos que o django etá armazendo as imagens do diretório ```profile_pics```...

```
projeto
├───blog
├───blogproject
├───profile_pics
└───users
```

No entanto, o local do diretório ```profile_pics``` não nos  parece muito bom...  

O projeto pode ter outras funcionalidades que façam upload de outras imagens! 

Se toda vez que fizermos uma nova função de upload colocarmos uma nova pasta dentro da raiz ...  Isso poderia poluir nossa raiz!

Para resolver esse problema nós podemos fazer o seguinte:

dentro do nosso __settings.py__ precisaremos configurar __MEDIA_ROOT__ e __MEDIA_URL__.


- __MEDIA_URL__: é a URL pública daquela URL


### MEDIA_ROOT

#### O que é MEDIA_ROOT
- MEDIA_ROOT: o full path onnde queremos que o Django armazene aqruivos upados!  Por questões de performance, esses arquivos são salvos no ```filesystem``` e não no banco dados.  Então o __MEDIA_ROOT__ será o diretório onde os arquivos serão salvos...

#### Alterar MEDIA_ROOT
Vamos mudar manter os arquivos salvos na raiz, mas façamos que todos os arquivos upados sejam salvos em um diretório chamado ```media``` 

Sintaxe em ```settings.py```
```MEDIA_ROOT = os.path.join(BASE_DIR, 'media')```
- Vai ficar na raiz do sistema 
- independentemente do sistema operacional que você esteja usando
- em um diretório ```media```

### Nova estrutua
```
projeto
├───blog
├───blogproject
└───media
    └───profile_pics
```

### ```default.png``` ou ```default.png```
As fotos dos usuários serão salvas dentro do ```media > profile_pics```.   A foto ```default```deve ficar no diretório ```media``` e não dentro de ```profile_pics``` como demonstramos abaixo:

As fotos ficam assim:

```
projeto
├───blog
├───blogproject
└───media
    ├───profile_pics
    |   ├───andre.jpg
    |   ├───camila.jpg
    |   └───rafael.png
    └───default.png
```

### Template ```profile```
```
{% extends "blog/base.html" %}
{% load crispy_forms_tags %}

{% block content %}
<div class="content-section">
    <div class="media">
        <img class="rounded-circle account-img" src="{{ user.profile.image.url }}">
        <div class="media-body">
            <h2 class="account-heading">{{ user.username }}</h2>
            <p class="text-secondary">{{ user.email }}</p>
        </div>
    </div>
</div>
{% endblock content %}
```

### Associar um ```profile``` para cada user

```
```
