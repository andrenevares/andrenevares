from PIL import Image
import os

foto = Image.open('filhote_01.jpg')
foto.rotate(90).save('./output/filhote_01_rod_90.jpg')