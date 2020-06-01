

```
se ( B*C <= 20 e A*2 > C) então
    x recebe o valor de  B * C + C * (A+ B)
senão
    x  recebe o valor de (A + B * C) – (C /2)
fim se
escreva (x);
```
Considerando
- A = 2
- B = 5
- C = 4
- D = 3 

Substituindo 01
```
se ( 5 * 4 <= 20 e 2 * 2 > 4) então
    x recebe o valor de  5 * 4 + 4 * (2 + 5)
senão
    x  recebe o valor de (2 + 5 * C) – (C /2)
fim se
escreva (x);
```


- Analisando o SE verificamos que 20 de fato é menor ou igual a 20
- No entanto 4 > 4 é FALSO ... 
- Como ambos os valores necessitam ser verdadeiros para entrar em SE , deveremos ir ao bloco se não
```
se ( 20 <= 20 e 4 > 4) então
    x recebe o valor de  5 * 4 + 4 * (2 + 5)
senão
    x  recebe o valor de (2 + 5 * 4) – (4 /2)
fim se
escreva (x);
```

- Analisando o SE verificamos que 20 de fato é menor ou igual a 20
- No entanto 4 > 4 é FALSO ... 
- Como ambos os valores necessitam ser verdadeiros para entrar em SE , deveremos ir ao bloco se não
```
x  recebe o valor de (2 + 5 * 4) – (4 /2)
x  recebe o valor de (2 + 20) – (2)
x recebe o valor de 22 – 2
x recebe o valor de 20
```
