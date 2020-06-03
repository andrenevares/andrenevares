import random


class Die(object):
    def __init__(self, sides):
        self.sides = sides

    def roll(self):
        return random.randint(1, self.sides)


class Deck(object):
    def shuffle(self):
        suits = ["Paus", "Ouro", "Espadas", "Copas"]
        ranks = ["1", "2", "3", "4", "5", "6", "7", "8",
                 "9", "10", "J", "Q", "K", "Ás"]
        self.cards = []
        for suit in suits:
            for rank in ranks:
                self.cards.append(rank + " de " + suit)

        random.shuffle(self.cards)

    def deal(self):
        return self.cards.pop()

