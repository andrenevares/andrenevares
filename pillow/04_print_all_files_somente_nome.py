from PIL import Image
import os

for arquivo in os.listdir('.'):
    if arquivo.endswith('.jpg'):
        foto = Image.open(arquivo)
        foto_nome, foto_extensao = os.path.splitext(arquivo)
        print(f'Nome do arquivo: {foto_nome}, possui a extensão {foto_extensao}')
        