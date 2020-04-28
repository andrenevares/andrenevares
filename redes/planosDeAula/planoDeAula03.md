 # Plano de Aula 03

Um Sistema de Comunicação de Dados prove um meio de transmissão para que os computadores possam realizar o intercâmbio de dados.

Para ter eficácia, segundo Forouzan(2008), um sistema de comunicações de dados depende dos seguintes fatores:

1. **Entrega** -O sistema deve entregar dados no destino correto. Os dados devem ser recebidos pelo dispositivo ou usuário pretendido
e somente por esse dispositivo ou usuário.
2. **Precisão** - O sistema deve entregar dados de forma precisa. Dados que foram alterados durante a transmissão e deixados sem
correção são inúteis.
3. **Sincronização** - O sistema deve entregar dados no momento certo. Dados entregues com atraso são inúteis. No caso de vídeo e áudio, a entrega em tempo significa fornecer os dados à medida em que eles são produzidos e sem atrasos consideráveis. Este tipo de entrega é denominado transmissão em tempo real.
4. **Jitter** - Refere-se à variação do tempo de chegada do pacote. É o atraso desigual na entrega de pacotes de áudio ou vídeo. Os componentes de um Sistema de Comunicação de Dados, segundo Forouzan(2008), são cinco:

1. **Mensagem** - são as informações (dados) serem transmitidos. Entre as formas populares de informação temos texto, fotos e vídeos.
2. **Emissor** -é o dispositivo que envia a mensagem de dados. Pode ser um computador, estação de trabalho, aparelho telefônico, televisão e assim por diante.
3. **Receptor** -é o dispositivo que recebe a mensagem. Pode ser um computador, estação de trabalho, aparelho telefônico, televisão e assim por diante.
4. **Meio de Transmissão** -é o caminho físico pelo qual uma mensagem trafega do emissor para o receptor. Alguns exemplos de meio de transmissão são: Cabo de par trançado, cabo coaxial, fibra ótica e o ar. 
5. **Protocolo** -é um conjunto de regras que controla a comunicação de dados. Representa um acordo entre os dispositivos de comunicação. Sem um protocolo dois dispositivos podem estar conectados, mas, não conseguem se comunicar

## Camada Física

A camada Física fornece os requisitos para transportar pelo meio físico de transmissão o quadro da camada de Enlace de Dados. Essa camada aceita um quadro completo da camada de Enlace de Dados e o codifica como uma série de sinais que serão transmitidos para o meio físico local. Os bits codificados que formam um quadro são recebidos por um dispositivo final ou por um dispositivo intermediário.

A entrega de quadros pelo meio físico local exige os seguintes elementos da camada Física:
- Meio físico e conectores ligados
- Representação de bits no meio físico
- Codificação de dados e informações de controle
- Circuito transmissor e receptor nos dispositivos de rede


### Cabeamento de Cobre

Ao longo dos anos foram utilizados vários tipos de cabeamento de cobre como coaxial grosso, coaxial fino e par trançado.

Nos dias atuais o tipo mais utilizado é o UTP (Unshielded twisted-pair), em português denominado Par Trançado Não Blindado com conectores RJ45 sendo utilizado para interconectar dispositivos de redes como os computadores com dispositivos intermediários como switch ou roteadores.

Para conectarmos o cabo UTP devemos seguir os padrões estabelecidos pela norma TIA/EIA 568 que define duas ordens diferentes para os fios


| # | Padrão T568B | Padrão T568A   |
| :-: | - |  - | 
| 1 | branco do laranja (Recepção) | branco do verde (transmissão) |
| 2 | laranja (Recepção)  | verde (transmissão)  |
| 3 | branco do verde (Transmissão) |  branco do laranja (Recepção) |
| 4 | azul    | azul  |
| 5 | branco do azul    | branco do azul  |
| 6 | verde (Transmissão)  |  laranja (Recepção) |
| 7 | branco do marrom  | branco do marrom  |
| 8 | marrom  | marrom  |

#### Conexões a fio:

A seguir estão os principais tipos de cabo obtidos pelo uso de padrões específicos de conexão de fios:

- **Cabo Direto (Ethernet)** - quando utilizamos o mesmo padrão nas duas pontas (T568A ou T568B)
- **Cabo Cruzado ou Crossover (Ethernet)** - quando utilizamos o padrão T568A em uma ponta e o T568B na outra. O cabo direto é o tipo "normal" de cabo, usado para ligar os micros ao switch. Já o cabo cruzado permite ligar diretamente dois micros, sem precisar do hub
ou switch. Ele é uma opção mais barata quando você tem apenas dois micros. 

#### Sem fio (Wireless)
O meio físico sem fio transmite sinais eletromagnéticos nas frequências de rádio que representam os dígitos binários de comunicação de dados. Como um meio de rede, o sem fio não é restrito aos condutores ou caminhos, como é o meio físico de cobre.
As tecnologias de comunicação de dados sem fio funcionam bem em ambientes abertos, entretanto em ambientes fechados, tem sua cobertura prejudicada por determinados materiais de construção utilizados em prédios e estruturas sendo, ainda. suscetível à interferência de telefones sem fio, lâmpadas fluorescentes e. fornos micro-ondas entre outros equipamentos.
Além disso, pelo fato da cobertura da comunicação sem fio não exigir acesso físico ao meio, os dispositivos e usuários que não são autorizados a acessar a rede terão acesso à transmissão. Portanto, a segurança de rede é o principal componente da administração de uma rede sem fio.
O IEEE e os padrões da indústria de telecomunicações para a comunicação de dados sem fio abrangem as camadas Física e Enlace de Dados. Os padrões de comunicação de dados comuns que se aplicam ao meio físico sem fio são:
- **Padrão IEEE 802.11** - Geralmente conhecido como Wi-Fi, é uma tecnologia Wireless LAN (WLAN) que utiliza a contenção ou sistema não-determinístico com o processo de acesso ao meio físico Carrier Sense Multiple Access/Collision Avoidance (CSMA/CA).
- **Padrão IEEE 802.15** - padrão Wireless Personal Area Network (WPAN), conhecido como "Bluetooth", utiliza um dispositivo de processo em pares para se comunicar a distâncias entre 1 e 100 metros.


### Aplicação Prática Teórica
Site da editora Pearson/Addison Wesley onde se pode encontrar alguns aplicativos (Java apples) que ajudam a entender alguns dos conceitos abordados nesta aula. 

Segue a url: http://wps.aw.com/br_kurose_redes_3/40/10271/2629597.cw/index.html
- Também neste site da editora Pearson (www.aw.com/kurose.br) pode-se encontrar outros recursos didáticos. 
Escolher um recurso e testar.





