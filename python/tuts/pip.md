Gerenciando Pacotes com PIP
> Tradução da documentação 3.804 por André Nevares 
## Fonte:
Item: 12.3. Managing Packages with pip

## Instrodução

Você pode instalar, atualizar e remover pacores usando o programa chamado de ```pip```

Por padrão ```pip``` irá instalar pacotes do Python Package Index https://pypi.org.

Você pode navegar pelo Índice de Pacotes Python usando o seu navegador ou pode usar o recurso de pesquisa do ```pip```:


```pip search astronomy```

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

Collecting requests==2.6.0

Se você reexecutar imediatamente esse comando, ```pip``` irá perceber que a versão que você quer já está instalada e não fará mais nada...


Você pode fornecer uma versão diferente se vocë quiser...

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
pip freeze will produce a similar list of the installed packages, but the output uses the format that pip install expects. A common convention is to put this list in a requirements.txt file:

(tutorial-env) $ pip freeze > requirements.txt
(tutorial-env) $ cat requirements.txt
novas==3.1.1.3
numpy==1.9.2
requests==2.7.0
The requirements.txt can then be committed to version control and shipped as part of an application. Users can then install all the necessary packages with install -r:

(tutorial-env) $ pip install -r requirements.txt
Collecting novas==3.1.1.3 (from -r requirements.txt (line 1))
  ...
Collecting numpy==1.9.2 (from -r requirements.txt (line 2))
  ...
Collecting requests==2.7.0 (from -r requirements.txt (line 3))
  ...
Installing collected packages: novas, numpy, requests
  Running setup.py install for novas
Successfully installed novas-3.1.1.3 numpy-1.9.2 requests-2.7.0
pip has many more options. Consult the Installing Python Modules guide for complete documentation for pip. When you’ve written a package and want to make it available on the Python Package Index, consult the Distributing Python Modules guide.
