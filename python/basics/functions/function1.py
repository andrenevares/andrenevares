def greeting(name):
    print("Olá!  Bem vindo ao python! " + name)


def soma(numbers):
    total = 0
    for number in numbers:
        total = total + number
        return total


def comeca_com_vogal(word_list):
    lista_de_vogais = []
    for word in word_list:
        if word[0] in "AEIOU":
            lista_de_vogais.append(word)
    return word_list
