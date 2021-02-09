# Copiar e colar

## Usando Range
```vba
    ' Copiar intervalo e colar em um intervalo
    Sheets("ANEXO 2").Range("BR3:BX3").Copy
    ultima_linha = Sheets("ANEXO 2").Range("A1").End(xlDown).Row
    Sheets("ANEXO 2").Range("BR" & ultima_linha).Select
    Sheets("ANEXO 2").Range(Selection, Selection.End(xlUp)).Select
    ActiveSheet.Paste
```
