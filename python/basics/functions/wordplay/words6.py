import scrabble

letters = "abcdefghijklmnopqrstuvwxyz"

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

print(counter)
