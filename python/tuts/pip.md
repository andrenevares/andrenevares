Gerenciando Pacotes com PIP
> Tradução da documentação 3.804 por André Nevares 

## Fonte:
_Item: 12.3. Managing Packages with pip_  da documentação do python. 

## Instrodução

Você pode instalar, atualizar e remover pacores usando o programa chamado de ```pip```

Por padrão ```pip``` irá instalar pacotes do Python Package Index https://pypi.org.

## Pesquisando um nome de um pacote

Você pode navegar pelo Índice de Pacotes Python usando o seu navegador ou pode usar o recurso de pesquisa do ```pip```:

Mas... Você pode também usar o comando ```pip search```

Exemplo: ```pip search astronomy```

Resultado: 
```
astronomy (0.0.1)             - Astronomy!
catastropy (0.0dev)           - (cat)astronomy
gastropy (0.0dev)             - (g)astronomy
astromath (1.0.1)             - Library for mathematical astronomy
astro-scripts (0.4.0)         - Small scripts for astronomy
pykepler (1.0.1)              - Algorithms for positional astronomy
intake-astro (0.1.1)          - Astronomy plugins for Intake
celespy (0.0.5)               - Generic astronomy functions
(...)
```

## Alguns Sub Comandos
Pip possui uma série de subcomandos: 
- “search”, 
- “install”, 
- “uninstall”, 
- “freeze”, etc. 

Consulte [Instalando python Modulos](https://docs.python.org/3/installing/index.html#installing-index) para obter a documentação completa de ```pip```.

## Instalando a última versão de um pacote 

Para instalar a última versão basta digitar 

```pip search [nome_do_modulo]```

Exemplo se você quiser instalar um módulo que se chama ```novas``` você poderá usar

```pip install novas```

## Instalando uma versão específica de um pacote 

Você também pode instalar uma versão específica de utilizando o sinal ```==``` seguido da versão.

Imaginemos que eu queira instalar uma versão 2.6.0 do módulo requests...

```pip install requests==2.6.0```

Se você reexecutar imediatamente esse comando, ```pip``` irá perceber que a versão que você quer já está instalada e não fará mais nada...

Observação: Você pode fornecer uma versão diferente se vocë quiser...

## Atualizando para versão mais recente

```pip install --upgrade [nome_do_pacote]``` 

Se eu quiser atualizar o pacote ```pip```

```pip install --upgrade requests```

## Desinstalando um pacote - ```pip uninstall``` 

pip uninstall followed seguido de um ou mais pacotes irá remover esses pacotes do ambiente.

Ex. ```pip uninstall requests```

## pip show

pip show vai exibir as informações de um pacote específico

```pip show requests```

## pip list

pip list will display all of the packages installed in the virtual environment:

(tutorial-env) $ pip list

```
Package    Version
---------- -------
appdirs    1.4.4
distlib    0.3.1
filelock   3.0.12
pip        20.1.1
setuptools 47.1.0
six        1.15.0
virtualenv 20.0.26

```
## Pip Freeze

```pip freeze``` irá listar os pacotes instalados formatados para que o pip possa utilizar depois. 

Utilza-se como convenção colocar esta lista em um arquivo chamado ```requirements.txt```:

O requirements.txt pode ser enviado para o git junto com a aplicação. Assim, usuários poderão instalar todos os pacotes necessários utilizado o  ```pip install -r```:


## Instalando pacotes do ```requirements.txt```

```pip install -r requirements.txt```


