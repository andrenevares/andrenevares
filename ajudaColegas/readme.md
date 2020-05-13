```
Algoritmo ContraCheque
         salbruto, valinss, valfgts, valirrf, salliquido : real
         mes, ano, codigo, faixa : inteiro
         nome, cargo : texto // é uma variável de texto
Inicio
      Escreva(“Digite a matrícula do funcionário..:”)
      Leia(“codigo”) //Matrícula do funcionário
      Escreva(“Digite o nome do funcionário..:”)
      Leia("nome") //Nome
      Escreva("Digite o cargo do funcionário..:")
      Leia("cargo") //Cargo
      Escreva(“Digite o mês de competência..:”)
      Leia("mes") //Mês 
      Escreva(“Digite o salário bruto do funcionário..:”)
      Leia("salbruto") //Salário Bruto
      
   valinss recebe salbruto * 0,14
   
   valfgts recebe salbruto * 0,8
      
      // só o calculo do Imposto Renda
      se salbruto >= 4664.68 então:
         valirrf recebe ( (salbruto - valinss) * 0.275  ) - 869.36
         faixa = 5
      senão se  salbruto >= 3751.06 então:
         valirrf recebe ((salbruto - valinss) * 0.0) - 636.13
         faixa = 4
      senão se  salbruto >= 2826.66 então:
         valirrf recebe ((salbruto - valinss) * 0.075) - 354.80
         faixa = 3
      senão se  salbruto >= 1903.99  então:   
         valirrf recebe ((salbruto - valinss) * 0.15) - 142.80
         faixa = 2
      senão:
         valirrf recebe 0
         faixa 1
      
         salliquido = salbruto – valinss – valirrf
         
         escreva("Nome: ") & variavel
         escreva("Mês") & variavel
         escreva("Ano") & variavel
         escreva("Salário Bruto:..") & variavel
         escreva("FGTS:..") & variavel
         escreva("INSS:..") & variavel
         escreva("IRPF:..") & valirrf
         escreva("Salário Líquido:..") & variavel
         escreva("Salário Líquido:..") & variavel
         
```
