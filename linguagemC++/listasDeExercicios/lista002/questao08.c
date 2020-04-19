#include <stdio.h>

int main()
{
    float salario, indiceAteTrezentos, indiceAcimaTrezentos, salarioReajustado;
    
    indiceAcimaTrezentos = 0.15;
    indiceAteTrezentos = 0.35;
    
    printf("Programa de Cálculo de Reajuste de Salários\n\n");
    
    printf("Por favor insira o seu salário:..");
    scanf("%f", &salario);
    
    if (salario > 300.00) {
        salarioReajustado = salario * (1.0 + indiceAcimaTrezentos);
        printf("Seu salário de R$%.2f foi reajustado para R$%.2f", salario, salarioReajustado);
    }
    else if (salario < 0){
        printf("Salários não podem ter valor negativo!\n");
        printf("Por favor, tente novamente");
    }
    else {
        salarioReajustado = salario * (1.0 + indiceAteTrezentos);
        printf("Seu salário de R$%.2f foi reajustado para R$%.2f", salario, salarioReajustado);
    }
}
