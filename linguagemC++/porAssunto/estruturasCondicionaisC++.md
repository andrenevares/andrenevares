# Estuturas Condicionais

- C++ Condições e declarações If


####  C++ suporta as condições lógicas usuais da matemática:
- menor que: ```a < b```
- menor ou igual a: ```a <= b```
- maior que: ```a > b```
- maior ou igual a : ```a >= b```
- igual ```a == b```
- Diferente: ```a != b```


#### C++ possui as seguintes instruções condicionais:

- Use a condição ```if```  para especificar um bloco de código a ser executado, se uma condição especificada for verdadeira
- Use ```else``` para especificar um bloco de código a ser executado, se a mesma condição for falsa
- Use ```else if``` para especificar uma nova condição para testar, se a primeira condição for falsa
- Use ```switch``` para especificar muitos blocos alternativos de código a serem executados

## if
> Exemplo 01 - Sem variáveis
```
if (10 > 2) {
  cout << "10 é maior que 2";
}
```

> Exemplo 02 - Com variáveis
```
int x = 50;
int y = 10;
if (x > y) {
  cout << "x é maior que y";
}
```

## else 

```
int horaDoDia = 20;
if (horaDoDia < 18) {
  cout << "Está de dia!.";
} else {
  cout << "Está de noite!";
}
// Saída "Está de noite!"
```


## else if

```
int time = 22;
if (time < 12) {
  cout << "Bom dia!!!";
} else if (time < 18) {
  cout << "Boa tarde!";
} else {
  cout << "Boa noite!";
}
// Resultado "Boa noite!"
```
