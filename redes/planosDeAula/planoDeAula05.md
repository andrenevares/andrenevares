# Plano de Aula 05

Um desenvolvimento significativo que aprimorou o desempenho da **LAN** foi a introdução de switches para substituir os hubs em redes Ethernet. Este desenvolvimento corresponde bastante com o da Ethernet **100BASE-TX**. Os switches podem controlar o fluxo de dados ao isolar cada porta e enviar um quadro apenas a seu destino adequado (se este for conhecido), em vez de enviar cada quadro a cada dispositivo.

O **switch** reduz o número de dispositivos que recebe cada quadro, o que, por sua vez, diminui ou minimiza a possibilidade de colisões. Isso, e a introdução posterior das comunicações full-duplex (ter uma conexão que possa transmitir e receber sinais ao mesmo tempo), permitiu o desenvolvimento da Ethernet 1 Gbps e na prática eliminou as colisões.

## Endereços MAC e IP

Há dois endereços principais atribuídos a um dispositivo de host:
- **Endereço físico** (o endereço **MAC**)
- **Endereço lógico** (o endereço **IP**)

Tanto o endereço **MAC** como o **IP** trabalham juntos para identificar um dispositivo na rede. O processo de usar os endereços MAC e IP para localizar um computador é semelhante ao processo de usar o nome e o endereço de uma pessoa para enviar uma carta.

O nome de uma pessoa geralmente não muda. 

O endereço de uma pessoa, por outro lado, refere-se ao local onde mora e pode ser alterado.

Assim como o nome de uma pessoa, o endereço **MAC** de um host não muda; ele é atribuído fisicamente à placa de rede do host e é conhecido como endereço físico. 

O endereço físico permanece o mesmo, independentemente de onde o host está colocado.

O endereço **IP** é semelhante ao endereço de uma pessoa. Esse endereço baseia-se no local em que o host realmente se encontra. Por meio desse endereço, é possível que um quadro determine o local a partir do qual um quadro deve ser enviado. O endereço **IP**, ou o endereço de rede, é conhecido como um endereço lógico por ser atribuído logicamente. Ele é atribuído a cada host por um administrador de rede com base na rede local em que o host está conectado.

Os endereços **MAC** físico e **IP** lógico são necessários para que um computadorse comunique em uma rede hierárquica, assim como o nome e o endereço de uma pessoa são necessários para enviar uma carta.

## Protocolo ARP

Cada nó em uma rede **IP** tem um endereço **MAC** e um endereço **IP**. Para enviar dados, o nó deve usar esses dois endereços. O nó deve usar seus próprios endereços **MAC** e **IP** nos campos origem e deve fornecer um endereço **MAC** e um endereço **IP** para o destino. Enquanto o endereço **IP** destino será fornecido por uma camada superior, o nó emissor precisará de uma maneira para localizar o endereço MAC destino para um determinado link de **Ethernet**. Essa é a finalidade do **ARP**.

O ARP baseia-se em determinados tipos de mensagens de **broadcast** Ethernet e mensagens unicast Ethernet, chamadas solicitações ARP e respostas ARP. 

Para que um quadro seja colocado no meio físico da LAN, ele deve possuir um endereço MAC de destino. Quando um pacote é enviado à camada de Enlace para ser encapsulado em um quadro, o nó consulta uma tabela em sua memória para encontrar o endereço da camada de Enlace que é mapeado ao endereço IPv4 de destino. Essa tabela é chamada de Tabela ARP ou de ARP CACHE . 

A tabela **ARP** é armazenada na RAM do dispositivo.

Cada entrada, ou linha, da tabela **ARP** possui um par de valores: um Endereço **IP** e um endereço **MAC**. Nós chamamos o relacionamento entre os dois valores de mapa isso significa simplesmente que você pode localizar um endereço **IP** na tabela e descobrir o endereço **MAC** correspondente. A tabela **ARP** gera a cache de mapeamento para os dispositivos na **LAN local**.

Para começar o processo, um nó de transmissão tenta localizar na tabela **ARP** o endereço MAC mapeado a um destino **IPv4**. Se este mapa estiver em cache na tabela, o nó usa o endereço **MAC** como o **MAC** de destino no quadro que encapsula o pacote **IPv4**. O quadro é, então, codificado no meio físico de rede.

Quando o **ARP** recebe uma solicitação para mapear um endereço **IPv4** a um ndereço **MAC**, ele procura um mapa em cache na sua tabela ARP. Se não encontrar uma entrada, o encapsulamento do pacote de **IPv4** falha e os processos de **Camada 2** notificam o **ARP** que precisam de um mapa.

Os processos **ARP** enviam, então, um pacote de solicitação **ARP** para descobrir o endereço **MAC** do dispositivo de destino na rede local. Esta solicitação denomina-se **ARP** Request

Se o dispositivo que está recebendo a solicitação tiver o endereço **IP** de destino, ele responde com uma resposta **ARP** (ARP Reply). Este dispositivo aproveita para criar uma entrada em seu **ARP Cache** com o **MAC** do solicitante. 

Os pacotes para o endereço **IPv4** podem, agora, ser encapsulados em uadros. Se nenhum dispositivo responder à solicitação **ARP**, o pacote é abandonado porque o quadro não pode ser criado. Essa falha de encapsulamento é informada para as camadas superiores do dispositivo. Se o dispositivo é um dispositivo intermediário, como um roteador, as camadas superiores podem escolher responder ao host de origem com um erro, através de um pacote **ICMPv4**

### Aplicação Prática Teórica
- Site da editora Pearson/Addison Wesley onde se pode encontrar alguns aplicativos (Java apples) que ajudam a entender alguns dos conceitos abordados nesta aula. Segue a url: http://wps.aw.com/br_kurose_redes_3/40/10271/2629597.cw/index.html

- Também neste site da editora Pearson (www.aw.com/kurose.br) pode-se encontrar outros recursos didáticos. 

Escolher um recurso e testar.
