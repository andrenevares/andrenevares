# Django - Parte 04

[Python Django Tutorial: Full-Featured Web App Part 4 - Admin Page](https://youtu.be/1PkNiYlkkjo)

> Anotações de André Nevares
## Admin Page

Para acessar a página de admin em desenvolvimento:
- http://localhost:8000/admin

Mas ainda não podemos nos logar...  Diferentemente de outros frameworks o Django não vem com um usuário e senha padrão... Precisaremos criar um ```admin user``` para que possamos nos logar pela primeira vez.

## Criando um ```superuser```

Voltamos para o prompt de comando, e paramos o servidor que está rodando.  <kbd>Ctrl</kbd> + <kbd>C</kbd>

```python manage.py createsuperuser```

Mas se rodarmos isso não vai dar certo...  Vai dar erro... 
```
no such table: auth_user
```

Temos que fazer algumas migrations

## makemigrations

```python manage.py makemigrations```

o resultado será ```No changes detected```

De modo a criar as migrations nós precisamos rodar:

## Processo correto 

1. ```python manage.py migrate```
2. ```python manage.py createsuperuser```

Será solicitado:
```Username (leave blank to use 'micro'):```
Você deve digitar o seu comando...

```
Username (leave blank to use 'micro'): andre
Email address: andre.nevares@gmail.com
Password:
Password (again):
Superuser created successfully.
```
## Entrar no Admin

Agora que criamos o __superuser__ podemos entrar na área de Admin

Devemos rodar nosso servidor novamente... Então...
```
python manage.py runserver
``` 

Entre em http://localhost:8000/admin e agora você conseguirá se logar 
