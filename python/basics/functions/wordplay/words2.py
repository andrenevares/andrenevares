import scrabble

counter = 0
for word in scrabble.wordlist:
    if "yy" in word:
        print(word)
        counter = counter + 1

print(counter)
