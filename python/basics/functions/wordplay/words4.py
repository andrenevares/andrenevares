import scrabble
counter = 0
for word in scrabble.wordlist:
    if "q" in word and "u" not in word:
        counter = counter + 1
        print(word)

print("\nTotal found: " + str(counter))
