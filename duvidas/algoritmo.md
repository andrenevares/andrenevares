# Dúvida em questão de algoritmo

```
Decide-Rec (A, n, x)

se n = 0
  então devolva não
  senão se A[n] = x
    então devolva sim
    senão devolva Decide-Rec (A, n-1, x)
``` 

Com base no algoritmo apresentado acima, julgue o item seguinte.


## 61763997
O algoritmo é recursivo e pode ter problemas de execução ao ser implementado quando n < 0.

- Resposta: CERTA


## 61763997
O algoritmo devolve sim se x está em A[1..n-1] e, caso contrário, devolve não.

- Resposta: ERRADA
