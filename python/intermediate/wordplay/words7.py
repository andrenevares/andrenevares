import scrabble

longest = ""

for word in scrabble.wordlist:
    # if the word is equal to the reverse of the word
    # and lenght of this word is greater then the longest
    if word == word[::-1] and len(word) > len(longest):
        longest = word
print(longest)
