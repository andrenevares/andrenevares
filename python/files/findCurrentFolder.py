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

# Print
print(myText)
