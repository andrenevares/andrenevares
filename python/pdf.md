# Extraindo texto de um arquivo PDF

```python
import PyPDF2 as PyPDF2
arquivo_aberto = open("c:/7020206900000767.pdf", "rb")
arquivo_lido = PyPDF2.PdfFileReader(arquivo_aberto)
pagina_pdf = arquivo_lido.getPage(0)
pagina_pdf.extractText()

```
Output
```
'GOVERNO DO ESTADO DO PARÁSECRETARIA DE ESTADO DA FAZENDARelátorio do ProcessoRazão SocialInscrição EstadualTipo de DIEFZECA S.A15.151.151-1NormalPeríodo01/2052Número Processo702020690000088-8Data Processo25/17/2058Valor TotalR$ 5.235.999,84Outros CréditosDetalhe da Origem do CréditoICMS DIESELEventoOutros Créditos de ICMS autorizado pela SEFA não relacionado nos itens de 1 à 4Página 1 de 1'
```

```python
texto = pagina_pdf.extractText()
```

```python
import PyPDF2 as PyPDF2
arquivo_aberto = open("c:/7020206900000767.pdf", "rb")
arquivo_lido = PyPDF2.PdfFileReader(arquivo_aberto)
pagina_pdf = arquivo_lido.getPage(0)
texto = pagina_pdf.extractText()

fim = texto.find("Data Processo")
inicio = fim - 17

numero_processo = texto[inicio:fim]
```
Output
```
'702020690000076-7'
```
