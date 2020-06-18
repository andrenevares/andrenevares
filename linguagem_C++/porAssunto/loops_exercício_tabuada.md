# Exercício de Tabuada

## Problema
Faça um programa em C++ que solicite um número para o usuário, e ele retorne os valores da tabuada

## Solução
```
// Tabuada
#include <iostream>

using namespace std;

int main() {
    int numero, i, resultado;
    cout << "Qual o número? ";
    cin >> numero;
    i = 1;
    while (i <=10) {
        resultado = numero * i;
        cout << numero << " x " << i << " = " << resultado << endl;
        i++;
    }

    return 0;
}
```
