# Funções em Python

```
def saudacao(nome, idade):
  print(f"Olá {nome} , você tem {idade}!")

saudacao("André", 42)
```


Resultado:
```Olá André , você tem 42!```

## Colocando valores padrão em uma função

Colocando valor padrão de:
- nome = "não inserido"
- idade = 0


```
def saudacao(nome="não inserido", idade=0):
  print(f"Olá {nome}, você tem {idade}!")

saudacao()
```
Resultado: ```Olá não inserido, você tem 0!```


## Com Return
```
def saudacao(nome="não inserido", idade=0):
  return f"Olá {nome}, você tem {idade}!"

frase = saudacao()
print(frase)
```
Resultado: ```Olá não inserido, você tem 0!```

### Entendendo a função com Return
- O resultado da função vai retornar 
- colocamos o retorno dessa função em uma variável chamada ```frase```
- depois imprimimos ```frase```

