import os
import unidecode


# The name of the txt file that is in the same folder.
myFile = 'noticia.txt'

# Getting the active script
path = os.path.dirname(os.path.abspath(__file__))

# Replace BackSlash and concatenate myFile
correctPath = path.replace("\\", "/") + "/" + myFile

# Open file
fileToRead = open(correctPath, "r", encoding="UTF-8")

# Store text in a variable
myText = fileToRead.read()
myText = myText.replace("à", "a")
myText = myText.replace("á", "a")
myText = myText.replace("ã", "a")
myText = myText.replace("À", "a")
myText = myText.replace("Ã", "a")
myText = myText.replace("ã", "a")
myText = myText.replace("Ã", "a")
myText = myText.replace("â", "a")
myText = myText.replace("É", "e")
myText = myText.replace("é", "e")
myText = myText.replace("Ê", "e")
myText = myText.replace("ê", "e")
myText = myText.replace("Í", "i")
myText = myText.replace("í", "i")
myText = myText.replace("õ", "o")
myText = myText.replace("õ", "o")
myText = myText.replace("Ô", "o")
myText = myText.replace("ô", "o")
myText = myText.replace("ó", "o")
myText = myText.replace("Ó", "o")
myText = myText.replace("Ú", "u")
myText = myText.replace("ú", "u")
myText = myText.replace("Ç", "c")
myText = myText.replace("ç", "c")
myText = myText.replace("ç", "c")
myText = myText.replace("“", "'")
myText = myText.replace("”", "'")
myText = myText.replace("―", "-")


# Print
print(myText)
