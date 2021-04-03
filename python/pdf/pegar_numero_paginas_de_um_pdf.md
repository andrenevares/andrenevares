# Como trazer o número de paginas de um PDF em Python?

Nesse tutorial vou mostrar como trazer o número de páginas de um arquivo PDF.

Para isso precisaremos:
- Módulo ```os```
- Módulo ```PyPDF2```

Vamos fazer por linhas de comando mesmo!  

__Passo 1__: abrir o terminal ```cmd```

__Passo 2__: abir o python ```python```

```python
>>> import os
>>> import PyPDF2
```

### Pegar o diretório atual
```python
>>> os.getcwd()
'C:\\Users\\MICRO'
```

## 1. Diretório do arquivo
```python
>>> os.chdir('C:\meuDrive\MinhaPasta\DiretorioDoPdf')
```

### Para ter certeza que mudou o seu diretório, rode o comando ```getcwd()```
```python
>>> os.getcwd()
'C:\\meuDrive\\MinhaPasta\\DiretorioDoPdf'
```

## 2. Nome do arquivo
```python
>>> arquivo = 'qualquer_nome.pdf'
```


## 3. Abrir
```python
>>> arquivo_aberto = open(arquivo,"rb")
```

## 4. Ler o arquivo
```
>>> arquivo_lido = PyPDF2.PdfFileReader(arquivo_aberto)
```



## 5. Fazer o que quer com o PDF
```
>>> arquivo_lido.getNumPages()
1
```



