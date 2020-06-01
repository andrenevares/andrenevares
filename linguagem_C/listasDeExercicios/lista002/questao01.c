#include <stdio.h>

int main()
{
    // Definir variáveis
    float n1,n2,n3,n4,media;
    // Código
    
    printf("Qual a nota nº 1? ");
    scanf("%f", &n1);
    printf("Qual a nota nº 2? ");
    scanf("%f", &n2);
    printf("Qual a nota nº 3? ");
    scanf("%f", &n3);
    printf("Qual a nota nº 4? ");
    scanf("%f", &n4);
    media = (n1+n2+n3+n4)/4;
    printf("--------------\n");
    
    if (media >= 7) {
        printf("Sua media foi %.2f, você foi aprovado!", media);
    }
    else {
        printf("Sua media foi %.2f, você foi reprovado!", media);
    }
    return 0;
}
