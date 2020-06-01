import random
capitais_dict = {
    'Acre': 'Rio Branco',
    'Alagoas': 'Maceió',
    'Amapá': 'Macapá',
    'Amazonas': 'Manaus',
    'Bahia': 'Salvador',
    'Ceará': 'Fortaleza',
    'Distrito Federal': 'Brasília',
    'Espírito Santo': 'Vitória',
    'Goiás': 'Goiânia',
    'Maranhão': 'São Luís',
    'Mato Grosso': 'Cuiabá',
    'Mato Grosso do Sul': 'Campo Grande',
    'Minas Gerais': 'Belo Horizonte',
    'Pará': 'Belém',
    'Paraíba': 'João Pessoa',
    'Paraná': 'Curitiba',
    'Pernambuco': 'Recife',
    'Piauí': 'Teresina',
    'Rio de Janeiro': 'Rio de Janeiro',
    'Rio Grande do Norte': 'Natal',
    'Rio Grande do Sul': 'Porto Alegre',
    'Rondônia: Porto Velho'
    'Roraima': 'Boa Vista',
    'Santa Catarina': 'Florianópolis',
    'São Paulo': 'São Paulo',
    'Sergipe': 'Aracaju',
    'Tocantins': 'Palmas'
}


# criamos uma lista chamada estados contendo somente as chaves do dicionário
estados = list(capitais_dict.keys())
for i in [1, 2, 3, 4, 5]:
    estado = random.choice(estados)
    capital = capitais_dict[estado]
    capital_resposta = input("Qual eh a capital de " + estado + " ??? ")

    if capital_resposta == capital:
        print("Perfeito!  Você acertou")
    else:
        print("Ops....  Incorreto.  A capital de " +
              estado + " é " + capital + ".")

print("Terminado!")
