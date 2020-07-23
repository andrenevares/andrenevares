# Lists

## Métodos:
| Method	| Description |
| - | - |
| append()	|  Adciona um elemento no final da lista | 
| clear()	| Apaga todos os elementos da lista | 
| copy()	| Retorna uma cópia da lista | 
| count()	| Retorna o nº de elementos com um valor específico | 
| extend()	| Adiciona os elementos de uma lista ao final da lista atual |
| index()	| Returns the index of the first element with the specified value |
| insert()	| Adciona um elemento em uma posição específica |
| pop()	| Remove o elemento de uma posição específica |
| remove()	| Remove o primeiro elemento com um determinado valor |
| reverse()	| Inverte a ordem de uma lista |
| sort()	| Sorts the list |
> Traduzido de [w3schools - python lists methods](https://www.w3schools.com/python/python_ref_list.asp)

```times = ["Fluminense", "Flamengo", "Vasco", "Botafogo"]```

para chamar o primeiro item de uma lista chamada ```times```

# Extraindo um dado de uma lista
```
times[0]
```

# Inserir dados em uma lista.
- lista.insert()

## Inserir dado em uma posição

sintaxe: 
```nome_da_lista(posição, o_que_vc_quer_colocar)```

Exemplo: em uma lista chamada times vamos inserir mais um time chamado de Sport:

```
times.insert(0,"Sport")
```

Resultado:

```times = ["Sport", "Fluminense", "Flamengo", "Vasco", "Botafogo"]```

## Deletar item de uma lista

Em uma lista chamadd times vamos apagar o Flamengo.

Podemos extrair pela posição
```
del(times[2])
```

## Len()

Imagine uma lista com ```times = ["Sport", "Fluminense", "Flamengo", "Vasco", "Botafogo"]```

Ela tem 5 times.

Para saber o tamanho de uma lista usamos ```len(nome_da_lista)```

No caso usaremos ```len(times)```

Resultado: 5

## Atualizar itens em uma lista

Imagine que eu só queira ter times cariocas em uma lista...

```
times = ["Sport", "Fluminense", "Flamengo", "Vasco", "Botafogo"]
```

Queremos trocar __Sport__ por __Bangu__

```
times[0] = "Bangu"
```


