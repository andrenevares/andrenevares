# Especificação do Serviço


Para o módulo de Grandes devedores, se faz necessário a Secretária da Fazenda disponibilizar um serviço webservice, onde encaminhamos a raiz de um CNPJ e esperamos no retorno as informações referente aos estabelecimentos vinculados a está raiz de CNPJ como segue na tabela abaixo:  

### Sugestão de Adaptação de nomenclatura
No que se refere à Secretaria da Fazenda não há devedores, mas sim contribuintes. Deste forma, para que a SEFA consiga entender melhor a demanda, sugiro que na documentação utilizemos contribuinte.

# Campos
## Raiz CNPJ;
Decrição área de negócio demandante:


### Dúvida 01
Necessito saber qual o formato dos dados a serem entregues pelo serviço.

### Dúvida 02.
Acredito que o campo RAIZ CNPJ deve ser o CNPJ BASE.  Vejam:
99.999.999/4444-55.  
Sem levar em conta a formatação, estou entendendo que o serviço deve retornar o valor 99999999 seria isso?


## Estabelecimento Principal 	
Indica se é ou não o estabelecimento principal do devedor 	 

## Estabelecimento 	
Nome completo do estabelecimento 	 

## CNPJ Completo 
Número do CNPJ completo do estabelecimento 	Número sem formatação.  

## Situação cadastral 
Situação cadastral atual do estabelecimento 	Domínio definido pela SEFA 

## Situação cadastral 
 	Data da situação cadastral atual do estabelecimento 
 	 
## Valor faturamento
Valor do faturamento do estabelecimento 	
Trata-se do faturamento do último mês do estabelecimento. 
 
## Mês e ano Faturamento 	
Mês e ano ao qual o valor do faturamento informado se refere 	
Este campo torna-se obrigatório apenas se houver informação para “Valor faturamento” 

## Valor dos pagamentos 	
Valor total dos pagamentos do estabelecimento 	
Trata-se da soma de todos os pagamentos feitos pelo estabelecimento no último mês. 
 
## Mês e ano pagamentos 	
Mês e ano ao qual os pagamentos informados foram feitos pelo  estabelecimento 	
Este campo torna-se obrigatório apenas se houver informação  para Valor dos pagamentos” 
 
