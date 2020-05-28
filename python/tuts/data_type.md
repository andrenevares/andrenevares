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

# List


```
>>> your_list = ["a", "b", "c"]
>>> your_list
['a', 'b', 'c']
```

```
>>> type(your_list)
<class 'list'>
```

```
>>> len(your_list)
3
```

```
>>> "a" in your_list
True

>>> "z" in your_list
False
```

```
>>> "z" not in your_list
True
```

```
>>> your_list[0]
'a'
>>> your_list[1]
'b'
>>> your_list[2]
'c'
```

```
>>> your_list[3]
Traceback (most recent call last):
  File "<stdin>", line 1, in <module>
IndexError: list index out of range
```

```
>>> your_list[-1]
'c'
>>> your_list[-2]
'b'
```

```
>>> your_list.append("d")
>>> your_list
['a', 'b', 'c', 'd']
```

```
>>> her_list = []
>>> len(her_list)
0
```

```
>>> names =['slash', 'Axl']
>>> names.append('izzy', 'duff', 'steve')
Traceback (most recent call last):
  File "<stdin>", line 1, in <module>
TypeError: append() takes exactly one argument (3 given)
>>> names.appends('izzy', 'duff', 'steve')
Traceback (most recent call last):
  File "<stdin>", line 1, in <module>
AttributeError: 'list' object has no attribute 'appends'
```

```
>>> names.append( 'steve')
>>> names
['slash', 'Axl', 'steve']
```

```
>>> names[2]
'steve'
```

```
>>> names[2] = 'jimmy'
>>> names
['slash', 'Axl', 'jimmy']
```
```
>>> names.append( 'bob')
>>> names.append('andrew')
>>> names.append('leo')
>>> names
['slash', 'Axl', 'jimmy', 'bob', 'andrew', 'leo']
```

```
>>> len(names) - 1
5
```

```
>>> names[len(names) - 1 ]
'leo'
```

```
>>> names[-1]
'leo'
>>> names[-2]
'andrew'
```

```
>>> my_name = "André"
```


```
>>> my_name
'André'
```

```
>>> my_name[0]
'A'
>>> my_name[1]
'n'
>>> my_name[2]
'd'
>>> my_name[3]
'r'
>>> my_name[4]
'é'
```

```
>>> names
['slash', 'Axl', 'jimmy', 'bob', 'andrew', 'leo']
```

```
>>> names.reverse()
```

```
['leo', 'andrew', 'bob', 'jimmy', 'Axl', 'slash']
```
>>> names.sort()
>>> names
['Axl', 'andrew', 'bob', 'jimmy', 'leo', 'slash']


```
>>> names.insert(0, 'izzy')
>>> names
['izzy', 'slash', 'axl', ' jimmy', 'bob', 'leo']
```

```
>>> names.insert(2,'dizzy')
>>> names
['izzy', 'slash', 'dizzy', 'axl', ' jimmy', 'bob', 'leo']
```

```
>>> names.remove('leo')
```

```
>>> names
['izzy', 'slash', 'dizzy', 'axl', ' jimmy', 'bob']
```

```
>>> names.remove('izzy')
```
```
>>> names
['slash', 'dizzy', 'axl', ' jimmy', 'bob']
```

```
>>> names.append('bob')
>>> names.append('bob')
>>> names.append('bob')
```
```
>>> names
```
```
['slash', 'dizzy', 'axl', ' jimmy', 'bob', 'bob', 'bob', 'bob']
```

# Loops

Criemos uma lista de nomes
```
>>> names = ['andre', 'camila', 'rafael', 'sookie', 'nina']
```

Se eu quiser imprimir cada nome
```
>>> for name in names:
...     print(name)
```
```
andre
camila
rafael
sookie
nina
```

Veja que a variável antes chamada de nome poderia ser, por exemplo, x
```
>>> for x in names:
...     print(x)
...
andre
camila
rafael
sookie
nina
```

Ou poderia ser a palavre ```word``` concatenada com ```Olá```
```
>>> for word in names:
...     print("Olá " + word)
...
Olá andre
Olá camila
Olá rafael
Olá sookie
Olá nina
```

E se quisessemos imprimir somente os nomes que começam com uma vogal?

Como poderíamos fazer?


Vamos definir primeiro uma variável ```name```
```
>>> name = "andré"
>>> name
'andré'
```

Para pegar a primeira letra da variável ```name``` basta usarmos ```name[0]``` certo?

Existem duas maneiras de fazer isso!

Maneira 01 - Verificando se está dentro de uma lista de caracateres tipo string
```
>>> name[0] in ['a', 'b', 'c', 'd', 'e']
True
```
Maneira 02 - MELHOR - colocar uma string com todos os dados que você queira 
- Afinal uma ```string``` é uma sequência de caracteres!
```
>>> name[0] in "aeiou"
True
```

Agora basta colocar dentro do for...
```
>>> for name in names: 
...     if name[0] in "aeiou":
...             print(name + " começa com uma vogal")
...
andre começa com uma vogal
```

E se eu quisesse fazer uma lista com os nomes que começam com uma vogal?
```
>>> vowel_names = []
>>> for name in names:
...     if name[0] in "aeiou":
...             vowel_names.append(name)
```

Ao chamar a lista, no nosso caso, deveremos ter um nome apenas...  Na nossa lista apenas ```andré``` começa com uma vogal
```
>>> vowel_names
['andre']
```

E se quisessemos calcular a soma de todos os valores de uma lista de preços

```
>>> prices = [1.5, 2.35, 8.0, 7.58, 356.57]
```

```
>>> total = 0
>>> for price in prices:
...     total = total + price
```

```
>>> total
376.0
```

Graças a deus alguém já criou uma função dessas... Com uma linha de código resolvemos o nosso problema!
```
>>> sum(prices)
376.0
```
