# Python ML CookBook
> Exercícios adptados da plataforma oreilly.com deixamos o [link do material original](https://learning.oreilly.com/scenarios/python-ml-cookbook/9781492062783/)

## Começando

### instalando pandas
```
```

### Importando pandas
```
>>>import pandas as pd
```

### Definindo um Dataframe
```
>>>dataframe = pd.DataFrame()
```

### Criando o dataframe
```
>>> dataframe['Nome'] = ['André', 'Camila', 'Rafael']
>>> dataframe['Idade'] = [42, 37, 4]
>>> dataframe['Dirige'] = [True, True, False]
```


### Exibindo o dataframe
```
>>> dataframe
```

|   | Nome | Idade  | Dirige  |
| -  | - | -  | -  |
| 0 | André | 42  | True  |
| 1 | Camila | 37  | True  |
| 2 | Rafael | 4  | False  |


### Adicionando uma nova linha
Depois que você definiu, você pode inserir uma nova linha ao objeto
```
>>> nova_pessoa = (['Daniela', 39, True], index=['Nome', 'Idade', 'Dirige'])
>>> dataframe.append(nova_pessoa, ingnore_index=True)
```

```
>>> dataframe
```

|   | Nome | Idade  | Dirige  |
| -  | - | -  | -  |
| 0 | André | 42  | True  |
| 1 | Camila | 37  | True  |
| 2 | Rafael | 4  | False  |
| 3 | Daniela | 39  | True  |
