import scrabble

letters = "abcdefghijklmnopqrstuvwxyz"


def has_a_double(letter):
    for word in scrabble.wordlist:
        if (letter + letter) in word:
            return True
    return False


for letter in letters:
    if not has_a_double(letter):
        print(letter + " never appears doubled.")
