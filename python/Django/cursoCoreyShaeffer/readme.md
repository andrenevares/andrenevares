# Anotações curso corey Shaeffer

## Video 01

Comecei abrindo o meu VSCODE

Fui até a raiz do meu HD ```D:``` e criei uma pasta chamada ```django```
```
D:\django
```

Depois fui até meu github e criei um repositório chamado ```gitone```

Agora vou fazer o meu ```git clone``` de modo a trazer para minha máquina o repositório do github.  Com isso eu posso deixar a cópia do meu código na WEB... Se eu quiser acessar esse projeto de outro lugar, basta eu fazer um ```git clone``` e boa!

com um terminal aberto vou até o diretório ```D:\django```

Se você estiver usando o VSCODE pode usar o <kbd>ctrl</kbd>+<kbd>'</kbd> que será aberto um terminal no próprio VSCODE.

```D:\django> git clone https://github.com/andrenevares/DjangoOne.git```

```
D:\django
      | - DjangoOne
```

Vou criar um virtual enviroment dentro do Django!

Se você não tem instalado [virtual enviroment](https://github.com/andrenevares/andrenevares/blob/master/venv/virtual_enviroment.md) e quiser saber um pouco mais eu coloco aqui link de uma anotação de como criar [virtual enviroment](https://github.com/andrenevares/andrenevares/blob/master/venv/virtual_enviroment.md).

Sendo assim...

Vou criar um virtual enviroment chamado venv:  ```D:\django> virtualenv venv```

```
D:\django
      | - DjangoOne
      | - venv
```





### Instalando Django
```pip install django```

### Confirmando se a instalação teve sucesso
```pip -m django version```

### Subcomandos do Django
No terminal digite ```django-admin```

### Iniciando um projeto Django
No terminal digite ```django-admin startproject [nome_do_projeto]```.

Se o seu projeto for blog irá digitar ```django-admin startproject blog```

```
DjangoBlog
   | - DjangoBlog
   |      | - __init__.py   
   |      | - asgi.py
   |      | - settings.py
   |      | - urls.py
   |      | - wsgi.py
   | - manage.py
```



