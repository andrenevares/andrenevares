# Especificação do Serviço


Para o módulo de Grandes devedores, se faz necessário a Secretária da Fazenda disponibilizar um serviço webservice, onde encaminhamos a raiz de um CNPJ e esperamos no retorno as informações referente aos estabelecimentos vinculados a está raiz de CNPJ como segue na tabela abaixo:  

### Adaptação de nomenclatura
No que se refere à Secretaria da Fazenda não há devedores, mas sim contribuintes. Deste forma, para que a SEFA consiga entender melhor a demanda, sugiro que na documentação utilizemos contribuinte.

# Campos
## Raiz CNPJ;

Acredito que muito embora o dado aparente ser do tipo NUMÉRICO, na verdade é do tipo STRING.

### Dúvida 01
Necessito saber qual o formato dos dados a serem entregues pelo serviço.

### Dúvida 02.
Acredito que o campo RAIZ CNPJ deve ser o CNPJ BASE.  Vejam:
99.999.999/4444-55.  
Sem levar em conta a formatação, estou entendendo que o serviço deve retornar o valor 99999999 seria isso?


