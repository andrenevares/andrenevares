#include <stdio.h>

int main()
{
  // definir variáveis
  
  char opcao;
  float n1, n2, resultado;

  printf("Digite dois números, depois selecione uma das operações...\n\n");
  printf("Digite o número 01: ");
  scanf("%f", &n1);
  printf("Digite o número 02: ");
  scanf("%f", &n2);
  printf("------------------------------------------------\n\n\n");
  printf("Selecione uma das opções abaixo:\n\n");
  printf("a. O primeiro número elevado ao segundo número\n");
  printf("b. Raiz quadrada de cada um dos números.\n");
  printf("c. Raiz cúbica de cada um dos números.\n\n");
  scanf("%c", &opcao);
  
  
}
