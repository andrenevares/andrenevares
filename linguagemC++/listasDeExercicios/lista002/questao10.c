#include <stdio.h>

int main()
{
    // VARIABLES
    float price, custo;
    
    printf("Faça um programa que receba o custo de fábrica de um carro e mostre o preço ao consumidor.\n\n");
    printf("Qual o custo da fabrica?.. ");
    scanf("%f", &custo);
    printf("-----------------------------\n\n");
    
    if (custo > 25000.00) {
        price = custo * 1.35;
        printf("O preco final ao consumidor é de R$%.2f", price);
    }
    
    else if (custo > 12000.00) {
        price = custo*1.25;
        printf("O preco final ao consumidor é de R$%.2f", price);
    }
    else if (custo > 0) {
        price = custo*1.05;
        printf("O preco final ao consumidor é de R$%.2f", price);
    }
    return 0;
}
