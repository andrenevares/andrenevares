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
'GOVERNO DO ESTADO DO PARÁSECRETARIA DE ESTADO DA FAZENDARelátorio do ProcessoRazão SocialInscrição EstadualTipo de DIEFVALE S.A15.098.182-1NormalPeríodo01/2020Número Processo702020690000076-7Data Processo10/02/2020Valor TotalR$ 8.638.020,95Outros CréditosDetalhe da Origem do CréditoICMS DIESELEventoOutros Créditos de ICMS autorizado pela SEFA não relacionado nos itens de 1 à 4Página 1 de 1'
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
