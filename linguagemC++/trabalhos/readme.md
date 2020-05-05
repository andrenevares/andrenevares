```
#include <iostream>
using namespace std;

int main() {
    float salario;
    // -----------------------------------------
    // -------- Início Configurações de IR  ----
    // -----------------------------------------
    float deducaoIrFaixa1, deducaoIrFaixa2, deducaoIrFaixa3, deducaoIrFaixa4, deducaoIrFaixa5;
    float bcIr1, bcIr2, bcIr3, bcIr4, bcIr5;
    float irpf1, irpf2, irpf3, irpf4, irpf5, irpfTotal;
    
    deducaoIrFaixa1 = 0;
    deducaoIrFaixa2 = 142.8;
    deducaoIrFaixa3 = 354.8;
    deducaoIrFaixa4 = 636.13;
    deducaoIrFaixa5 = 869.36;

    // -----------------------------------------
    // -------- Início Configurações de IR  ----
    // -----------------------------------------
    
    cout << "Digite o valor do salário bruto?... ";
    cin >> salario;

    if (salario <= 0) {
        cout << "Salário necessita ser um valor menor que zero";        
    } else if (salario > 4664.68) {
        bcIr5 = salario - 4664.68;
        irpf5 = (bcIr5 * 0.275);
        bcIr4 = 4664.67 - 3751.06;
        irpf4 = (bcIr4 * 0.225);
        bcIr3 = 3751.05 - 2826.66;
        irpf3 = (bcIr3 * 0.15);
        bcIr2 = 2826.65 - 1903.99;
        irpf2 = (bcIr2 * 0.075);
        bcIr1 = 0;
        irpf1 = 0;      
    } else if (salario >= 3751.06) {
        bcIr4 = salario - 3751.06;
        irpf4 = (bcIr4 * 0.225);
        bcIr3 = 3751.05 - 2826.66;
        irpf3 = (bcIr3 * 0.15);
        bcIr2 = 2826.65 - 1903.99;
        irpf2 = (bcIr2 * 0.075);
        bcIr1 = 0;
        irpf1 = 0;      
    } else if (salario >= 2826.66) {
        bcIr3 = salario - 2826.66;
        irpf3 = (bcIr3 * 0.15);
        bcIr2 = 2826.65 - 1903.99;
        irpf2 = (bcIr2 * 0.075);
        bcIr1 = 0;
        irpf1 = 0;
    } else if (salario > 1903.99) {
        bcIr2 = salario - 1903.99;
        irpf2 = (bcIr2 * 0.075);
        bcIr1 = 0;
        irpf1 = 0;
    } else if (salario <= 1903.98) {
        bcIr1 = 0;
        irpf1 = 0;
    }
    
    irpfTotal = irpf1 + irpf2 + irpf3 + irpf4 + irpf5;
    cout << "Importo de Renda: " << irpfTotal;

}
```
