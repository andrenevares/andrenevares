#include <stdio.h>

int main()
{

    float gratificacao, salarioBruto, salarioFinal, salarioLiquido1, salarioLiquido2;
    
    printf("Sabe-se que este é composto pelo salário bruto acrescido de gratificação e descontado o imposto de 7 por cento sobre o salário.\n\n");
    printf("Qual o Salário Bruto?.. ");
    scanf("%f", &salarioBruto);
    printf("-----------------------------\n\n");
    
    if (salarioBruto > 900) {
        gratificacao = 100;
        salarioFinal = salarioBruto + gratificacao;
        salarioLiquido1 = salarioFinal * 0.93;
        salarioLiquido2 = (salarioBruto * 0.93) + gratificacao;
        printf("O Salário Final é de:.. R$%.2f\n", salarioFinal);
        printf("O Salário Líquido (tributando a gratificação) é de:.. R$%.2f\n", salarioLiquido1);
        printf("O Salário Líquido (sem tributar a gratificação) é de:.. R$%.2f\n", salarioLiquido2);
    }
    
    else if (salarioBruto >= 600) {
        gratificacao = 75;
        salarioFinal = salarioBruto + gratificacao;
        salarioLiquido1 = salarioFinal * 0.93;
        salarioLiquido2 = (salarioBruto * 0.93) + gratificacao;
        printf("O Salário Final é de:.. R$%.2f\n", salarioFinal);
        printf("O Salário Líquido (tributando a gratificação) é de:.. R$%.2f\n", salarioLiquido1);
        printf("O Salário Líquido (sem tributar a gratificação) é de:.. R$%.2f\n", salarioLiquido2);
    }
    else if (salarioBruto > 350) {
        gratificacao = 50;
        salarioFinal = salarioBruto + gratificacao;
        salarioLiquido1 = salarioFinal * 0.93;
        salarioLiquido2 = (salarioBruto * 0.93) + gratificacao;
        printf("O Salário Final é de:.. R$%.2f\n", salarioFinal);
        printf("O Salário Líquido (tributando a gratificação) é de:.. R$%.2f\n", salarioLiquido1);
        printf("O Salário Líquido (sem tributar a gratificação) é de:.. R$%.2f\n", salarioLiquido2);
    }
    else if (salarioBruto > 0) {
        gratificacao = 35;
        salarioFinal = salarioBruto + gratificacao;
        salarioLiquido1 = salarioFinal * 0.93;
        salarioLiquido2 = (salarioBruto * 0.93) + gratificacao;
        printf("O Salário Final é de:.. R$%.2f\n", salarioFinal);
        printf("O Salário Líquido (tributando a gratificação) é de:.. R$%.2f\n", salarioLiquido1);
        printf("O Salário Líquido (sem tributar a gratificação) é de:.. R$%.2f\n", salarioLiquido2);
    }
    else {
        printf("O valor digitado não pode ser calculado!");
    }
    return 0;
}
