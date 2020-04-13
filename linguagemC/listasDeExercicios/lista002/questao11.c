#include <stdio.h>

int main()
{
    
    float salario, novosalario, fator, aumento;
    
    
    printf("Programa para Cálculo de Aumento de Salário\n\n");
    printf("Por favor digite o Salário:.. ");
    scanf("%f", &salario);
    
    if (salario > 900.00){
        fator = 1 + 0.00;
        novosalario = salario * fator;
        aumento = novosalario - salario;
        printf("O salario de R$%.2f passou a ser de R$%.2f, o que representa um aumento de R$%.2f", salario, novosalario, aumento); 
    }
    else if (salario >= 600){
        fator = 1 + 0.05;
        novosalario = salario * fator;
        aumento = novosalario - salario;
        printf("O salario de R$%.2f passou a ser de R$%.2f, o que representa um aumento de R$%.2f", salario, novosalario, aumento);
        
    }
    else if (salario > 300){
        fator = 1 + 0.10;
        novosalario = salario * fator;
        aumento = novosalario - salario;
        printf("O salario de R$%.2f passou a ser de R$%.2f, o que representa um aumento de R$%.2f", salario, novosalario, aumento);
    }
    
    else if (salario > 0){
        fator = 1 + 0.15;
        novosalario = salario * fator;
        aumento = novosalario - salario;
        printf("O salario de R$%.2f passou a ser de R$%.2f, o que representa um aumento de R$%.2f", salario, novosalario, aumento);
    }
    else if (salario == 0) {
        printf("Com salário ZERO, não há como termos aumento!");
    }
    
    else {
        printf("Você digitou um valor incorreto.  Por favor, somente digite números com os centavos separados por pontos e não vírgula! ");
    }
}    
