# Limpar Valores de um range


## Comando da microsoft
```vba
Worksheets("Sheet1").Range("A1:G37").Clear
```

## Apagar até última linha encontrada
```vba
Sub limpar_de_celula_A_ate_ultima_linha()
    ' Apagar range considerando a última linha
    ultima_linha = Sheets("ANEXO 2").Range("A1").End(xlDown).Row
    Sheets("ANEXO 1").Range("AJ3:AJ" & ultima_linha).Clear
End sub
```
