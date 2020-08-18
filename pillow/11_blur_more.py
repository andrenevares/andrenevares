from PIL import Image, ImageFilter
import os

foto = Image.open('filhote_01.jpg')
foto.filter(ImageFilter.GaussianBlur(15)).save('./output/filhote_gaussian_blur_02.jpg')