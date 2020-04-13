#include <stdio.h>

int main()
{
    // Definir variáveis
    float n1,n2,numeroMenor;
    // Código
    
    printf("Qual a nota nº 1? ");
    scanf("%f", &n1);
    printf("Qual a nota nº 2? ");
    scanf("%f", &n2);
    
    if (n1 > n2) {
        numeroMenor = n2;
        printf("O número %.2f é menor que %.2f", numeroMenor, n1);
    }
    else if  (n1 < n2) {
        numeroMenor = n1;
        printf("O número %.2f é menor que %.2f", numeroMenor, n2);
    }
    else {
        numeroMenor = n1;
        printf("O número %.2f é igual a %.2f", numeroMenor, n1);
    }
    
    return 0;
}
