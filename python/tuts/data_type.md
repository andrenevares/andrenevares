# Data types em python

- Integer
- Float
- String
- Boolean
- List
- Dictionary

## Integer

```
>>> 2+2
4

>>> -1
-1

>>> -1+5
4
```
## Float

```
>>> 1.5+2
3.5
```

### Operadores

#### soma
```
>>>1 + 3
4
```
#### subtração
```
>>>5 - 4 
1
```
#### divisão
```
>>> 1/2
0.5
```
#### multiplicação
```
>>> 4 * 2
8
```
#### exponenciação
```
>>> 4 ^ 2
8
```


## Função type()
```
>>> type(1)
<class 'int'>

>>> type(1.0)
<class 'float'>
```

## Concatenando
```
>>> "Hello"
'Hello'
>>> "I´Reiley"
'I´Reiley'
>>> type("Hello")
<class 'str'>
>>> "Hello" + "World"
'HelloWorld'
>>> "Hello " + "World"
'Hello World'
>>> "Hello" + " World"
'Hello World'
>>> "Hello" + " " +"World"
'Hello World'
>>> name = "Andre"
>>> "Hello " + name
'Hello Andre'
```

## String
```
>>> "hello"
'hello'

>>> 'hello'
'hello'

>>> "1"
'1'
>>> type('1')
<class 'str'>
```

```
>>> str(1)
'1'
>>> "hello" + str(1)
'hello1'
>>> 'hello ' + str(1)
'hello 1'
```

### len()
```
>>> len("andré Nevares")
13
```

### string e multiplicação
```
>>> "andre" * 5
'andreandreandreandreandre'
```

```
>>> h = 'happy'
>>> b = 'birthday'
>>> (h + b) * 10
'happybirthdayhappybirthdayhappybirthdayhappybirthdayhappybirthdayhappybirthdayhappybirthdayhappybirthdayhappybirthdayhappybirthday'
```

```
>>> len((h + b) * 10)
130
```

### função print()
```
>>> print("Hello")
Hello
>>> "Hello"
'Hello'
>>> print("Hello")
Hello
>>> name
'Andre'
>>> print("Hello "+name)
Hello Andre
```


# if / else / elif

## Lógica comparativa

### Boolean Data
```
>>> True
True
>>> type(True)
<class 'bool'>
```

```
>>> False
False
>>> type(False)
<class 'bool'>
```

### Comparando em python...

#### Sinal de igualdade
```
>>> 0 == 0
True
>>> 0 == 1
False

```

#### Diferença entre ```=``` e ```==```
```
>>> x = 4
>>> x
4
>>> x == 4
True
```
> Observação: ```=``` representa atribuição.  Exemplo quando atribuímos a uma variável um valor, uma string... ```idade = 21```
> Observação: ```==``` representa igualdade.  Exemplo ```21 == 21```  o resultado será ```True```


#### Sinal de diferença
```
>>> 0 != 1
True
```

#### Python é case sensitive
```
>>> "a" == "A"
False

>>> print("Python is case sensitive!")
Python is case sensitive!
```
#### Maior ou igual ```>=``` e Menor ou Igual ```<=```
```
>>> 1 > 0
True
>>> 2 >=3
False
>>> -1 <= 1
True
>>> .5 <= -2
False
```

#### in
```
>>> "H" in "Hello"
True
```
#### not in
```
>>> "X" not in "Hello"
True
```

#### True vs. true
```
>>> true
Traceback (most recent call last):
  File "<stdin>", line 1, in <module>
NameError: name 'true' is not defined
>>> Type("true")
Traceback (most recent call last):
  File "<stdin>", line 1, in <module>
NameError: name 'Type' is not defined
>>> type("true")
<class 'str'>
>>> type(true)
Traceback (most recent call last):
  File "<stdin>", line 1, in <module>
NameError: name 'true' is not defined
>>> type(True)
<class 'bool'>
```

## If
```
>>> if 6 > 5:
...     print("Seis é maior que cinco")
...
Seis é maior que cinco
```

```
>>> if 0>2:
...     print("0 é maior que 2")
... else:
...     print("0 é menor que 2")
...
0 é menor que 2
```

```
>>> if "banana" in "chiclete com banana":
...     print("ok")
... else:
...     print("não")
...
ok
```

```
>>> sister = 15
>>> brother = 12
>>> if sister > brother:
...     print("A irmã é mais velha")
... else:
...     print("O irmão é mais velho")
...
A irmã é mais velha
```

#### and

``` 
>>> x=1
>>> x > 0 and x < 2
True
```

```
>>> 1 < 2 and 5 > 3
True
```

```
>>> 1 > 2 and 5 > 3
False
```

#### or
```
>>> x > 0 or x < 2
True
```
```
>>> 1 > 2 or  5>3
True
```

## If / else
```
>>> temp = 41
>>> if temp > 20 and temp < 34:
...     print("A temperatura está agradável")
... else:
...     print("A temperatura está muito quente")
...
A temperatura está muito quente
```
## If / elif / else
```
>>> sister = 15
>>> brother = 15
>>> if sister > brother:
...       print("A irmã é mais velha")
... elif brother < sister:
...      print("O irmão é mais velho")
... else:
...     print("Ambos tem a mesma idade!")
...
Ambos tem a mesma idade!
```
