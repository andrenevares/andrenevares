# Usando a autenticação do Django

Este documento explica como usar o sistema de autenticação do django na sua configuração padrão. 

Essa configuração evoluiu de modo a atender às necessidades mais comuns de um projeto.  Sendo assim, lida com uma série de tarefas além de possuir uma implementação cuidadosa no que se refere a senhas e permissões. 

Para projetos em que as necessidades de autenticação diferem do padrão, o Django dá suporte a múltiplas  extensões e customizações de autenticação.

A autenticação do Django fornece tanto autenticação como a  autorização sendo geralmente chamado de sistema de autenticação, haja vista esses recursos estarem de certa forma acoplados.

## User objects

User objects são o núcleo do sistema de autenticação.  São tipiciamente as pessoas que interagem no seu site e são usados de modo a possibilitar a restrição de acesso, registro de 
 perfis, associar um determinado conteúdo ao seu criador, etc...

No que se refere ao sistema de autenticação do Django, há apenas uma classe de usuário!  Isso quer dizer que os usuários chamados de 'superusers' ou 'staff' 'são tão somente atributos especiais definidos para o objeto user... e não classes diferentes deste objeto.

Os atributos primários do user padrão são:
- username
- password
- email
- first_name
- last_name

[Veja a documentação completa para mais detalhes](https://docs.djangoproject.com/en/3.0/ref/contrib/auth/#django.contrib.auth.models.User)

## Criando users

A maneira mais direta de criar usuários é usar a função create_user() incluída:

```python
>>> user = User.objects.create_user('john', 'lennon@thebeatles.com', 'johnpassword')
>>> user.last_name = 'Lennon'
>>> user.save()
```

## Criando superusers

Você pode criar superusers utilizando o comando ```createsuperuser```:

```python
$ python manage.py createsuperuser --username=joe --email=joe@example.com
```

No prompt você deverá inserir uma senha.  Depois de você inserir uma senha, o usuário será criado.  Se voc~e deixar o --username e --email em braco, o prompt irá solicitar esses dados para você.


