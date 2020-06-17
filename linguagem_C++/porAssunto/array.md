# Array

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
