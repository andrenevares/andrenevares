# Flask-Session extension
> André Nevares

Eu estava assistindo a uma das aulas do CS50 Web Programmimg with Python and Javacript, o qual sinceramente eu recomendo que todos assistam e façam o curso, quando tive que fazer o projeto 01.  

Muito embora o projeto 01 pareça ser o primeiro, não é!  O primeiro projeto é o projeto0, onde você tem que mostrar suas habilidades em 
- GIT
- HTML 
- CSS
- Bootstrap 
- e Less

Bem... Voltando ao projeto 01.  No requirements.txt estava lá nos requisitos do projeto:  Trabalhar com a extensão flask-session.  Pesquisei a documentação e sinceramente não achei muita coisa.  Dessa forma, esquecido como eu sou, resolvi fazer um breve resumo das dificuldades que tive e como trabalhar com flask-session.

O grande problema é que ao que parece as pessoas migraram para a extensão Flask-Login.  Ela é mais amigável e por isso não se acha muita coisa recessente sobre Flask Session.  Pesquisei no youtube, stack, google, na documentaçao do próprio... Mas as pessoas parecem realmente que preferem usar flask-login.

Sinceramente eu acho que eu sou uma delas...


## Importando Módulos
Quando falamos de flask estamos falando de um microframework, ou seja, tem o básico e você se quiser instale o resto.  Essa é a filosofia do Flask.  

No caso do Flask Session você não precisará instalar mais um pacote, pois ele já é nativo do flask... 
Mas você precisa importar os módulos dentro do seu app, beleza?

Vamos importar então:

```
from flask import session
from flask_session import Session
```

## Configurações

O segundo passo será você fazer as suas configurações.  
Nesse caso  logo abaixo das configurações básicas do Flask insira esses comandos.
> Obs. Existe mais de uma maneira de você configurar o Flask, mas no meu exemplo eu estarei usando a opçao Filesystem.

```
app = Flask(__name__)
app.config['SECRET_KEY'] = 'Your Key'

# Configure session to use filesystem
app.config["SESSION_PERMANENT"] = False
app.config["SESSION_TYPE"] = "filesystem"
Session(app)
```

## Meu Login
Quando você cria uma sessão, ou session, você está identificando através de um hash aquele específico usuário.  Desta forma é interessante que você consiga identificar aquele usuário de maneira única.  Se o seu banco de dados possui uma chave tipo user id e for única você pode fazer isso...  No meu caso eu preferi encriptar o username.  No meu projeto o username é um registro único.  Não pode haver mais de um usuário com o mesmo login... Parece óbvio não?

De qualquer forma abaixo segue a transcrição dos trechos da routeÇ 

```
@app.route("/login", methods=['GET', 'POST'])
def login():
    if you can login ....
       session["username"] = username
```

## Login required pages

```
@app.route("/example")
@login_required
def example():
    pass
```
## Logout route
Para fazer o logout basta fazer o ```session.clear()``` como vocë verã abaixo.

```
@app.route("/logout")
def logout():
    session.clear()
```
## Rentringindo acesso.

Para restringir o acesso via flask session basta usar ```@login_required```

Por exemplo... Neste projeto em específico eu criei uma pesquisa.

```
@app.route("/search", methods=['GET', 'POST'])
@login_required
def search():
```

Usando o login required você poderá restringir o acesso à sua aplicaçao de forma bastante fácil....  
Basta colocar abaixo da route ```login_required```


Bem...

Por hoje é só!

Vamos que vamos!!!



