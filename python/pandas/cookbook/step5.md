# Step 5 - Substiuindo valores 

## Começo
```
>>> import pandas as pd
>>> url = 'https://tinyurl.com/exemplo-titanic'
>>> dataframe = pd.read_csv(url)
```

## Substituindo um valor
```
>>> dataframe['Sex'].replace("female", "Woman").head(10)
```
##### Output
```
0    Woman
1    Woman
2     male
3    Woman
4     male
5     male
6    Woman
7     male
8    Woman
9     male
Name: Sex, dtype: object
```

## Substituindo mais de um valor
```
>>> dataframe['Sex'].replace(['female', 'male'] , ['mulher', 'homem'] ).head(10)
```
##### Output ...
```
0    mulher
1    mulher
2     homem
3    mulher
4     homem
5     homem
6    mulher
7     homem
8    mulher
9     homem
```
## Replace com Regular Expressions - Regex

```
>>> dataframe.replace(r"1st", "First", regex=True).head(2)
```
##### Output ...
```
                           Name PClass   Age     Sex  Survived  SexCode
0  Allen, Miss Elisabeth Walton  First  29.0  female         1        1
1   Allison, Miss Helen Loraine  First   2.0  female         0        1
```
