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

### Mudar o diretório para o diretório onde fica o arquivo
>>> os.chdir('d:\SEFA\OneDrive\SEFA\MONITORAMENTO\PDFS')

Para ter certeza que mudou o seu diretório, rode o comando ```getcwd()```
```python
>>> os.getcwd()
'd:\\SEFA\\OneDrive\\SEFA\\MONITORAMENTO\\PDFS'
```



