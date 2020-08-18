from PIL import Image, ImageFilter
import os

foto = Image.open('filhote_01.jpg')
foto.filter(ImageFilter.GaussianBlur()).save('./output/filhote_gaussian_blur_01.jpg')