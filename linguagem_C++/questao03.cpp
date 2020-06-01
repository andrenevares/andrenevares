#include <iostream>
using namespace std;

int main() {
    float comprasTotal, cotacaoDolar, totalPontos;
    
    cout << "Qual o valor das compras ? ";
    cin >> comprasTotal;
    cout << "Qual a cotação do dólar? ";
    cin >> cotacaoDolar;
    totalPontos = (comprasTotal * 0.05) / cotacaoDolar;
    cout << "\nO valor total de pontos adquiridos foi de: " << totalPontos;
}
