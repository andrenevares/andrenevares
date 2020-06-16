# Exercício de Fatorial

## Trabalho
Faça um programa para calcular um número fatorial

## Resolução
```
// Criar um probrama que calcule qualquer número fatorial
// Exemplo:  5! = 5 x 4 x 3 x 2 x 1 = 120
#include <iostream>

using namespace std;

int main() {
    
    int numero, total;
    cout << "Cálculo de Fatorial" << endl;
    cout << "-------------------" << endl << endl;
    cout << "Digite n... ";

    cin >> numero;
    
    total = 1;
    for (int i = numero; i > 0; i-- ){
       // Bloco para imprimir os numeros da multuplicação
       if (i == numero){
           total = i * total;
           cout << numero << "! = " << i << " x ";
       } else if (i > 1) {
             total = i * total;
             cout << i << " x ";
       } else {
             total = i * total;
             cout << i << " = ";
       }
    }
    
    cout << total;
    return 0;
}
```
