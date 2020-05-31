from gtts import gTTS
import os


meuTexto = "Calma... Eu entendi o zumbi quaterbacker, o zumbi de balde, o zumbi voador..  E tem também o zumbão!"
minhaLingua = 'pt-br'
output = gTTS(text=meuTexto, lang=minhaLingua, slow=False)
output.save("output.mp3")
os.system("start output.mp3")
