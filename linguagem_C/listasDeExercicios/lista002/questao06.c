#include <stdio.h>
#include <math.h> // A função pow demanda a inclusão dessa biblioteca

int main()
{
  // definir variáveis
  
  float n1, n2, resultado;
  int opcao;

  printf("Digite dois números, depois selecione uma das operações...\n\n");
  printf("Digite o número 01: ");
  scanf("%f", &n1);
  printf("Digite o número 02: ");
  scanf("%f", &n2);
  printf("------------------------------------------------\n\n\n");
  printf("Selecione uma das opções abaixo:\n\n");
  printf("( 1 )  O primeiro número elevado ao segundo número\n");
  printf("( 2 )  Raiz quadrada de cada um dos números.\n");
  printf("( 3 )  Raiz cúbica de cada um dos números.\n\n");
  printf("Digite a opção desejada: ");
  scanf("%d", &opcao);
  printf("-----------------------\n");
  printf("Você selecionou a opção: %d \n\n", opcao);
  
  if (opcao == 1){
      resultado = pow(n1,n2);
      printf("O número %.2f elevado a %.2f resulta em %.2f", n1, n2, resultado);
  }
  else if (opcao == 2){
      resultado = sqrt(n1);
      printf("A raiz quadrada de %.2f é %.2f\n", n1, resultado);
      resultado = sqrt(n2);
      printf("A raiz quadrada de %.2f é %.2f\n", n2, resultado);
  }
  else if (opcao == 3){
      resultado = pow(n1, 1.0/3.0); // A raiz cúbica pode ser obtida por pow (x, 1.0/3.0)  
      printf("A raiz cúbica de %.2f é %.2f\n", n1, resultado);
      resultado = pow(n2, 1.0/3.0);
      printf("A raiz cúbica de %.2f é %.2f\n", n2, resultado);
  }
  else {
      printf("A opção %d não é um valor aceito!", opcao);
  }
}
