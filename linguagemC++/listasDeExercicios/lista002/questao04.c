#include <stdio.h>

int main()
{
    // Definir variáveis
    float n1,n2,n3;
    // Código
    
    printf("Qual a nota nº 1? ");
    scanf("%f", &n1);
    printf("Qual a nota nº 2? ");
    scanf("%f", &n2);
    printf("Qual a nota nº 3? ");
    scanf("%f", &n3);
    
    if (n1 > n2) {
        if (n1 > n3){
        printf("O número maior é: %.2f ", n1);    
        }
    }
    else if (n1 <= n2){
        if (n2 > n3){
        printf("O número maior é: %.2f ", n2);    
        }
        else {
        printf("O número maior é: %.2f ", n3);    
        }
    }

    
    return 0;
}
