import scrabble

counter = 0

for word in scrabble.wordlist:
    if "uu" in word:
        print(word)
        counter = counter + 1

print(counter)
