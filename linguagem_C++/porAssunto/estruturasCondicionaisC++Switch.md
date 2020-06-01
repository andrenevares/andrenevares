# Condicionais - SWITCH - C++

Ao usar a função ```switch``` temos que ter alguns cuidados
- declarar o tipo de variácel que for ser tratada como opção do ```switch``` com ```int```
- não esquecer de a cada ```case``` colocar o respectivo break
]
#### Sintax Básica do Switch
```
#include <iostream>
using namespace std;

int main() {
    int opcao;
    cout << "Digite um número referente a um mês de 1 a 12... ";
    cin >> opcao;
    switch (opcao) {
        case 1:
            cout << "bla bla bla";
            break;
    }
}
```

#### Exemplo selecinando mês
```
#include <iostream>
using namespace std;

int main() {
    int opcao;
    cout << "Digite um número referente a um mês de 1 a 12... ";
    cin >> opcao;
    switch (opcao) {
        case 1:
            cout << "\n Janeiro";
            break;
        case 2:
            cout << "\n Fevereiro";
            break;
        case 3:
            cout << "\n Março";
            break;
        case 4:
            cout << "\n Abril";
            break;
        case 5:
            cout << "\n Maio";
            break;
        case 6:
            cout << "\n Junho";
            break;
        case 7:
            cout << "\n Julho";
            break;
        case 8:
            cout << "\n Agosto";
            break;
        case 9:
            cout << "\n Setembro";
            break;
        case 10:
            cout << "\n Outubro";
            break;
        case 11:
            cout << "\n Novembro";
            break;
        case 12:
            cout << "\n Dezembro";
            break;
    }
}
```
