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
