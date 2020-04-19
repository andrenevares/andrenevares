# Plano de Aula 02

## Arquitetura TCP/IP

O TCP/IP é um conjunto de protocolos hierárquicos que embasa o funcionamento da Internet e, atualmente o funcionamento de praticamente
todas as redes locais.

A arquitetura TCP/IP, assim como OSI realiza a divisão de funções do sistema de comunicação em estruturas de camadas, porém, como foi desenvolvida antes do Modelo OSI, camadas não correspondem exatamente as do RMOSI c O TCP/IP é formado por 4 camadas:

- **Aplicação** - correspondendo aproximadamente as 3 camadas superiores do OSI, e que tem por função tratar questões de representação, codificação e controle de diálogo. O TCP/IP combina todas as questões relacionadas a aplicações em uma camada e presume que esses dados estejam  empacotados corretamente para a próxima camada. Exemplos de protocolos desta camada são: FTP, HTTP, Telnet, SMTP, POP3 e IMAP;

- **Transporte** - correspondendo aproximadamente à camada de transporte do OSI reúne os protocolos que realizam as funções de transporte de dados fim-a-fim, ou seja, considerando apenas a origem e o destino da comunicação, sem se preocupar com os elementos intermediários. A camada de transporte possui dois protocolos principais que são o UDP (User Datagram Protocol) e TCP (Transmission Control Protocol);

- **Inter-Rede** - correspondendo aproximadamente a camada de rede do OSI tem como finalidade enviar pacotes da origem de qualquer rede e fazê-los chegar ao destino, independente do caminho e das redes que tomem para chegar lá. O protocolo específico que governa essa camada é chamado protocolo de Internet (IP). A determinação do melhor caminho e a comutação de pacotes acontecem nessa camada;

- **Intra-rede** - É também chamada de camada host-rede ou rede de acesso. É a camada que se relaciona a tudo aquilo que um pacote IP necessita para realmente estabelecer um link físico e depois estabelecer outro link físico. Isso inclui detalhes de tecnologia de LAN e WAN e todos os detalhes nas camadas física e de enlace do OSI.

### Encapsulamento dos Dados
No processo de comunicação entre elementos na rede a informação sai da aplicação do usuário e atravessa as diversas camadas funcionais
apresentadas no modelo OSI sob a forma de uma Unidade de Informação, denominada **PDU** (Protocol Data Unit).

Cada camada funcional possui o seu **PDU** que, genericamente, é chamado de pacote. A partir da camada de transporte cada **PDU** recebe um nome específico, identificando-o conforme as funções que devem ser executadas em cada camada.

- O **PDU** da camada de transporte por ser o Segmento, como por exemplo, Segmento **TCP** ou Datagrama de Usuário no caso do **UDP** da pilha TCP/IP.
- O **PDU** da camada de rede é chamado de Datagrama IP, no caso da pilha **TCP/IP**, ou Pacote.
- O **PDU** da camada de enlace é chamado de Quadro (Frame), como por exemplo, Frame Ethernet.
- Na camada física a informação a ser transportada é codificada como uma sequência de bits.

### Transmissão de dados:
Para que os pacotes de dados trafeguem da origem para o destino, cada camada do modelo OSI na origem deve se comunicar com sua camada par no destino. Esta forma de comunicação é chamada de Comunicação virtual entre camadas pares, quando os protocolos destas trocam PDUs
