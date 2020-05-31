import os

arquivo = 'noticia.txt'

# Pegando o diretório atual do script
diretorio = os.path.dirname(os.path.abspath(__file__))

# Colocando o nome do arquivo
diretorio_certo = os.path.join(diretorio, arquivo)

# É sempre melhor lidar com arquivos por meio do bloco with
with open(diretorio_certo, 'r') as meu_arquivo:
    meu_texto = meu_arquivo.read()

# Print
print(meu_texto)
