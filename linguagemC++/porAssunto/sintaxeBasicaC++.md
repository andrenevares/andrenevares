# Sintaxe básica de C++

## Olá Mundo!

```
#include <iostream>
using namespace std;

int main() {
  cout << "Olá Mundo!";
  return 0;
}
```

**Linha 01:** ```#include <iostream>``` define a biblioteca que permite usarmos elementos de saída, como o ```cout```  !

**Linha 02:** ```using namespace std;``` permite que usemos nomes e variéveis da biblioteca padrão  !

**Linha 03:**  C++ ignora espaços em branco;

**Linha 04:**  uma coisa que iremos sempre ver em C++ é a declaração ```int main() ```.  É o que chamamos de função.  Todo o código dentro dos semicolchetes ``` {} ``` será executado!



## Olá mundo (sem ```using namespace```)

Você poderá ver códigos em C++ sem ```using namespace std;```.    Nesse caso temos que usar a sintaxe ```std::```.

```
#include <iostream>

int main() {
  std::cout << "Hello World!";
  return 0;
}
```


