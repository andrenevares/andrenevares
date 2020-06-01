f = open("scores.txt", "w")

while True:
    participant = input("Paticipant name? ")
    if participant == "quit":
        print("Quitting")
        break

    score = input("Score from " + participant + "?")
    f.write(participant + "," + score + "\n")

f.close()
