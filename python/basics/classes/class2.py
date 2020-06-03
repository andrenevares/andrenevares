class Greeter(object):
    def __init__(self, name):
        self.name = name

    def hello(self):
        print("Hello " + self.name)

    def goodbye(self):
        print("Goodbye " + self.name)


g = Greeter("André")
g.hello()
g.goodbye()

g2 = Greeter("Camila")
g2.hello()
g2.goodbye()
