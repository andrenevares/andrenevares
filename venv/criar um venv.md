# Virtual Env (python)

## Pre requisitos
- VSCODE
- Sistema Windows (no meu caso estou usando o 10)
- Ter uma versão python instalada

## Habilitando Scripts
Para que o VSCODE possa executar um script você tem que dar a permissão para ele.
Por padrãp (by default) o powershell vem como restricted
Pois bem... Você pode verificar isso..

## Verificando

Você pode verificar qual a política de segurança está habilitada para isso basta abrir um terminal powershell e digitar ```Get-ExecutionPolicy```

Deverá retornar

```Restricted```

Pois bem... Queremmos setar como unrestricted... 
Acontece, que se tentarmos digitar isso diretamente no terminal powershell provavelmente receberemos alguma mensagem do sistema informando que não temos permissão para isso ok?

## Executar powershell como administrador
Dessa forma vá na barra de pesquisa do seu windows e digite powershell.
Depois clique com o botão direito do mouse e selecione *Rodar como Administrador*
![](https://github.com/andrenevares/codigos/blob/master/Ambiente%20Virtual/andre-nevares-power-shell-execute-como-administrador.png?raw=true)


## Para que serve?
Isola um ambiente virtual.

## Criando um Ambiente Virtual
Se vc quiser instalar com Python3

### 1. Vá até o diretório que você pretende criar...
No meu caso eu vou querer criar um chamado flaskenv

### 2. Digite o comando 
```
python -m venv flaskenv
```

sabendo que flaskenv poderia ser qualquer nome que você escolhesse para o seu ambiente virtual

### 3.  Aguarde alguns segundos
Agaurde alguns segundos e pronto
Deve ter sido criado dentro do seu HD um ambiente virtual com o nome que você escolheu


# Fazendo o VSCODE ativar o virtual env
A maneira mais fácil de você fazer isso é entrando no settigns do VSCODE

## 1. CONTROL + SHIFT + P

## 2. Preferences: Open Workspace Settings

## 3. Selecione para abrir a configuracao em formato JSON.

## 3. entre no virtual enviroment que você criou e verifique o endereco da pasta script
dentro da pasta script ficam os seus arquivos...
logo entre no seu diretório e digite dentro do arquivo JSON a seguinte sintax:

```
"python.pythonPath": "D:\\flaskenv\\scripts\\python.exef"
```

```
PS D:\flaskenv\scripts> ./activate
```

