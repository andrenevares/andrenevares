#include <stdio.h>

int main()
{
    int idade;
    
    printf("Categoria por idade\n\n");
    printf("Digite a idade do(a) nadador(a):.. ");
    scanf("%d", &idade);
    
;
    
    if (idade > 30){
        printf("Categoria Sênior");
    }
    else if (idade >= 16){
        printf("Categoria Adulto");
    }
    else if (idade >= 11){
        printf("Categoria Adolescente");
    }
    else if (idade >= 8){
        printf("Categoria Juvenil");
    }
    else if (idade >= 5){
        printf("Categoria Infantil");
    }
    else if (idade > 0){
        printf("Ainda não há categoria");
    }
    else {
        printf("Dados inválidos");
    }
    return 0;
}    
