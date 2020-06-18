# Step 4 - Selecionando Linhas baseado em condições

## Começo
```
>>> import pandas as pd
>>> url = 'https://tinyurl.com/exemplo-titanic'
>>> dataframe = pd.read_csv(url)
```

## Com uma condição
Exemplo: Exibir as duas primeiras linhas quando ```Sex``` for igual a ```female```
- Obsersação:  Estamos falando de String, logo ```sex``` não é igual a ```Sex```
- 
```
>>> dataframe[dataframe['Sex'] == 'female'].head(2)
```

## Exemplo 2 
- Quanta bebês estavam no titanica
- Considerando bebês com idade menor ou igual a 1 ano;

```
>>> dataframe[dataframe['Age'] <= 1]
```

## Com duas condições
- Quero saber quantos bebês do sexo feminino
```
>>> dataframe[(dataframe['Age'] <= 1) & (dataframe['Sex'] == 'female') ]
```
