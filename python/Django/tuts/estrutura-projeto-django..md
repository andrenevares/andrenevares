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

__BASE_DIR__: onde fica o seu projeto no seu computador

__SECRET_KEY__: 

__DEBUG__: No desenvolvimento ```DEBUG = True``` permite que vejamos os erros.  Ajuda a que nós tenhamos um feedback.

__ALLOWED_HOSTS__

__INSTALLED_APPS__

__MIDDLEWARE__

__ROOT_URLCONF__

__TEMPLATES__

__WSGI_APPLICATION__

__DATABASES__

__AUTH_PASSWORD_VALIDATORS__

__LANGUAGE_CODE = 'en-us'__

__TIME_ZONE = 'UTC'__

__USE_I18N = True__

__USE_L10N = True__

__USE_TZ = True__

__STATIC_URL = '/static/'__
