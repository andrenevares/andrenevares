#include <stdio.h>

int main()
{
    
    int idade;
    
    printf("Cálculo de Maioridade\n\n");
    printf("Digite sua idade:.. ");
    scanf("%d", &idade);
    
    if (idade >= 18){
        printf("Você já é maior de idade!");
    }
    else {
        printf("Você é menor de idade");
    }
    
    return 0;
}   
