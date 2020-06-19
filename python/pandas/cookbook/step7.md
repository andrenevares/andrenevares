# Minimun, Maximun, Sum, Average and Count

```
# Importar a biblioteca pandas as pd
import pandas as pd

# definir a variável url que terá os dados que vamos analisar
url = 'https://tinyurl.com/titanic-csv'

# carregamos os dados e armazenamos em um objeto chamado dataframe
dataframe = pd.read_csv(url)

# Calculando 
print('Maximum:', dataframe['Age'].max())
print('Minimum:', dataframe['Age'].min())
print('Mean:', dataframe['Age'].mean())
print('Sum:', dataframe['Age'].sum())
print('Count:', dataframe['Age'].count())
```

## Pandas também oferece
- variância ```var```
- standard deviation ```std```
- kurtosis ```kurt```
- skewness ```skew``` 
- standard error of the mean ```sem``` 
- mode ```mode``` 
- mediana ```median```
- entre outras...


## ```dataframe.count()```

```
>>> dataframe.count()
```
#### Output
```
Name        1313
PClass      1313
Age          756
Sex         1313
Survived    1313
SexCode     1313
dtype: int64
```
