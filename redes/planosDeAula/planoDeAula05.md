# Plano de Aula 05

A Ethernet foi primeira LAN do mundo, sua versão original foi criada por. Robert etcalfe e seus colegas da Xerox há mais de 30 anos.

O primeiro padrão Ethernet foi publicado em 1980 por um consórcio da Digital Equipment Corporation, Intel e Xerox (DIX)., como Metcalfe queria que a Ethernet fosse um padrão compartilhado com o qual todos pudessem se beneficiar ela foi lançada como um padrão aberto. Os primeiros produtos desenvolvidos no padrão Ethernet foram vendidos no início da década de 80.

## Encapsulamento de Dados

O Encapsulamento de dados fornece três funções principais:
- Delimitação de quadros
- Endereçamento
- Detecção de erros

O processo de encapsulamento de dados inclui a montagem de quadros antes da transmissão e a análise de quadros em seu recebimento. Ao formar o quadro, a camada MAC adiciona um cabeçalho e um trailer à PDU da Camada

O uso de quadros ajuda na transmissão de bits, pois eles são colocados no meio e no agrupamento de bits no nó receptor.

O processo de enquadramento oferece delimitadores importantes que são utilizados para identificar um grupo de bits que compõe um quadro. Este processo oferece sincronização entre os nós transmissores e receptores.

O processo de encapsulamento também fornece endereçamento da camada de Enlace de Dados. Cada cabeçalho Ethernet adicionado ao quadro contém o endereço físico (endereço MAC) que permite que um quadro seja entregue a um nó de destino.

Uma função adicional do encapsulamento de dados é a detecção de erros.

Cada quadro Ethernet contém um trailer com verificação de redundância cíclica (CRC) do conteúdo do quadro. Depois do recebimento de um quadro, o nó receptor cria uma CRC para comparar com a que está no quadro. Se esses dois cálculos de CRC corresponderem, é possível ter certeza de que o quadro foi recebido sem erros.

## O Controle de Acesso ao Meio Físico
A Ethernet controla a colocação e a remoção de quadros do meio, isso inclui o
início da transmissão de quadros e a recuperação de falha na transmissão
devido a colisões.

A topologia lógica subjacente da Ethernet é um barramento multi-acesso. Isso
significa que todos os nós (dispositivos) naquele segmento de rede compartilham o meio. Isso também significa que todos os nós naquele segmento recebem todos os quadros transmitidos por qualquer nó.

Como todos os nós recebem todos os quadros, cada nó precisa determinar se um quadro deve ser aceito e processado por tal nó. Isso exige um exame do endereçamento no quadro fornecido pelo endereço MAC.

O método de controle de acesso ao meio para a Ethernet clássica é o Carrier Sense Multiple Access with Collision Detection (CSMA/CD).

## Endereçamento de Camada de Enlace

Para permitir a comunicação entre os computadores em uma rede, cada u precisa ser identificado de forma única. Assim, um computador tem um endereço físico, chamado de endereço Media Access Control (ou endereço MAC), que está gravado na placa de rede

Os endereços MAC têm 48 bits de comprimento e são expressos com doze dígitos hexadecimais. Os primeiros seis dígitos hexadecimais, administrados pelo IEEE, identificam o fabricante ou fornecedor e, portanto, compreendem o Organizational Unique Identifier (OUI). Os seis dígitos hexadecimais restantes compreendem o número serial de interface, ou outro valor administrado pelo fornecedor específico.

## Transmissão na Camada de Enlace
Em uma rede quando um dispositivo quer enviar dados para outro dispositivo, ele pode abrir um caminho de comunicação com o outro dispositivo usando o seu endereço MAC. Quando uma origem envia dados em uma rede, os dados carregam o endereço MAC do destino pretendido. Como esses dados trafegam pelos meios da rede, a placa de rede em cada dispositivo na rede verifica se o seu endereço MAC corresponde ao endereço de destino físico carregado pelo pacote de dados. Se não corresponder, a placa de rede descarta o pacote de dados. Se não houver correspondência, a placa de rede ignora o pacote de dados e permite que ele continue sua viajem pela rede até a estação seguinte.

À medida que os dados trafegam pelo cabo, a placa de rede faz essa verificação em cada estação. A placa de rede verifica o endereço de destino no cabeçalho do pacote para determinar se o pacote está endereçado adequadamente. Quando os dados passam pela sua estação de destino, a placa de rede dessa estação faz uma cópia, retira os dados do envelope e os passa ao computador.

## Topologia Estrela na Ethernet Legada

O padrão 10BASET utiliza como concentrador um hub.

Os hubs concentram as conexões. Em outras palavras, eles pegam um grupo de nós e permitem que a rede os veja como uma só unidade. Quando o quadro chega em uma porta, é copiado para as outras portas para que todos os egmentos na LAN recebam o quadro. Utilizar o hub nesta topologia de arramento aumentou a confiabilidade da rede a permitir que qualquer cabo falhe sem interromper toda a rede.

O hub fornece um meio compartilhado half duplex sujeito as colisões.

À medida que mais dispositivos eram adicionados a uma rede Ethernet, a quantidade de colisões de quadros aumentou consideravelmente. Durante períodos de baixa atividade de comunicação, as poucas colisões que ocorrem são gerenciadas pelo CSMA/CD, com pouco ou nenhum impacto no desempenho. No entanto, à medida que o número de dispositivos e o consequente tráfego de dados cresce, o aumento das colisões pode ter impacto considerável no trabalho dos usuários.

### Aplicação Prática Teórica
- Site da editora Pearson/Addison Wesley onde se pode encontrar alguns aplicativos (Java apples) que ajudam a entender alguns dos conceitos abordados nesta aula. Segue a url: http://wps.aw.com/br_kurose_redes_3/40/10271/2629597.cw/index.html

- Também neste site da editora Pearson (www.aw.com/kurose.br) pode-se encontrar outros recursos didáticos.

Escolher um recurso e testar.
