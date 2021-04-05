import os
import PyPDF2 as p2

os.chdir('d:\SEFA\OneDrive\SEFA\MONITORAMENTO\PDFS')

with open("lista_de_arquivos45.txt", "w") as f:
    for arquivo in os.listdir():
        extensao_procurada = arquivo.endswith('.pdf')
        if extensao_procurada:
            arquivo_aberto = open(arquivo, "rb")
            arquivo_lido = p2.PdfFileReader(arquivo_aberto)
            numero_de_paginas = arquivo_lido.getNumPages()
            pagina_pdf = arquivo_lido.getPage(0)
                
            # Extrai o texto do Arquivo PDF
            texto = pagina_pdf.extractText()

            # Trazer o número do processo do arquivo
            fim_numero_processo = texto.find("Data Processo")
            inicio_numero_processo = fim_numero_processo - 17
            numero_processo = texto[inicio_numero_processo:fim_numero_processo]

            # Trazer o texto do detalhe da origem do crédito
            inicio_detalhe_evento = texto.find("Detalhe da Origem do Crédito") + 28
            fim_detalhe_evento = texto.find("Evento")
            detalhe_evento = texto[inicio_detalhe_evento:fim_detalhe_evento]
            detalhe_evento = detalhe_evento.strip()

            f.write(arquivo + '|' + numero_processo + '|'  + detalhe_evento + '|' + str(numero_de_paginas) + ' \n')
            