# Part 3 - Templates
> Python Django Tutorial: Full-Featured Web App Part 3 - Templates

## O que veremos
- Como usar templates de modo a ter uma apresentação melhor de Layout
- Bem como passar variáveis para os respectivos templates

## Templates

### Criando diretório ```templates```
- Para usar templates tempos que criar um diretório chamado ```templates``` dentro do nosso diretório ```blog```.
- Por padrão o django vai procurar um diretório chamado ```templates``` em cada app instalado.
- Como ainda não instalamos ainda nenhum app...
- Por padrão tempos que criar um novo diretório ```[com_mesmo_nome_do_app]``` dentro do diretório ```templates```.
- Logo vamos criar um  diretório chamado ```blog``` dentro do diretório ```templates```

### Estrutura ```tree```
```
├───blog
│   ├───migrations
│   ├───templates
│   │   └───blog
│   └───__pycache__
└───blogproject
    └───__pycache__
```

### Criando primeiro template

Vamos criar template:
- Um para homepage --> (
- Outro para nossa página about --> 



### Inserir nosso app dentro de ```settings.py```



1. Vamos abrir o arquivo ```blog > apps.py```

O conteúdo do nosso arquivo é:
```
from django.apps import AppConfig

class BlogConfig(AppConfig):
    name = 'blog'
```

Quando criamos o nosso app foi criada ```class BlogConfig(AppConfig):```

2. Vamos pegar esse ```BlogConfig``` app e copiar para ```blogproject > settings.py```

3. Vamos abrir ```blogproject > settings.py```

Nosso ```blogproject > settings.py``` contém:
```
INSTALLED_APPS = [
    'django.contrib.admin',
    'django.contrib.auth',
    'django.contrib.contenttypes',
    'django.contrib.sessions',
    'django.contrib.messages',
    'django.contrib.staticfiles',
]
```

4. Vamos adcionar o ```BlogConfig``` app.
- Está dentro de blog > apps >  BlogConfig
- Dessa forma vamos adcionar 
- ```'blog.apps.BlogConfig',```

Nosso vódigo ficará:
```
INSTALLED_APPS = [
    'blog.apps.BlogConfig',
    'django.contrib.admin',
    'django.contrib.auth',
    'django.contrib.contenttypes',
    'django.contrib.sessions',
    'django.contrib.messages',
    'django.contrib.staticfiles',
]
```

### Não esqueça de sempre inserir dentro do ```settings.py``` do projeto:
Porque???

Ora... Django precisa saber onde procurar !

Será com essa configuração que o DJANGO irá saber onde procurar
- Templates
- Modules (banco de dados)




