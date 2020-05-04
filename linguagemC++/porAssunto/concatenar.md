# Concatenar em C++

## Concatenar Texto + valor de Variáveis.
Para concatenar um texto como ```"A nota do aluno é"``` com a variável ```notaAluno``` que representa a nota do aluno usaremos a seguinte sintaxe:

```
  cout << "A nota do aluno é" << notaAluno;
```

Desta forma o código poderia ser:
```
#include <iostream>
using namespace std;

int main()
{
    float notaAluno;
    cout << "Qual a nota do aluno? ";
    cin >> notaAluno;
    cout << "A nota do aluno é " << notaAluno;
    
}
```
