# Lists

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
