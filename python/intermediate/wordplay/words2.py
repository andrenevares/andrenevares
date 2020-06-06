# There is any letter in english that never appears double in a word
import scrabble
import string

# print all letters that never appear double
for letter in string.ascii_lowercase:
    exists = False
    for word in scrabble.wordlist:
        if letter * 2 in word:
            exists = True
            break
    if not exists:
        print("There is no English Words with a doule " + letter)
