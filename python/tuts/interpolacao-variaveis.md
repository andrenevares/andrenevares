# Interpolação de variáveis

Acima da versão 3 do python temos a questão de interpolação.

Imaginemos que criamos uma mensagem:

_Olá André, o saldo de sua conta é 50 reais._

É uma mensagem padrão onde temos duas partes variáveis:

_Olá __André__, o saldo de sua conta é __50__ reais._

podemos colocar no python:

```
nome = "Rafael"
saldo = 5000
```

Para fazer a interpolação teremos 

```frase = f"Olá {nome}, o saldo de sua conta é {saldo} reais.```

Quando executarmos ```print(frase)``` termos a mensagem: Olá Rafael, o saldo de sua conta é 5000 reais.

