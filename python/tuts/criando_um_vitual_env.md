# Virtual Env for Python

Ao instalar uma biblioteca Python sem um ambiente virtual, você a instala globalmente. 
Isso geralmente requer que você seja um administrador ou execute como root e que a biblioteca Python exista 
para todos os usuários e projetos na máquina. Felizmente, é fácil criar um ambiente virtual:

## A melhor prática é:
### Criar um diretório 
```
mkdir nomeDoProjeto
cd nomeDoProjeto
```

### Criar um ambiente virtual dentro dessa pasta.  Chame de venv ou env... ou algo óbvio
digite:
```virtualenv venv```

### Adicione venv no seu .gitignore:
```
git init
echo 'venv' > .gitignore
```
Isso mantém o seu ambiente virtual fora do controle de versão do git.

### Ative o ambiente virtual:
```activate venv/bin/activate```

### instale alguma coisa:
```pip install django```

### Faça um freeze dos requirements:
```pip freeze > requirements.txt```

### coloque o requirements.txt dentro do controle de versionamento:
```git add requirements.txt```

## Resumo
A idéia aqui é simples. Seu ambiente virtual permanecerá em sua própria pasta, e não vai ser clonado para o GIT. 

Dessa forma, seu ambiente não polui a raiz do seu projeto. 

Os requisitos, por outro lado, são verificados e enviados ao git para que haja você possa fazer o clone do repositório .
