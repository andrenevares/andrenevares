# How find word that use all vowels
import scrabble

vowels = "aeiou"
counter = 0


def has_all_vowels(word):
    for vowel in vowels:
        if vowel not in word:
            return False
    return True


for word in scrabble.wordlist:
    if has_all_vowels(word):
        print(word)
        counter = counter + 1

print("\nThe number of occurencies: " + str(counter))
