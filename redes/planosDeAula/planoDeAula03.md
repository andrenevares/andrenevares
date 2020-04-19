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


| Padrão T568B | Padrão T568A   |
| :-: |  :-: | 
| 1 branco do laranja (Recepção) | 1 branco do verde (transmissão) |
| 2 laranja (Recepção)  | 2 verde (transmissão)  |
| 3 branco do verde (Transmissão) |  3 branco do laranja (Recepção) |
| 4 azul    | 4 azul  |
| 5 branco do azul    | 5 branco do azul  |
| 6 verde (Transmissão)  |  6 laranja (Recepção) |
| 7 branco do marrom  | 7 branco do marrom  |
| 8 marrom  | 8 marrom  |







