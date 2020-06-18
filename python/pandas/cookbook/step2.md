# Python CookBook 
- Passo 2

## Dados
- Os dados são de um arquivo em csv
- [https://tinyurl.com/exemplo-titanic](https://tinyurl.com/exemplo-titanic)

## Passo 1 - Importar a biblioteca
```
>>> import pandas as pd
```

## Passo 2 - Definir a variável url
```
>>> url = https://tinyurl.com/exemplo-titanic
```

### Passo 3 - Load Data
```
>>> dataframe = pd.read_csv(url)
```
- Crie um objeto chamado de ````dataframe```
- Atribua a esse objeto o que está na variável ```url```

### Passo 4 - Exibir as primeiras n linhas
```
>>> dataframe.head(4)
```

### Passo 5 - Mostrar dimensões
```
>>> dataframe.shape
```
