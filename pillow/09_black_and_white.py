from PIL import Image
import os

foto = Image.open('filhote_01.jpg')
foto.convert(mode='L').save('./output/filhote_01_bw.jpg')