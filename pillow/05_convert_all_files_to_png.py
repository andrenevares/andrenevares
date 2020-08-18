from PIL import Image
import os

for arquivo in os.listdir('.'):
    if arquivo.endswith('.jpeg'):
        foto = Image.open(arquivo)
        foto_nome, foto_extensao = os.path.splitext(arquivo)
        foto.save('./output/pngs/{}.jpg'.format(foto_nome))
        