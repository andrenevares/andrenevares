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
>>> url = 'https://tinyurl.com/exemplo-titanic'
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

#### Resultado:
|  | Name| PClass | Age | Sex | Survived | SexCode |
| - | - | - | - | - | - | - |
| 0 | Allen, Miss Elisabeth Walton  |  1st | 29.0 | female | 1 | 1 |
| 1 | Allison, Miss Helen Loraine  |  1st |  2.0 | female | 0 | 1 |
| 2 | Allison, Mr Hudson Joshua Creighton  |  1st | 30.0 | male | 0 | 0 |
| 3 | Allison, Mrs Hudson JC (Bessie Waldo Daniels) |  1st | 25.0 | female | 0 | 1 |

### Passo 5 - Mostrar dimensões
```
>>> dataframe.shape
```

#### Resultado:
```(1313, 6)```
- Nº de linhas: 1313
- Nº de colunas: 6

### Passo 6 - ```Describe```
```
>>> dataframe.describe()
```

#### Resultado:

| | Age | Survived | SexCode |
| - | - | - | - |
| count | 756.000000|  1313.000000 | 1313.000000 |
| mean | 30.397989| 0.342727 |    0.351866 |
| std | 14.259049 | 0.474802 |    0.477734 |
| min | 0.170000 | 0.000000  |   0.000000 |
| 25% | 21.000000 | 0.000000 |    0.000000 |
| 50% | 28.000000 | 0.000000 |    0.000000 |
| 75% | 39.000000 | 1.000000 |1.000000 |
| max | 71.000000 | 1.000000 |1.000000 |

