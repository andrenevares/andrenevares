#include <stdio.h>

int main()
{
    float salario, indice, salarioReajustado;
    
    indice = 0.30;
    printf("Programa de Cálculo de Reajuste de Salários\n\n");
    
    printf("Por favor insira o seu salário:..");
    scanf("%f", &salario);
    
    if (salario >= 500.00) {
        printf("Seu salário está acima do limite colocado para reajuste!\n");
        printf("Seu salário continuará a ser de R$%.2f", salario);
    }
    else if (salario < 0){
        printf("Salários não podem ter valor negativo!\n");
        printf("Por favor, tente novamente");
    }
    else {
        salarioReajustado = salario * (1.0 + indice);
        printf("Seu salário de R$%.2f foi reajustado para R$%.2f", salario, salarioReajustado);
    }
}
