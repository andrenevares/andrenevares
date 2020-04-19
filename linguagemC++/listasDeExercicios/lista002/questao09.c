#include <stdio.h>

int main()
{
    
    float saldomedio, creditoespecial, fator;
    
    
    printf("Programa para Crédito creditoespecial\n\n");
    printf("Por favor digite o saldo médio:.. ");
    scanf("%f", &saldomedio);
    
    if (saldomedio > 400){
        fator = 1 + 0.30;
        creditoespecial = saldomedio * fator;
        printf("Com o saldo médio de %.2f será concedido um Crédito Especial de %.2f", saldomedio, creditoespecial)      ;  
    }
    else if (saldomedio > 300){
        fator = 1 + 0.25;
        creditoespecial = saldomedio * fator;
        printf("Com o saldo médio de %.2f será concedido um Crédito Especial de %.2f", saldomedio, creditoespecial) ;       
    }
    else if (saldomedio > 200){
        fator = 1 + 0.20;
        creditoespecial = saldomedio * fator;
        printf("Com o saldo médio de %.2f será concedido um Crédito Especial de %.2f", saldomedio, creditoespecial);
        
    }
    else if (saldomedio > 0){
        fator = 1 + 0.10;
        creditoespecial = saldomedio * fator;
        printf("Com o saldo médio de %.2f será concedido um Crédito Especial de %.2f", saldomedio, creditoespecial);
    }
    else if (saldomedio == 0) {
        printf("Com saldo médio ZERO, não há limite disponível de Crédito Especial");
    }
    
    else {
        printf("Você digitou um valor incorreto.  Por favor, somente digite números com os centavos separados por pontos e não vírgula! ");
    }
}  
