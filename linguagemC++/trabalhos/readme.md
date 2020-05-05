# Trabalho AV1

```
#include <iostream>
using namespace std;

int main() {
    float salario, salarioLiquido;
    int opcaoMes, anoReferencia;
    char nome[15], sobrenome[15];
    int mes = 0;
    
    // Variáveis INSS
    float inssEmpregado;
    int aliquotaInss;
    
    // Variáveis IR
    float baseCalculoIr, bcIr1, bcIr2, bcIr3, bcIr4, bcIr5;
    float irpf1, irpf2, irpf3, irpf4, irpf5, irpfTotalEmpregado;
    int faixaIr;
    
    // Variáveis FGTS
    float fgts;

    // Zerando as variáveis que podem conter valores e evitar erros
    faixaIr = aliquotaInss = inssEmpregado = irpf1 = irpf2 = irpf3 = irpf4 = irpf5 = 0; 
    
    // Atribuindo variáveis teste.
    
    cout << "Digite o primeiro nome do funcionário sem espaço... ";
    cin >> nome;
    cout << "Digite o primeiro sobrenome do funcionário sem espaço... ";
    cin >> sobrenome;
    cout << "\n\n";
    
    cout << "Digite o mês de referência 1 a 12... ";
    cin >> mes;
    cout << "Digite o ano de referência Ex. 2011... ";
    cin >> anoReferencia;
    
    cout << "Digite o valor do salário bruto?... ";
    cin >> salario;


    // Primeiro Calculamos o INSS 
    if (salario <= 0) {
        cout << "Salário necessita ser um valor menor que zero";        
    } else if (salario <= 1556.94 ) {
        inssEmpregado = 0.08 * salario;
        aliquotaInss = 8;
    } else if (salario <= 2594.92 ) {
        inssEmpregado = 0.09 * salario;
        aliquotaInss = 9;
    } else if (salario <= 5189.82 ) {
        inssEmpregado = 0.11 * salario;
        aliquotaInss = 11;
    } else if (salario > 5189.82 ) {
        // Limitado a 11% do limite superior 
        inssEmpregado = 0.11 * 5189.82;
        aliquotaInss = 11;
    }

    baseCalculoIr = salario - inssEmpregado;
    
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
        faixaIr = 5;
    } else if (salario >= 3751.06) {
        bcIr4 = salario - 3751.06;
        irpf4 = (bcIr4 * 0.225);
        bcIr3 = 3751.05 - 2826.66;
        irpf3 = (bcIr3 * 0.15);
        bcIr2 = 2826.65 - 1903.99;
        irpf2 = (bcIr2 * 0.075);
        bcIr1 = 0;
        irpf1 = 0;
        faixaIr = 4;
    } else if (salario >= 2826.66) {
        bcIr3 = salario - 2826.66;
        irpf3 = (bcIr3 * 0.15);
        bcIr2 = 2826.65 - 1903.99;
        irpf2 = (bcIr2 * 0.075);
        bcIr1 = 0;
        irpf1 = 0;
        faixaIr = 3;
    } else if (salario > 1903.99) {
        bcIr2 = salario - 1903.99;
        irpf2 = (bcIr2 * 0.075);
        bcIr1 = 0;
        irpf1 = 0;
        faixaIr = 2;
    } else if (salario <= 1903.98) {
        bcIr1 = 0;
        irpf1 = 0;
        faixaIr = 1;
    }
   
    irpfTotalEmpregado = irpf1 + irpf2 + irpf3 + irpf4 + irpf5;

    // Cálculo fgts
    fgts = 0.08 * salario;
    
    // Cálculo total dos descontos
    salarioLiquido = salario - irpfTotalEmpregado - inssEmpregado;
    cout << "\n\n";
    cout << "*******************************************************" << endl;
    cout << "***    ZE DAS COUVES LTDA - 72.503.000/0001-15     ****" << endl;
    cout << "*******************************************************" << endl;
    system("pause");
    cout << "\n";
    cout << "Funcionário: " << nome << sobrenome << endl;
    cout << "Cargo: Desenvolvedor Júnior" << endl;
    cout << "Mês de redereência: " << mes << "/" << anoReferencia << endl;
    cout << "\n";
    cout << "Base de Cálculo IR......................... R$ " << baseCalculoIr << endl;
    cout << "\n";
    cout << "1. Salário Bruto........................... R$ " << salario << endl;
    cout << "2. (-) IR do empregado (Faixa 0" << faixaIr <<  ") ......... R$ " << irpfTotalEmpregado << endl;
    cout << "3. (-) INSS Empregado (Alíquota " << aliquotaInss << "%)....... R$ " << inssEmpregado << endl;
    cout << "-------------------------------------------------------" << endl;
    cout << "4. = Salário Líquido....................... R$ " << salarioLiquido << endl;
    cout << "\n";
    cout << "\n";
    cout << "-------------------------------------------------------" << endl;
    cout << "\n";
    cout << "Total dos Vencimentos...................... R$ " << salario << endl;
    cout << "Total dos Descontos........................ R$ " << irpfTotalEmpregado + inssEmpregado << endl;
    cout << "Valor Líquido.............................. R$ " << salarioLiquido << endl;
    cout << "\n";
    cout << "-------------------------------------------------------" << endl;
    cout << "\n";
    cout << "Salário Base............................... R$ " << endl;
    cout << "Sal. Contribuição INSS..................... R$ " << endl;
    cout << "Base de Cálculo FGTS....................... R$ " << endl;
    cout << "FGTS do mês................................ R$ " << fgts << endl;
    cout << "Base de Cálculo IRPF....................... R$ " << endl;
    cout << "Faixa IRPF................................. R$ " << endl;
}
```