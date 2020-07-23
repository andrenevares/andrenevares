# Estrutura de um projeto dJANGO
[<< voltar](https://github.com/andrenevares/andrenevares/tree/master/python/Django)

```
nomeDoProjeto
    | - nomeDoProjeto
    |   | - __pycashe__ 
    |   | - __init__.py 
    |   | - asgi.py  
    |   | - settings.py  
    |   | - urls.py  
    |   | - wsgi.py  
    |- manage.py  
```

## manage.py
é um arquivo que não devemos mexer.

Usuários muito avançados podem alterar...  Mas recomenda-se não mexer.

## __pychash__
pycash é uma pasta onde o django armazena arquivos.  Se apagarmos vai ser criado novamente...  Não é um arquivo para o usuário

## __init__.py
É um arquivo muito avançado... Podem-se adcionar configurações especiais.

## asgi.py e wsgi.py
Usados no deploy

## settings.py 
Este é reamente importante.

#### BASE_DIR
onde fica o seu projeto no seu computador

#### SECRET_KEY
isso vc não quer que outras pessoas saibam...   

#### DEBUG
No desenvolvimento ```DEBUG = True``` permite que vejamos os erros.  Ajuda a que nós tenhamos um feedback.
- Desenvolvimento: ```DEBUG = True```
- Produção: ```DEBUG = False```

#### ALLOWED_HOSTS 

#### INSTALLED_APPS
Toda vez que você criar um _**app**_ você deve adcionar esse _**app**_ à lista.

#### MIDDLEWARE
são coisas pré moldadas do Django.  Não se preocupar com isso.

#### ROOT_URLCONF


#### TEMPLATES


#### WSGI_APPLICATION
quando fizermos o deploy

#### DATABASES

Padrão:
```
DATABASES = {
    'default': {
        'ENGINE': 'django.db.backends.sqlite3',
        'NAME': os.path.join(BASE_DIR, 'db.sqlite3'),
    }
}
```
Se mudarmos no __NAME__ criaremos um novo nome de arquivo...


#### AUTH_PASSWORD_VALIDATORS

#### LANGUAGE_CODE
padrão:
```
LANGUAGE_CODE = 'en-us'
```
 
Mudar para
```
LANGUAGE_CODE = 'pt-BR'
```

#### TIME_ZONE
Padrão:
```
TIME_ZONE = 'UTC'
```


#### USE_I18N
Padrão:
```
USE_I18N = True
```

#### USE_L10N
Padrão:
```
USE_L10N = True
```

#### USE_TZ = True
Padrão:
```
USE_TZ = True
```

#### STATIC_URL
Padrão:
```
STATIC_URL = '/static/'
```

