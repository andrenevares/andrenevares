# Operadores em C

A linguagem c/c++ possui operadores e funções predefinidas destinados a cálculos matemáticos. Alguns são apresentados a seguir.

## Operadores Matemáticos
| Operador | Exemplo | Comentário |
|   :-:   | :-:   | :-:   |
|  ``` = ```    | ``` x = y ```  | O conteúdo da variável Y é atribuído à variável X (A uma variável pode ser atribuído o conteúdo de outra, um valor constante ou, ainda, o resultado de uma função).
| ``` + ``` | ``` x + y ``` | soma o conteúdo de X e de Y. |
| ``` − ``` | ``` x − y ``` | subtrai o conteúdo de Y do conteúdo de X. |
| ``` * ``` | ``` x * y ```  | Multiplica o conteúdo de X pelo conteúdo de Y.|
| ``` / ``` | ``` x / y ``` | Resultado da divisão de X por Y.  Se ambas são inteiros, o resultado será a parte inteira, assim, para duas variáveis tipo INT ```  5 / 2 = 2 ```  |
| ``` % ``` | ``` x % y ``` |  Obtém o resto da divisão de X por Y. |

## Outros Operadores 

| Operador | Exemplo | Equivale a  |
|   :-:   | :-:   | :-:   |
|``` += ``` | ``` x += y ``` | ``` X = X + Y ``` |
|``` –= ``` | ``` x –= y ``` |``` X = X – Y ``` |
|``` *= ``` | ``` x *= y ``` |``` X = X * Y``` |
|``` /= ``` | ``` x /= y ``` |``` X = X / Y ``` |
|``` %= ``` | ``` x %= y ``` | ``` X = X % Y ``` |
|``` ++ ``` | ``` x++ ``` | ``` X = X + 1 ``` |
|``` ++ ``` | ``` y = ++x ``` | ```  X = X + 1 ``` e depois ``` Y = X ``` |
|``` ++ ``` | ``` y = x++ ``` | ``` Y = X ``` e depois ``` X = X +1 ``` |
|``` –– –– ``` |``` x–– –– ``` | ``` X = X – 1 ``` |
|``` – – ``` | ``` y = – –x ``` | ```  X = X – 1 ``` e depois ``` Y = X ``` |
|``` – – ``` |``` y = x– – ``` | ```  Y = X ``` e depois ``` X = X – 1 ``` |

## Operadores de Atribuição

| Operador | Exemplo |  Comentário| 
|   :-:   | :-:   | :-:   |
| ```== x``` | ```== y``` | O conteúdo de X é igual ao conteúdo de Y.| 
| ```!= x``` | ```!= y``` | O conteúdo de X é diferente do conteúdo de Y.| 
| ```<= x``` | ```<= y``` | O conteúdo de X é menor ou igual ao conteúdo de Y.| 
| ```>= x``` | ```>= y``` | O conteúdo de X é maior ou igual ao conteúdo de Y.| 
| ```< x``` | ```< y``` | O conteúdo de X é menor que o conteúdo de Y.| 
| ```> x``` | ```> y``` | O conteúdo de X é maior que o conteúdo de Y| 


## Funções Matemáticas em C


| Função | Exemplo | Comentário |
|   :-:   | :-:   | :-:   |
| ``` ceil ``` | ``` ceil(X) ```  | Arredonda um número real para cima. Por exemplo, ceil(3.2) é 4. |
| ``` cos ``` | ``` cos(X) ``` | calcula o cosseno de X (X deve estar representado em radianos). |
|``` exp ```  | ``` exp(X) ``` | Obtém o logaritmo natural e elevado à potência X. |
|``` abs ``` |``` abs(X) ``` |Obtém o valor absoluto de X. |
|``` floor ``` | ``` floor(X) ``` |Arredonda um número real para baixo. Por exemplo, floor(3.2) é 3.|
|``` log ``` | ``` log(X) ``` | Obtém o logaritmo natural de X. |
|``` log10 ``` | ``` log10(X) ``` | Obtém o logaritmo de base 10 de X. |
|``` modf ``` | ``` z = modf(X,&Y) ``` |Decompõe o número real armazenado em X em duas partes: Y recebe a parte fracionária e z, a parte inteira do número.|
|``` pow ``` | ``` pow(X,Y) ``` |calcula a potência de X elevado a Y. |
|``` sin ``` | ``` sin(X) ``` | calcula o seno de X (X deve estar representado em radianos). |
|``` sqrt ``` | ``` sqrt(X) ``` | calcula a raiz quadrada de X. |
|``` tan ``` | ``` tan(X) ``` | calcula a tangente de X (X deve estar representado em radianos).|
