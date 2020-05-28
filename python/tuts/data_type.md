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
