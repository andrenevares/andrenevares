# Dicionários
- Não existe ordem em um dicionário!

## Sintax

```
nome_dict = {"chave": valor, (...)} 
```


## Exemplo:
```
>>> familia = {"André": 42, "Camila": 37, "Rafael": 4}
>>> print(familia["Camila"])
37
```


## Adcionar
```
familia["Daniela"] = 39
```
Resultado:
{'André': 42, 'Camila': 37, 'Rafael': 4, 'Daniela': 39}


## Delete 

```
del(familia["Daniela"])
```
Resultado:
{'André': 42, 'Camila': 37, 'Rafael': 4}

## Atualizar

```
familia["André"] = 17
```
Resultado: {'André': 17, 'Camila': 37, 'Rafael': 4}


