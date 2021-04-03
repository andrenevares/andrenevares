import os

os.chdir('d:\SEFA\OneDrive\SEFA\MONITORAMENTO\PDFS')

with open("lista_de_arquivos.txt", "w") as f:
    for arquivo in os.listdir():
        f.write(arquivo + ' \n')