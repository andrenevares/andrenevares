from PIL import Image
import os

size_400 = (400,400)
size_700 = (700,700)

for arquivo in os.listdir('.'):
    if arquivo.endswith('.jpg'):
        foto = Image.open(arquivo)
        arquivo_nome, arquivo_extensao = os.path.splitext(arquivo)
        
        foto.thumbnail(size_400)
        foto.save('./400/{}_400{}'.format(arquivo_nome, arquivo_extensao))

        foto.thumbnail(size_700)
        foto.save('./700/{}_700{}'.format(arquivo_nome, arquivo_extensao))