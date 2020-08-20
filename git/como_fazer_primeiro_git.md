# Como fazer o primeiro git

Eu gosto de trabalhar com ambientes virtuais (virtual enviroments).  Dessa forma as coisas ficam organizadas dentro daquele ambiente. Sendo assim a estrutura de um projeto django seria assim:

```
nome-do-projeto
   |- django_project 
   |- venv
```

Mas para ficar bem organizado no GIT seria meio ineficiente fazer o clone da pasta ```nome-do-projeto```...  Teríamos que usar o ```.git-igonore``` e seria uma pasta a mais desnecessária.

Assim o que eu faço:

### crio a pasta ```nome_do_projeto```
Dentro dela estará tanto o ```django-project``` como o ```nome_do_projeto```

### crio o ambiente virtual
```virtualenv venv```

### ativar o virtualenviroment
```.\venv\scripts\activate```

### crio o projeto django
```django-admin startproject django-project```
> troque o ```django-project``` para o nome que você quiser

### Ir até o Github criar um novo diretório e copiar a url
Vá até sua conta do git hub, crie um diretório com o nome do ```django-project```

### entre na pasta do ```django-project```
```cd django-project```

### Comandos do GIT
```
git init
```

```
git remote add origin https://github.com/andrenevares/django-project
```

```
git add .
```

```
git commit -m "primeiro deploy"
```

```
git push origin master
```

