#include <iostream>
#include <cmath>

using namespace std;

int main() {
  float salario, salarioLiquido;
  int opcaoMes, anoReferencia;
  char nome[15], sobrenome[15];
  int mes=0;

  // Variáveis INSS
  float inssEmpregado;
  int aliquotaInss;

  // Variáveis IR
  float baseCalculoIr, deducao, irARecolher;
  float aliquotaIr5, aliquotaIr4, aliquotaIr3, aliquotaIr2, aliquotaIr1, aliquotaIr;
  float descontoIr5, descontoIr4, descontoIr3, descontoIr2, descontoIr1, descontoIr;
  
  int faixaIr;
  
        // Variáveis FGTS
  float fgts;

  // Zerando as variáveis que podem conter valores e evitar erros
  faixaIr = aliquotaInss = baseCalculoIr = deducao = irARecolher = 0; 

  // Área de Configuração de alíquotas 
  aliquotaIr5 = 0.275;
  aliquotaIr4 = 0.225;
  aliquotaIr3 = 0.15;      
  aliquotaIr2 = 0.075;      
  aliquotaIr1 = 0 ;

  
  // Área de Configuração de descontos por faixas;
  descontoIr5 = 869.36;
  descontoIr4 = 636.13;      
  descontoIr3 = 354.80;      
  descontoIr2 = 142.80;
  descontoIr1 = 0;
  

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
  
    // Cálculo de IR https://www.debit.com.br/tabelas/tabelas-irrf.php
    if (salario <= 0) {
      cout << "Salário necessita ser um valor menor que zero";        
  } else if (salario > 4664.68) {
      descontoIr = descontoIr5;
      aliquotaIr = aliquotaIr5;
      faixaIr = 5;
  } else if (salario >= 3751.06) {
      descontoIr = descontoIr4;
      aliquotaIr = aliquotaIr4;
      faixaIr = 4;
  } else if (salario >= 2826.66) {
      descontoIr = descontoIr3;
      aliquotaIr = aliquotaIr3;
      faixaIr = 3;
  } else if (salario > 1903.99) {
      descontoIr = descontoIr2;
      aliquotaIr = aliquotaIr2;
      faixaIr = 2;

  } else if (salario <= 1903.98) {
      descontoIr = descontoIr1;
      aliquotaIr = aliquotaIr1;
      faixaIr = 1;
  }

  irARecolher = (baseCalculoIr * aliquotaIr) - descontoIr;  

  // Cálculo fgts
  fgts = 0.08 * salario;

  // Cálculo total dos descontos
  salarioLiquido = salario - irARecolher - inssEmpregado;
  
  
  cout << "\n\n";
  cout << "***************************************************" << endl;
  cout << "*    ZE DAS COUVES LTDA - 72.503.000/0001-15     **" << endl;
  cout << "***************************************************" << endl;
  system("pause");
  cout << "\n";
  cout << "Funcionário: " << nome <<" "<<sobrenome << endl;
  cout << "Cargo: Desenvolvedor Júnior" << endl;
  if (mes==1){
      cout << "Mês de referência:  Janeiro de " << anoReferencia << endl;
      
    } else if (mes==2) {
        cout << "Mês de referência:  Fevereiro de " << anoReferencia << endl;
        
    } else if (mes==3) {
        cout << "Mês de referência:  Marco de " << anoReferencia << endl;
    } else if(mes==4) {
        cout << "Mês de referência:  Abril de " << anoReferencia << endl;
    } else if(mes==5) {
        cout << "Mês de referência:  Maio de " << anoReferencia << endl;
    } else if(mes==6) {
        cout << "Mês de referência:  Junho de " << anoReferencia << endl;
    } else if(mes==7) {
        cout << "Mês de referência:  Julho de " << anoReferencia << endl;
    } else if(mes==8) {
        cout << "Mês de referência:  Agosto de " << anoReferencia << endl;
    } else if(mes==9) {
        cout << "Mês de referência:  Setembro de " << anoReferencia << endl;
    } else if(mes==10) {
        cout << "Mês de referência:  Outubro de " << anoReferencia << endl;
    } else if(mes==11) {
        cout << "Mês de referência:  Novembro de " << anoReferencia << endl;
    } else if(mes==12) {
        cout << "Mês de referência:  Dezembro de " << anoReferencia << endl;
    }
  cout << "\n";
  cout << "Base de Cálculo IR......................... R$ " << baseCalculoIr << endl;
  cout << "\n";
  cout << "1. Salário Bruto........................... R$ " << salario << endl;
  // usando a biblioteca <cmath> 
  cout << "2. (-) IR do empregado (Faixa 0" << faixaIr <<  ") ......... R$ " << floorf(baseCalculoIr*100)/100 << endl; 
  cout << "3. (-) INSS Empregado (Alíquota " << aliquotaInss << "%)....... R$ " << inssEmpregado << endl;
  cout << "-------------------------------------------------------" << endl;
  cout << "4. = Salário Líquido....................... R$ " << salarioLiquido << endl;
  cout << "\n";
  cout << "\n";
  cout << "-------------------------------------------------------" << endl;
  cout << "\n";
  cout << "Total dos Vencimentos...................... R$ " << salario << endl;
  // usando a biblioteca <cmath> 
  cout << "Total dos Descontos........................ R$ " << floorf((irARecolher + inssEmpregado)*100)/100 << endl;
  cout << "Valor Líquido.............................. R$ " << salarioLiquido << endl;
  cout << "\n";
  cout << "-------------------------------------------------------" << endl;
  cout << "\n";
  cout << "Salário Base............................... R$ " << salario << endl;
  cout << "Sal. Contribuição INSS..................... R$ " << salario << endl;
  cout << "Base de Cálculo FGTS....................... R$ " << salario << endl;
  cout << "FGTS do mês................................ R$ " << fgts << endl;
  cout << "Base de Cálculo IRPF....................... R$ " << baseCalculoIr << endl;
  cout << "Faixa IRPF................................. R$ " << faixaIr << endl;
  system("pause");
}
 
