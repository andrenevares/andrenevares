 # Aplicar bordas em um intervalo


#### Versão resumida
```vba
    'Colocar bordas em um intervalo
    ultima_linha = Sheets("ANEXO 7").Range("A6").End(xlDown).Row
    
    Dim intervalo As Range
    
    Set intervalo = Sheets("ANEXO 7").Range("A6:X" & ultima_linha)

    With intervalo.Borders
        .LineStyle = xlContinuous
        .ColorIndex = 0
        .TintAndShade = 0
        .Weight = xlThin
    End With

```

#### versão anterior
```vba
    ' Aplicar bordas a um intervalor
    ultima_linha = Sheets("ANEXO 1").Range("A3").End(xlDown).Row
    Sheets("ANEXO 1").Range("DU1:EC" & ultima_linha).Borders(xlDiagonalDown).LineStyle = xlNone
    Sheets("ANEXO 1").Range("DU1:EC" & ultima_linha).Borders(xlDiagonalUp).LineStyle = xlNone
    Sheets("ANEXO 1").Range("DU1:EC" & ultima_linha).Borders(xlEdgeLeft).LineStyle = xlContinuous
    Sheets("ANEXO 1").Range("DU1:EC" & ultima_linha).Borders(xlEdgeLeft).ColorIndex = 0
    Sheets("ANEXO 1").Range("DU1:EC" & ultima_linha).Borders(xlEdgeLeft).Weight = xlThin
    Sheets("ANEXO 1").Range("DU1:EC" & ultima_linha).Borders(xlEdgeTop).LineStyle = xlContinuous
    Sheets("ANEXO 1").Range("DU1:EC" & ultima_linha).Borders(xlEdgeTop).ColorIndex = 0
    Sheets("ANEXO 1").Range("DU1:EC" & ultima_linha).Borders(xlEdgeTop).Weight = xlThin
    Sheets("ANEXO 1").Range("DU1:EC" & ultima_linha).Borders(xlEdgeBottom).LineStyle = xlContinuous
    Sheets("ANEXO 1").Range("DU1:EC" & ultima_linha).Borders(xlEdgeBottom).ColorIndex = 0
    Sheets("ANEXO 1").Range("DU1:EC" & ultima_linha).Borders(xlEdgeBottom).Weight = xlThin
    Sheets("ANEXO 1").Range("DU1:EC" & ultima_linha).Borders(xlEdgeRight).LineStyle = xlContinuous
    Sheets("ANEXO 1").Range("DU1:EC" & ultima_linha).Borders(xlEdgeRight).ColorIndex = 0
    Sheets("ANEXO 1").Range("DU1:EC" & ultima_linha).Borders(xlEdgeRight).Weight = xlThin
    Sheets("ANEXO 1").Range("DU1:EC" & ultima_linha).Borders(xlInsideVertical).LineStyle = xlContinuous
    Sheets("ANEXO 1").Range("DU1:EC" & ultima_linha).Borders(xlInsideVertical).ColorIndex = 0
    Sheets("ANEXO 1").Range("DU1:EC" & ultima_linha).Borders(xlInsideVertical).Weight = xlThin
    Sheets("ANEXO 1").Range("DU1:EC" & ultima_linha).Borders(xlInsideHorizontal).LineStyle = xlContinuous
    Sheets("ANEXO 1").Range("DU1:EC" & ultima_linha).Borders(xlInsideHorizontal).ColorIndex = 0
    Sheets("ANEXO 1").Range("DU1:EC" & ultima_linha).Borders(xlInsideHorizontal).Weight = xlThin

```
