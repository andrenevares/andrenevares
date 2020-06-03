import random


class Die(object):
    def __init__(self, sides):
        self.sides = sides

    def roll(self):
        return random.randint(1, self.sides)


print("\nD6 rolls:")
d = Die(6)
print(d.roll())
print(d.roll())
print(d.roll())

print("\n\nD20 rolls:")
d2 = Die(20)
print(d2.roll())
print(d2.roll())
print(d2.roll())
