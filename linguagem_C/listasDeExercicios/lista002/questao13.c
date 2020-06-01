#include <stdio.h>

int main()
{
    float preco, novopreco;
    
    printf("Cálculo de Novo Preço e Enquadramento\n\n");
    printf("Insira o preço a ser ajustado:.. ");
    scanf("%f", &preco);
    
;
    
    if (preco > 100) {
        novopreco = preco * 1.15;
    }
    else if (preco >= 50){
        novopreco = preco * 1.10;
    }
    else if (preco >= 0){
        novopreco = preco * 1.05;
    }
    else {
        printf("Código inválido");
        return 0;
    }
    
    if (novopreco > 200) {
        printf("O novo preço, R$%.2f, é Muito Caro!", novopreco);
    }
    else if (novopreco > 120) {
        printf("O novo preço, R$%.2f, é Caro!", novopreco);
    }
    else if (novopreco > 80) {
        printf("O novo preço, R$%.2f, é Normal!", novopreco);
    }
    else if (novopreco > 0) {
        printf("O novo preço, R$%.2f, é Barato!", novopreco);
    }
    else {
        printf("Sem Classificação");
    }
    
    
    
    return 0;
}    
