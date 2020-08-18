from PIL import Image
import os

for arquivo in os.listdir('.'):
    if arquivo.endswith('.jpg'):
        print(arquivo)
