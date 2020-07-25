# Configurando VsCode para Python
Neste tutorial vamos aprender como instalar o Visual Studio Code e como configurar o nosso ambiente python.

talk Python mike kenedy
https://training.talkpython.fm/

VsCode
https://code.visualstudio.com/

Visual Studio Code é diferente do Visual Studio.
Visual Studio é uma IDE completa.

VSCODE 
- Free
- apenas faça o dowload e instale
- Com várias extensões




## Barra de Atividades
1. Explore (arquivos)
2. Procurar 
3. integraçã do Git
4. Debugging (muitos outros não tem)
5. Extenões 

# Extensões do VSCode
A extensão mais popular é o Pthton com mais ou menos 42 milhões de dowloads
O segundo mais popular não possui nem a metade

## Python
Linting, Debugging (multi-threaded, remote)...

Vou abrir um arquivo python.
No meu caso deixei um arquivo script1.py

O código do script abaixo vai
````
import sys

print(sys.version)
print(sys.executable)

def greet(who_to_greet):
    greeting = f'Hello, {who_to_greet}'
    return greeting

print(greet('World'))
print(greet('Nevares'))
````

Esse código vai me permitir saber qual a versão do python python que está instalado bem como onde está o executável
Depois vai fazer uma saudação 

Podemos executar
1. Clicando com o botão direito do mouse na parte onde fica o código (módulo)
2. Clicando no Play



Se quisermos mudar a versão do Python... 
No rodapé do VsCode, próximo ao canto direito
Podemos simplesmente clicar na versÃO do python e escolher no topo do VSCODE a versão que desejamos executar

Ao mudar a versáo do Python você vai ver que foi criada uma pasta chamada __.vscode__ e dentro desse diretório haverá o arquivo __settings.json__.

__settings.json__ possui as configurações do python


Color Pallete
> Shortcut: Ctrl  + Shift + P

## Extensão: Predawn Theme Kit

# Mudando os ícones na nossa barra 
1. Instale Ayu extsensão
2. Ele vai se sobrepor ao Predawn
3. Selecione Predawn
4. Abra a a Comamd Pallet
5. File Icon Theme
6. Selecione Ayu

Agora veja que aque a parte visual da barra lateral mudou bastante e para melhor não?


Até agora nos trabalhamos configurações Globais do VScode.

Mas existem muitas outras que podemos fazer.

Vamos clicar no ícone de engrenagem no canto inferior direito.

Vamos trabalhar em settings.

Você pode mudar suas configurações usando a interface do usuário que o Vscode disponibiliza, mas podemos alterar o arquivos JSON

Vamos abir a palheta de comando e digitar
>Default Settings


# Criar um Ambiente virtual
```python -m venv venv```
quando você criar um virtual enviroment você terá que selecionar a versão do python venv

Ativar no seu terminal

Mas se você quiser e tiver um virtual enviroment específico você pode colocar como HARD CODE

Se você tiver um ambiente virtual e quiser mudar. basta alterar o caminho que está .vscode/settings.json


# SHIFT + ALT + F

## CTRL + SPACE

# Code Runner
Run code snippet or code file for multiple languages: C, C++, Java, JavaScript, PHP, Python, Perl, Perl 6, Ruby, Go, Lua, Groovy, PowerShell, BAT/CMD, BASH/SH, F# Script, F# (.NET Core), C# Script, C# (.NET Core), VBScript, TypeScript, CoffeeScript, Scala, Swift, Julia, Crystal, OCaml Script, R, AppleScript, Elixir, Visual Basic .NET, Clojure, Haxe, Objective-C, Rust, Racket, Scheme, AutoHotkey, AutoIt, Kotlin, Dart, Free Pascal, Haskell, Nim, D, Lisp, Kit, V, and custom command

## CTRL + ALT + N


## Run Python File in Terminal
Clicar com botão direito no espaço do código
> Você pode rodar um programa como 

# Para que o GIT ignore algumas alterações
Por exemplo, quando temos dentro do nosso diretório um virtual enviroment
nesse caso precisamos ter um arquivo chamado __.gitignore__

Código do __.gitignore__
```
venv
.vscode
```

# Shortcuts
