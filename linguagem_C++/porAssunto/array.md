# Array
- É um tipo de dado estático

## Estrutura do Array
```int nomeArray[3] = { 1, 2, 3 }```

## Posição do Array
Para fazermos referância ao __array__ nós temos que especificar a ´posição iniciando por zero.

- A primeira posição será 0

Exemplo:
```//Array

#include <iostream>
using namespace std;

int
main ()
{
    int nomeArray[3] = { 1, 2, 3 };
    cout << nomeArray[1] << endl;
    cout << nomeArray[2] << endl;
    cout << nomeArray[3] << endl;

  return 0;
}

```

## Definindo Array ao longo do código

```
#include <iostream>

using namespace std;

int main () {
    
    int nomeArray[3];
    
    nomeArray[0] = 10;
    nomeArray[1] = 200;
    nomeArray[2] = 400;
   
    cout << nomeArray[0] << endl;
    cout << nomeArray[1] << endl;
    cout << nomeArray[2] << endl;

  return 0;
}
```

## Atualizando valores de Array

```
#include <iostream>

using namespace std;

int main () {
    
    int nomeArray[3];
    
    nomeArray[0] = 10;
    nomeArray[1] = 200;
    nomeArray[2] = 400;
    
    nomeArray[0] = 10000;
    
    cout << nomeArray[0] << endl;
    cout << nomeArray[1] << endl;
    cout << nomeArray[2] << endl;

  return 0;
}
```

## Array float

```
//Array

#include <iostream>

using namespace std;

int main () {
    
    float nomeArray[3];
    
    nomeArray[0] = 10.1;
    nomeArray[1] = 20.3;
    nomeArray[2] = 30.4;

    cout << nomeArray[0] << endl;
    cout << nomeArray[1] << endl;
    cout << nomeArray[2] << endl;

  return 0;
}
```

## Array string

```
#include <iostream>
#include <string.h>

using namespace std;

int main () {
    
    string minions[3];
    
    minions[0] = "Bob";
    minions[1] = "Stewart";
    minions[2] = "Kevin";

    cout << minions[0] << endl;
    cout << minions[1] << endl;
    cout << minions[2] << endl;

  return 0;
}

```

## Array com elementos a mais

Digamos, por exemplo, que venhamos a definir um array de tamananho três. Só que no meio do código, esquecemos o nosso tamanho e adicionamos um quarto elemento.  O que será que acontece?  

O resultado será que o código restará corrompido.  Dessa forma o array não terá nenhuma saida.

### Vide exemplo: com erro


```
#include <iostream>
#include <string.h>

using namespace std;

int main () {
    
    string minions[3];
    
    minions[0] = "Minion Bob";
    minions[1] = "Minion Stewart";
    minions[2] = "Minion Kevin";
    minions[3] = "Minion Dave";

    cout << minions[0] << endl;
    cout << minions[1] << endl;
    cout << minions[2] << endl;
    cout << minions[3] << endl;
    
  return 0;
}
```

Saída será:

```
Segment fault 

... Program finhed with exit code 139
```


### Corrigindo o erro

```
#include <iostream>
#include <string.h>

using namespace std;

int main () {
    
    string minions[4];
    
    minions[0] = "Minion Bob";
    minions[1] = "Minion Stewart";
    minions[2] = "Minion Kevin";
    minions[3] = "Minion Dave";

    cout << minions[0] << endl;
    cout << minions[1] << endl;
    cout << minions[2] << endl;
    cout << minions[3] << endl;
    
  return 0;
}
```

## Array 2D
- Esse tipo de array temos linhas e colunas;
- 3 x 3 - 3 linhas e 3 colunas;
- 4 x 2 - 4 linhas e 2 colunas;
- 2 x 3 - 2 linhas e 3 colunas;

```int meuArray2D[numero_de_linhas][numero_de_colunas]```

#### passo 1 defino o tipo de dado do meu array
```int meuArray2D[3][3] = {{} {} {}}```
#### passo 2 determino a estrutura da matriz
```int meuArray2D[3][3] = {{} {} {}}```
#### passo 3 coloco a estrutura
```int meuArray2D[3][3] = {{} {} {}}```
#### passo 4 coloco os dados
```int meuArray2D[3][3] = {{} {} {}}```


