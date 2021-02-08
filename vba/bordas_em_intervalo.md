 # Aplicar bordas em um intervalo

```vba
    ' Aplicar bordas a um intervalor
    Sheets("ANEXO 2").Range("BM1:BN" & ultima_linha).Borders(xlDiagonalDown).LineStyle = xlNone
    Sheets("ANEXO 2").Range("BM1:BN" & ultima_linha).Borders(xlDiagonalUp).LineStyle = xlNone
    Sheets("ANEXO 2").Range("BM1:BN" & ultima_linha).Borders(xlEdgeLeft).LineStyle = xlContinuous
    Sheets("ANEXO 2").Range("BM1:BN" & ultima_linha).Borders(xlEdgeLeft).ColorIndex = 0
    Sheets("ANEXO 2").Range("BM1:BN" & ultima_linha).Borders(xlEdgeLeft).Weight = xlThin
    Sheets("ANEXO 2").Range("BM1:BN" & ultima_linha).Borders(xlEdgeTop).LineStyle = xlContinuous
    Sheets("ANEXO 2").Range("BM1:BN" & ultima_linha).Borders(xlEdgeTop).ColorIndex = 0
    Sheets("ANEXO 2").Range("BM1:BN" & ultima_linha).Borders(xlEdgeTop).Weight = xlThin
    Sheets("ANEXO 2").Range("BM1:BN" & ultima_linha).Borders(xlEdgeBottom).LineStyle = xlContinuous
    Sheets("ANEXO 2").Range("BM1:BN" & ultima_linha).Borders(xlEdgeBottom).ColorIndex = 0
    Sheets("ANEXO 2").Range("BM1:BN" & ultima_linha).Borders(xlEdgeBottom).Weight = xlThin
    Sheets("ANEXO 2").Range("BM1:BN" & ultima_linha).Borders(xlEdgeRight).LineStyle = xlContinuous
    Sheets("ANEXO 2").Range("BM1:BN" & ultima_linha).Borders(xlEdgeRight).ColorIndex = 0
    Sheets("ANEXO 2").Range("BM1:BN" & ultima_linha).Borders(xlEdgeRight).Weight = xlThin
    Sheets("ANEXO 2").Range("BM1:BN" & ultima_linha).Borders(xlInsideVertical).LineStyle = xlContinuous
    Sheets("ANEXO 2").Range("BM1:BN" & ultima_linha).Borders(xlInsideVertical).ColorIndex = 0
    Sheets("ANEXO 2").Range("BM1:BN" & ultima_linha).Borders(xlInsideVertical).Weight = xlThin
    Sheets("ANEXO 2").Range("BM1:BN" & ultima_linha).Borders(xlInsideHorizontal).LineStyle = xlContinuous
    Sheets("ANEXO 2").Range("BM1:BN" & ultima_linha).Borders(xlInsideHorizontal).ColorIndex = 0
    Sheets("ANEXO 2").Range("BM1:BN" & ultima_linha).Borders(xlInsideHorizontal).Weight = xlThin
```
