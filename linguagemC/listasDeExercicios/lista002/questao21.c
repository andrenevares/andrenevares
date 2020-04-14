#include <stdio.h>

int main()
{
    int codigo;
    
    printf("Encontre a procedência por códigos\n\n");
    printf("Digite o o código de origem (1 a 30):.. ");
    scanf("%d", &codigo);
    
;
    
    if (codigo > 30) {
        printf("Código Inválido");
    }
    else if (codigo > 21){
        printf("Nordeste");
    }
    else if (codigo >= 10){
        printf("Centro-Oeste");
    }
    else if (codigo >= 7){
        printf("Sudeste");
    }
    else if (codigo >= 5){
        printf("Nordeste");
    }
    else if (codigo == 4){
        printf("Oeste");
    }
    else if (codigo == 3){
        printf("Leste");
    }
    else if (codigo == 2){
        printf("Norte");
    }
    else if (codigo == 2){
        printf("Norte");
    }
    else if (codigo == 1){
        printf("Norte");
    }
    else {
        printf("Código inválido");
    }
    return 0;
}    
