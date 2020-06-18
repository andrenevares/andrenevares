# Pandas - ```loc``` e ```iloc```

```
>>> import pandas as pd
>>> url = 'https://tinyurl.com/exemplo-titanic'
>>> dataframe = pd.read_csv(url)
```

## Se eu quiser descobrir o registro de uma linha X
> Exemplo... Vamos pegar o registro do 3 passageiro
> Lembrando que o primeiro é 0, o segundo é 1 e assim por diante

```
>>> dataframe.iloc[2]
```

#### Output... 
```
Name        Allison, Mr Hudson Joshua Creighton
PClass                                      1st
Age                                          30
Sex                                        male
Survived                                      0
SexCode                                       0
Name: 2, dtype: object
```

## Se quisermos pegar, por outro lado, um intervalo de linhas

```
>>> dataframe.iloc[2:7]
```
#### Output...
```
                                            Name PClass    Age     Sex  Survived  SexCode
2            Allison, Mr Hudson Joshua Creighton    1st  30.00    male         0        0
3  Allison, Mrs Hudson JC (Bessie Waldo Daniels)    1st  25.00  female         0        1
4                  Allison, Master Hudson Trevor    1st   0.92    male         1        0
5                             Anderson, Mr Harry    1st  47.00    male         1        0
6               Andrews, Miss Kornelia Theodosia    1st  63.00  female         1        1
```

## Pegar al linhas superiores a uma linha específica
```
>>> dataframe.iloc[:6]
```
#### Output...
```
                                            Name PClass    Age     Sex  Survived  SexCode
0                   Allen, Miss Elisabeth Walton    1st  29.00  female         1        1
1                    Allison, Miss Helen Loraine    1st   2.00  female         0        1
2            Allison, Mr Hudson Joshua Creighton    1st  30.00    male         0        0
3  Allison, Mrs Hudson JC (Bessie Waldo Daniels)    1st  25.00  female         0        1
4                  Allison, Master Hudson Trevor    1st   0.92    male         1        0
5                             Anderson, Mr Harry    1st  47.00    male         1        0
```

## ```set_index()```
Você poder definir uma coluna como parâmetro para sua busca.
- Vamos colocar a coluna ```Name```
```
>>> dataframe = dataframe.set_index(dataframe['Name'])
```
- Vamos buscar por um nome específico, por exemplo.... __Allison, Miss Helen Loraine__

#### Output...
```
Name        Allison, Miss Helen Loraine
PClass                              1st
Age                                   2
Sex                              female
Survived                              0
SexCode                               1
Name: Allison, Miss Helen Loraine, dtype: object
```
### Caso eu queira saber os passageiros com 2 anos de idade

```
>>> dataframe = dataframe.set_index(dataframe['Age'])
>>> dataframe.loc[2]
```

#### Output...
```
                                 Name PClass  Age     Sex  Survived  SexCode
Age
2.0       Allison, Miss Helen Loraine    1st  2.0  female         0        1
2.0              Mallet, Master Andre    2nd  2.0    male         1        0
2.0     Navratil, Master Edmond Roger    2nd  2.0    male         1        0
2.0           Quick, Miss Phyllis May    2nd  2.0  female         1        1
2.0        Wells, Master Ralph Lester    2nd  2.0    male         1        0
2.0  Andersson, Miss Ellis Anna Maria    3rd  2.0  female         0        1
2.0           Hirvonen, Miss Hildur E    3rd  2.0  female         0        1
```
