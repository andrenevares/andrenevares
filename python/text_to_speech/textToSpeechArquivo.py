from gtts import gTTS
import os

# The name of the txt file that is in the same folder.
myFile = 'noticia.txt'

# Getting the active script
diretorio = os.path.dirname(os.path.abspath(__file__))

# Replace BackSlah and concatenate myFile
correctPath = diretorio.replace("\\", "/") + "/" + myFile

fileToRead = open(correctPath, "r")
myLanguage = 'pt-br'

myText = fileToRead.read().replace("\n", " ")
output = gTTS(text=myText, lang=myLanguage, slow=False)
output.save("output.mp3")
fileToRead.close()
os.system("start output.mp3")
