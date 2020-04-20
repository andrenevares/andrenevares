# Plano de Aula 04

## Tipos de Fluxo de Transmissão
A forma de utilização do meio físico que conecta estações dá origem à seguinte classificação sobre comunicação no enlace:

- **Simplex**: o enlace é utilizado apenas em _**um dos dois possíveis sentidos**_ de transmissão. Exemplos: Teclados, monitores e radio comerciais.
- **Half-duplex**: o enlace é utilizado _**nos dois possíveis sentidos**_ de transmissão, porém apenas _**um por vez**_, como por exemplo rádios portáteis de comunicação, redes sem fio.
- **Full-duplex**: o enlace é utilizado _**nos dois possíveis sentidos**_ de transmissão _**simultaneamente**_ como por exemplo a telefonia fixa e celular, redes cabeadas com switch.

Enlaces como os classificados serão utilizados pelas diferentes topologias que, por sua vez, irão variar de acordo com o tipo de rede utilizada Topologias de Redes

O Sistema de Comunicação vai se constituir num arranjo topológico interligando os diversos nós através de enlaces físicos (meios de transmissão) e de um conjunto de regras com o fim de organizar a comunicação (protocolos).

Ao organizar os enlaces físicos num sistema de comunicação, várias são as formas possíveis de utilização das linhas de transmissão. As ligações podem ser de dois tipos:

- **Ponto a Ponto** - caracterizam-se pela presença de somente dois pontos de comunicação, um em cada extremidade do enlace.
- **Multiponto** - presença de três ou mais dispositivos de comunicação com possibilidade de utilização do mesmo enlace

Existem duas partes na definição da topologia, a topologia física, que é o layout atual do fio (meio) e os métodos de acesso ao meio (topologia lógica), que define como os meios são acessados pelos hosts ou nós de rede e é padronizada por protocolos da camada de enlace.

## Topologias Físicas ##

### Barramento ou barra:
Usa um único segmento de backbone (comprimento do cabo) ao qual todos os
hosts ou nós de rede se conectam diretamente.
### Anel
Conecta um host ou nó de rede ao próximo até retornar ao primeiro Isso cria
um anel físico do cabo.
### Estrela
Conecta todos os cabos ao ponto central de concentração. Esse ponto é normalmente um hub ou switch.

A camada de Enlace fornece serviços para suportar os processos de comunicação para cada meio sobre o qual o dado deve ser transmitido.

Quando ocorre a transmissão entre dois nós, embora do ponto de vista de rede tenhamos uma origem e um destino bem definidos, no enlace podem ocorrer numerosas transições. Em cada salto ao longo do caminho, um dispositivo intermediário - geralmente um roteador - aceita quadros de um meio, desencapsula o quadro e então encaminha o pacote em um novo e apropriado quadro ao meio daquele segmento de rede física.

O método de acesso ao meio, também chamada de topologia lógicas por alguns autores, uma rede é a forma como os hosts ou nós de redes se
comunicam através dos meios. 

Cada protocolo da camada de Enlace determina o seu método de controle de acesso ao meio. Estas técnicas de controle de acesso definem se e como os nós compartilham o meio.

Uma boa analogia para os métodos de controle de acesso ao meio são as regras de trânsito que regulam a entrada de veículos em uma rodovia. A inexistência de regras seria o equivalente a veículos entrando na rodovia sem respeitar os outros veículos. Entretanto as rodovias e entradas diferem entre si, algumas possuem um sinal de transito que tem que estar aberto para que o veículo possa avançar, outras apenas uma sinalização de preferência.
Do mesmo modo existem diferentes formas de regular a colocação dos quadros no meio.

Alguns métodos de controle de acesso ao meio usam processos altamente controlados que asseguram que os quadros sejam colocados de modo seguro no meio outros são mais simples.

Existem dois métodos básicos de controle de acesso ao meio paro meio compartilhado.
- **Controlado** - Cada nó tem seu próprio tempo para usar o meio.
- **Baseados em Contenção** - Todos os nós competem pelo uso do meio

### Acesso Controlado
Quando se usa o método de acesso controlado, os dispositivos de rede se alternam, em sequência, para acessar o meio. Este método também é conhecido como acesso planejado ou determinístico. Se um dispositivo não precisa acessar o meio, a oportunidade de usar o meio passa para o próximo dispositivo na linha. Quando o dispositivo coloca um quadro no meio, nenhum outro dispositivo pode fazer o mesmo até que o quadro tenha chegado ao destino e tenha sido processado. 

Embora o acesso controlado seja bem ordenado e forneça uma taxa de transferência previsível, os métodos determinísticos podem ser ineficientes porque um dispositivo tem que esperar por sua vez antes que ele possa usar o meio.

### Acesso Baseado em Contenção
Também referidos como não-determinísticos, os métodos baseados em contenção permitem que qualquer dispositivo tente acessar o meio sempre que ele tenha dados para enviar. Para impedir o caos completo no meio, estes métodos usam um processo de Carrier Sense Multiple Access (CSMA) para detectar primeiro se o meio está transportando algum sinal. Se um sinal portador sobre o meio de um outro nó é detectado, isso significa que um outro dispositivo está transmitindo dados. 

Quando o dispositivo tenta transmitir e vê que o meio está ocupado, ele irá esperar e tentar novamente após um curto período de tempo. 

Se nenhum sinal portador for detectado, o dispositivo transmite os seus dados. 

As redes Ethernet e sem fio usam controle de acesso ao meio baseado em contenção.

É possível que o processo CSMA falhe e dois dispositivos transmitam dados ao mesmo tempo. Isto é chamado de colisão de dados. Se isso ocorrer, os dados enviados por ambos os dispositivos serão corrompidos e necessitarão ser reenviados.

Os métodos de controle de acesso ao meio baseados em contenção não têm o overhead dos métodos de acesso controlado. Um mecanismo de rastreamento para verificar o acesso ao meio não é necessário. No entanto, os sistemas baseados em contenção não trabalham bem sob uso pesado do meio. À medida que o uso e o número de nós aumenta a probabilidade de acesso bem sucedido ao meio sem colisão diminui. Adicionalmente, os mecanismos de recuperação necessários para corrigir erros devidos a essas colisões ainda diminuem a taxa de transferência.

O **CSMA** é geralmente implementado em conjunto com um método para resolução a contenção do meio. Os dois métodos geralmente usados são:

- **CSMA/Collision Detection (Detecção de Colisão)**: o dispositivo monitora o meio para verificar a presença de sinal de dados. Se um sinal de dados está ausente, indicando que o meio está livre, o dispositivo transmite os dados. Se são detectados sinais que mostram que um outro dispositivo estava transmitindo ao mesmo tempo, todos os dispositivos param de enviar e tentam novamente mais tarde. Formas tradicionais de uso da Ethernet neste método.

- **CSMA/Collision Avoidance (Prevenção de Colisão)**: o dispositivo examina o meio para verificar a presença de sinal de dados. Se estiver livre, o dispositivo envia uma notificação através do meio com sua intenção de usá-lo. O dispositivo então envia os dados. Esse método é usado pelas tecnologias de rede sem fio 802.11.

#### Aplicação Prática Teórica
- Site da editora Pearson/Addison Wesley onde se pode encontrar alguns aplicativos (Java apples) que ajudam a entender alguns dos conceitos abordados nesta aula. Segue a url: http://wps.aw.com/br_kurose_redes_3/40/10271/2629597.cw/index.html

- Também neste site da editora Pearson (www.aw.com/kurose.br) pode-se encontrar outros recursos didáticos.

Escolher um recurso e testar.
