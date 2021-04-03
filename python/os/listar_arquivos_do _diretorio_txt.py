import os

os.chdir('d:\SEFA\OneDrive\SEFA\MONITORAMENTO\PDFS')

for f in os.listdir():
    arquivo_nome, extensao_arquivo = os.path.splitext(f)
    print(arquivo_nome)