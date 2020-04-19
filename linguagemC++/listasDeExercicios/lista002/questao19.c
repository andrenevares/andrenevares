#include <stdio.h>

int main()
{
    float altura, pesoideal;
    int sexo;
    
    printf("Cálculo de peso ideal\n\n");
    printf("Digite sua altura:.. ");
    scanf("%f", &altura);
    
    printf("Digite:.. \n\n");
    printf("( 1 ) Sexo Feminino \n");
    printf("( 2 ) Sexo Masculino \n\n");
    printf("Selecione uma opção:.. ");
    scanf("%d", &sexo);
    
    if (sexo == 1){
        pesoideal = (62.1 * altura) - 44.7;
        printf("Seu peso ideal é: %.2f", pesoideal);
    }
    else if (sexo == 2){
        pesoideal = (72.7 * altura) - 58;
        printf("Seu peso ideal é: %.2f", pesoideal);
    }
    else {
        printf("Opção inválida");
    }
    return 0;
}    

