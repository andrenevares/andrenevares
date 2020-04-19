#include <stdio.h>

int main()
{
    
    int senha;
    
    printf("Sistema de Login\n\n");
    printf("Por favor digite sua senha:.. ");
    scanf("%d", &senha);
    
    if (senha == 4531){
        printf("Senha confirmada com sucesso!\n");
        printf("Acesso permitido");
    }
    else {
        printf("Acesso Negado");
    }
    
    return 0;
}   
