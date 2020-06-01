#include <iostream>
using namespace std;

int main() {
    int tipoDeRefeicao, quantidadeDeBebidas, quantidadeDeSobremesa;
    float quantidadeEmGramas, quantidadeEmKg;
    float precoPorBebida, precoPorSobremesa, precoKgComChurrasco, precoKgSemChurrasco, precoComida;
    float valorCobrarComida, valorCobrarSobremesa, valorCobrarBebida, valorCobrarTotal;
    
    precoPorBebida = 3.8;
    precoPorSobremesa = 4.5;
    precoKgComChurrasco = 34.9;
    precoKgSemChurrasco = 28.9;
        
    cout << "Qual o tipo de refeição feita?" << endl;
    cout << "[ 1 ] Com Churrasco\n[ 2 ] Sem Churrasco" << endl;
    cout << "Selecione ...";
    cin >> tipoDeRefeicao;
    
    if (tipoDeRefeicao == 1){
        precoComida = precoKgComChurrasco;
        
    } else if (tipoDeRefeicao == 2) {
        precoComida = precoKgSemChurrasco;
    }  else {
        cout << "Valor incorreto" << endl;
    }
    
    cout << "Peso do prato em gramas.. ";
    cin >> quantidadeEmGramas;
    valorCobrarComida = precoComida * quantidadeEmGramas / 1000;
    
    cout << "\nConsumo de bebidas (qtd).. ";
    cin >> quantidadeDeBebidas;
    valorCobrarBebida = precoPorBebida * quantidadeDeBebidas;
    
    cout << "Consumo de sobremesa (qtd).. ";
    cin >> quantidadeDeSobremesa;
    valorCobrarSobremesa = precoPorSobremesa * quantidadeDeSobremesa;
    
    valorCobrarTotal = valorCobrarComida + valorCobrarSobremesa + valorCobrarSobremesa;
    cout << "\n\n------------------------------ " << endl;
    cout << "Restaurante Quilo Come de Tudo" << endl;
    cout << "------------------------------ " << endl;
    cout << "\n\nRefeição............... R$" << valorCobrarComida << endl;
    cout << "Sobremesa.............. R$" << valorCobrarSobremesa << endl;
    cout << "Bebida................. R$" << valorCobrarBebida << endl;
    cout << "------------------------------ " << endl;
    cout << "Total.................. R$" << valorCobrarTotal << endl;
    
}
    
