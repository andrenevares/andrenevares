# Plano de Aula 01

No início da informática os computadores eram máquinas enormes, normalmente conhecidas como **Mainframe**, que trabalhavam de forma isolada centralizando o processamento dos dados da organização. Estas máquinas eram acessadas a partir de Terminais, sem capacidade de processamento, formando as **Redes de Teleprocessamento**.

O desenvolvimento tecnológico levou à redução de custos do hardware levando ao desejo de distribuir o poder computacional, que até então ficava centralizado. Esta evolução levou a introdução dos microcomputadores no cenário das empresas. Nessa nova estrutura os computadores não se comunicavam uns com os outros, o que acarretava uma série de problemas com duplicação de recursos e dificuldades para o compartilhamento de informações.

Nesse cenário, visando sanar as dificuldades apresentadas, surgiram as **Redes de Computadores**, onde um sistema de comunicação foi introduzido para interligar os equipamentos de processamentos de dados (estações de trabalhos), antes operando isoladamente com o objetivo de permitir o compartilhamento de recursos. O sistema de comunicação é constiuído de enlaces físicos (meio de transmissão) e de um conjunto de regras (protocolo) que permite a interligação dos vários módulos processadores.

### 1.1 Classificação das Redes de Computadores

Uma Redes de Comutadores, **quanto a sua abrangência geográfica**, pode ser classificada como:

- **Rede Local (LAN - Local Area Network)** - é uma rede privada que interliga equipamentos em uma região geográfica bem definida, como um escritório, um prédio, uma sala, etc. São projetadas para permitir o compartilhamento de recursos entre os usuários. Possuem normalmente uma grande velocidade de transmissão e podem ser com fio (cabeadas) ou sem fio (WiFi).
- **Rede Metropolitana (MAN - Metropolitan Area Network)** - cobrem a área de um distrito ou até de uma cidade. É projetada para fornecer alta velocidade aos clientes, como por exemplo as redes que as empresas de telecomunicações montam para permitir o acesso à internet para seus clientes, seja via ADSL (Velox, GVT) ou CABO (Virtua).
- **Rede de Longa Distância (WAN - Wide Area Network)** - Normalmente interligam redes locais e abrangem uma grande área geográfica, como um pais, um continente ou até o mundo todo.

### O Modelo OSI

O modelo de referência OSI da ISO, lançado em 1984 é composta de **7 camadas** e cada uma executa uma função específica da rede, trazendo as seguintes vantagens:

- Decompõe as comunicações de rede em partes menores e mais simples, facilitando sua aprendizagem e compreensão.
- Padroniza os componentes de rede, permitindo o desenvolvimento e o suporte por parte de vários fabricantes.
- Possibilita a comunicação entre tipos diferentes de hardware e de software de rede.
- Evita que as modificações em uma camada afetem as outras, possibilitando maior rapidez no seu desenvolvimento.

### Camada 7: A camada de aplicação

A camada de aplicação é a camada OSI mais próxima do usuário; ela fornece serviços de rede aos aplicativos do usuário como navegadores, clientes de correio eletrônico, aplicativos bancários e outros que desejam acessar a rede.

### Camada 6: A camada de apresentação
Sua função é realizar transformações adequadas nos dados, tais como a compressão de textos, a criptografia, a conversão de padrões de terminais e arquivos para padrões de rede e vice-versa.

### Camada 5: A camada de sessão
O nível de sessão fornece mecanismos que permitem estruturar os circuitos oferecidos pelo nível de transporte, ordenando a conversação entre equipamentos.

### Camada 4: A camada de transporte
O nível de rede dependendo da tecnologia utilizada pode ou não garantir que um pacote chegue a seu destino. Desta forma a camada de transporte pode também implementar a confirmação de entrega.

No nível de transporte a comunicação é fim a fim, isto é, a entidade do nível de transporte da máquina origem se comunica com a entidade do nível de transporte da máquina destino. Isto pode não acontecer nos níveis físico, de enlace e de rede, onde a comunicação se dá entre máquinas adjacentes (vizinhos) na rede.

### Camada 3: A camada de rede
A camada de rede é uma camada complexa que fornece conectividade e seleção de caminhos entre dois sistemas hosts que podem estar localizados em redes geograficamente separadas.

### Camada 2: A camada de enlace
A camada de enlace pode fornecer trânsito seguro de dados através de um link físico. Fazendo isso, a camada de enlace trata do endereçamento físico (em oposição ao endereçamento lógico), da topologia de rede, do acesso à rede, da notificação de erro, da entrega ordenada de quadros e do controle de fluxo.

### Camada 1: A camada física
A camada física define as especificações elétricas, mecânicas, funcionais e de procedimentos para ativar, manter e desativar o link físico entre sistemas finais. Características como níveis de voltagem, temporização de alterações de voltagem, taxas de dados físicos, distâncias máximas de transmissão, conectores físicos e outros atributos similares são definidas pelas especificações da camada física.


- Site da editora Pearson/Addison Wesley onde se pode encontrar alguns aplicativos (Java apples) que ajudam a entender alguns dos conceitos abordados nesta aula. Segue a url: http://wps.aw.com/br_kurose_redes_3/40/10271/2629597.cw/index.html

- Também neste site da editora Pearson (www.aw.com/kurose.br) pode-se encontrar outros recursos didáticos. Escolher um recurso e testar.
