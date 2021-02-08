' Macros aplicadas em fiscalizações de DIFAL
' desenvolvido por André Nevares
' Auditor Fiscal de Receitas Estaduais
' andre.nevares@sefa.pa.gov.br
' andre.nevares@gmail.com


Sub difal_passo_01()
    
    Dim nome_da_aba As String
    Dim checar_planilha As Boolean
    
    nome_da_aba = "ANEXO 2"
    checar_planilha = False
        
       
    'renomear abas
    Sheets("Difal por Produto NFe (Novo)").name = "ANEXO 1"
    Sheets("Difal por NFe").name = "ANEXO 2"
    
    ' Em todas as células de todas as abas - Centralizar (horiz. e vertical)
    Sheets(1).Select
    
    For i = 1 To Sheets.Count
        Sheets(i).Select
        Cells.Select
        Selection.NumberFormat = "General"
        Selection.HorizontalAlignment = xlCenter
        Selection.VerticalAlignment = xlCenter
        Selection.Columns("A:FC").EntireColumn.AutoFit
        Range("A1").Select
        Application.CutCopyMode = False
    Next i
 
   ' Deletar linhas que estão vazias no topo
    Sheets("ANEXO 1").Rows(1).EntireRow.Delete
    Sheets("ANEXO 2").Rows(1).EntireRow.Delete
    Sheets("NFe Devolução Retorno e Remessa").Rows(1).EntireRow.Delete
    Sheets("Difal por CTe").Rows(1).EntireRow.Delete
    Sheets("NFe Anulação Serviço Transporte").Rows(1).EntireRow.Delete
    Sheets("Relação CTe x NFe").Rows(1).EntireRow.Delete
    Sheets("DIFAL NFe x Pagamento 1141").Rows(1).EntireRow.Delete
    Sheets("DIFAL CTe x Pagamento 1141").Rows(1).EntireRow.Delete
    Sheets("TAD NFe Fronteira").Rows(1).EntireRow.Delete
    Sheets("TAD CTe Fronteira").Rows(1).EntireRow.Delete
    Sheets("Pagamentos Dest. 5006 (AINF)").Rows(1).EntireRow.Delete
    Sheets("Pagamentos 1141").Rows(1).EntireRow.Delete
    Sheets("CFOP Entrada").Rows(1).EntireRow.Delete
    Sheets("Pagamentos 1177 (Emissor)").Rows(1).EntireRow.Delete
    
    
    ' -------------------------------------------------------------
   
   
    ' Formatar as células das colunas tipo data
    Sheets("ANEXO 1").Columns("B").NumberFormat = "m/d/yyyy"
    Sheets("ANEXO 1").Columns("BS").NumberFormat = "m/d/yyyy"
    Sheets("ANEXO 1").Columns("BV").NumberFormat = "m/d/yyyy"
    Sheets("ANEXO 1").Columns("P").NumberFormat = "m/d/yyyy"
    Sheets("ANEXO 2").Columns("B").NumberFormat = "m/d/yyyy"
    Sheets("ANEXO 2").Columns("AQ").NumberFormat = "m/d/yyyy"
    Sheets("ANEXO 2").Columns("AS").NumberFormat = "m/d/yyyy"
    Sheets("Difal por CTe").Columns("BH").NumberFormat = "m/d/yyyy"
    Sheets("Pagamentos Dest. 5006 (AINF)").Columns("E").NumberFormat = "m/d/yyyy"
 
 
    ' -------------------------------------------------------------


    ' Formatar as células das colunas tipo número
    Sheets("ANEXO 1").Columns("BG:BK").Style = "Comma"
    Sheets("ANEXO 1").Columns("BA:BE").Style = "Comma"
    Sheets("ANEXO 1").Columns("BL:BQ").Style = "Comma"
    Sheets("ANEXO 1").Columns("AD:AO").Style = "Comma"
    Sheets("ANEXO 1").Columns("CJ").Style = "Comma"
    Sheets("ANEXO 2").Columns("V:W").Style = "Comma"
    Sheets("ANEXO 2").Columns("X:AJ").Style = "Comma"
    Sheets("ANEXO 2").Columns("AN:AP").Style = "Comma"
    Sheets("ANEXO 2").Columns("AS").Style = "Comma"
    Sheets("ANEXO 2").Columns("AY:BG").Style = "Comma"
    Sheets("Difal por CTe").Columns("AS:BF").Style = "Comma"
    Sheets("Difal por CTe").Columns("BO:BQ").Style = "Comma"
    Sheets("DIFAL NFe x Pagamento 1141").Columns("E:G").Style = "Comma"
    Sheets("DIFAL CTe x Pagamento 1141").Columns("E:G").Style = "Comma"
    Sheets("Pagamentos Dest. 5006 (AINF)").Columns("F:F").Style = "Comma"
    Sheets("Pagamentos 1141").Columns("G:G").Style = "Comma"
    Sheets("Pagamentos 1177 (Emissor)").Columns("H:H").Style = "Comma"

    
    ' -------------------------------------------------------------


    ' Alinhamentos a esquerda de determinadas colunas
    Sheets("ANEXO 1").Columns("G:G").HorizontalAlignment = xlLeft
    Sheets("ANEXO 1").Columns("K:K").HorizontalAlignment = xlLeft
    Sheets("ANEXO 1").Columns("S:S").HorizontalAlignment = xlLeft
    Sheets("ANEXO 1").Columns("Y:Y").HorizontalAlignment = xlLeft
    Sheets("ANEXO 1").Columns("AA:AA").HorizontalAlignment = xlLeft
    Sheets("ANEXO 1").Columns("DQ:DQ").HorizontalAlignment = xlLeft
    Sheets("ANEXO 2").Columns("M:M").HorizontalAlignment = xlLeft
    Sheets("ANEXO 2").Columns("U:U").HorizontalAlignment = xlLeft
    Sheets("ANEXO 2").Columns("BJ").HorizontalAlignment = xlLeft
    Sheets("ANEXO 2").Columns("BK").HorizontalAlignment = xlLeft


    ' -------------------------------------------------------------


    ' Tamanhos específicos de determinadas colunas
    Sheets("ANEXO 1").Columns("DQ:DR").ColumnWidth = 64.5
    Sheets("ANEXO 1").Columns("K:K").ColumnWidth = 38
    Sheets("ANEXO 1").Columns("V:V").ColumnWidth = 23.11
    Sheets("ANEXO 1").Columns("W:W").ColumnWidth = 27.33
    Sheets("ANEXO 1").Columns("Y:Y").ColumnWidth = 44
    Sheets("ANEXO 1").Columns("AA:AA").ColumnWidth = 56.44
    Sheets("ANEXO 1").Columns("DJ:DM").ColumnWidth = 9.89
    Sheets("ANEXO 2").Columns("BJ").ColumnWidth = 91.5
    Sheets("ANEXO 2").Columns("BK").ColumnWidth = 91.5
    Sheets("Difal por CTe").Columns("CC:CD").ColumnWidth = 51.44
    
    
    ' -------------------------------------------------------------
    
    
    ' Quebras de Título específicos para poupar espaço
    Sheets("ANEXO 1").Range("I1").FormulaR1C1 = "CNPJ/CPF " & Chr(10) & "Destinatário/Remetente"
    Sheets("ANEXO 1").Range("J1").FormulaR1C1 = "IE Destinatário/" & Chr(10) & "Remetente"
    Sheets("ANEXO 1").Range("L1").FormulaR1C1 = "UF Destinatário" & Chr(10) & "/Remetente"
    Sheets("ANEXO 1").Range("P1").FormulaR1C1 = "Data" & Chr(10) & "de " & Chr(10) & "Emissão"
    Sheets("ANEXO 2").Range("K1").FormulaR1C1 = "CNPJ/CPF " & Chr(10) & "Destinatário/Remetente"
    Sheets("ANEXO 2").Range("L1").FormulaR1C1 = "IE " & Chr(10) & "Destinatário/Remetente"
    Sheets("ANEXO 2").Range("N1").FormulaR1C1 = "UF " & Chr(10) & "Destinatário/Remetente"
    
    
    ' -------------------------------------------------------------
    
    
    ' Ajustar todos as primeiras linhas cabeçalho
    For i = 1 To Sheets.Count
        Sheets(i).Rows("1:1").HorizontalAlignment = xlCenter
        Sheets(i).Rows("1:1").VerticalAlignment = xlCenter
        Sheets(i).Rows("1:1").WrapText = True
        Application.CutCopyMode = False
    Next i
    
    Sheets("ANEXO 1").Select
    
    Application.CutCopyMode = False
        
    'Formatar Anexo 7
    
    Sheets("ANEXO 7").Select
    Range("A6").Select
    Range(Selection, Selection.End(xlToRight)).Select
    Range(Selection, Selection.End(xlDown)).Select
    Selection.Borders(xlDiagonalDown).LineStyle = xlNone
    Selection.Borders(xlDiagonalUp).LineStyle = xlNone
    With Selection.Borders(xlEdgeLeft)
        .LineStyle = xlContinuous
        .ColorIndex = 0
        .TintAndShade = 0
        .Weight = xlThin
    End With
    With Selection.Borders(xlEdgeTop)
        .LineStyle = xlContinuous
        .ColorIndex = 0
        .TintAndShade = 0
        .Weight = xlThin
    End With
    With Selection.Borders(xlEdgeBottom)
        .LineStyle = xlContinuous
        .ColorIndex = 0
        .TintAndShade = 0
        .Weight = xlThin
    End With
    With Selection.Borders(xlEdgeRight)
        .LineStyle = xlContinuous
        .ColorIndex = 0
        .TintAndShade = 0
        .Weight = xlThin
    End With
    With Selection.Borders(xlInsideVertical)
        .LineStyle = xlContinuous
        .ColorIndex = 0
        .TintAndShade = 0
        .Weight = xlThin
    End With
    With Selection.Borders(xlInsideHorizontal)
        .LineStyle = xlContinuous
        .ColorIndex = 0
        .TintAndShade = 0
        .Weight = xlThin
    End With
    Range("A6").Select
    Range(Selection, Selection.End(xlToRight)).Select
    With Selection
        .HorizontalAlignment = xlGeneral
        .VerticalAlignment = xlBottom
        .WrapText = True
        .Orientation = 0
        .AddIndent = False
        .IndentLevel = 0
        .ShrinkToFit = False
        .ReadingOrder = xlContext
        .MergeCells = False
    End With
    With Selection
        .HorizontalAlignment = xlCenter
        .VerticalAlignment = xlBottom
        .WrapText = True
        .Orientation = 0
        .AddIndent = False
        .IndentLevel = 0
        .ShrinkToFit = False
        .ReadingOrder = xlContext
        .MergeCells = False
    End With
    With Selection
        .HorizontalAlignment = xlCenter
        .VerticalAlignment = xlCenter
        .WrapText = True
        .Orientation = 0
        .AddIndent = False
        .IndentLevel = 0
        .ShrinkToFit = False
        .ReadingOrder = xlContext
        .MergeCells = False
    End With
    Cells.Select
    With Selection
        .VerticalAlignment = xlCenter
        .Orientation = 0
        .AddIndent = False
        .IndentLevel = 0
        .ShrinkToFit = False
        .ReadingOrder = xlContext
        .MergeCells = False
    End With
    With Selection
        .HorizontalAlignment = xlCenter
        .VerticalAlignment = xlCenter
        .Orientation = 0
        .AddIndent = False
        .IndentLevel = 0
        .ShrinkToFit = False
        .ReadingOrder = xlContext
        .MergeCells = False
    End With
    Range("A3:G4").Select
    With Selection
        .HorizontalAlignment = xlLeft
        .VerticalAlignment = xlCenter
        .WrapText = False
        .Orientation = 0
        .AddIndent = False
        .IndentLevel = 0
        .ShrinkToFit = False
        .ReadingOrder = xlContext
        .MergeCells = False
    End With
    Range("A1").Select
    With Selection
        .HorizontalAlignment = xlLeft
        .VerticalAlignment = xlCenter
        .WrapText = False
        .Orientation = 0
        .AddIndent = False
        .IndentLevel = 0
        .ShrinkToFit = False
        .ReadingOrder = xlContext
        .MergeCells = False
    End With
    Range("A6").Select
    Range(Selection, Selection.End(xlToRight)).Select
    With Selection.Interior
        .Pattern = xlSolid
        .PatternColorIndex = xlAutomatic
        .Color = 10498160
        .TintAndShade = 0
        .PatternTintAndShade = 0
    End With
    With Selection.Font
        .ThemeColor = xlThemeColorDark1
        .TintAndShade = 0
    End With
    Selection.Font.Bold = True
    Cells.Select
    Cells.EntireColumn.AutoFit
    Columns("A:A").Select
    Selection.ColumnWidth = 9.44
    Columns("B:B").Select
    Columns("B:B").EntireColumn.AutoFit
    Columns("B:B").EntireColumn.AutoFit
    Selection.ColumnWidth = 10.56
    Selection.ColumnWidth = 13.44
    Columns("A:D").Select
    Selection.ColumnWidth = 11.56
    Columns("A:E").Select
    Range("E1").Activate
    Selection.ColumnWidth = 12.22
    Columns("A:G").Select
    Range("G1").Activate
    Selection.ColumnWidth = 12.89
    Columns("H:I").EntireColumn.AutoFit
    Columns("J:J").Select
    With Selection
        .HorizontalAlignment = xlGeneral
        .VerticalAlignment = xlCenter
        .Orientation = 0
        .AddIndent = False
        .IndentLevel = 0
        .ShrinkToFit = False
        .ReadingOrder = xlContext
        .MergeCells = False
    End With
    With Selection
        .HorizontalAlignment = xlCenter
        .VerticalAlignment = xlCenter
        .Orientation = 0
        .AddIndent = False
        .IndentLevel = 0
        .ShrinkToFit = False
        .ReadingOrder = xlContext
        .MergeCells = False
    End With
    Columns("K:K").Select
    Selection.Insert Shift:=xlToRight, CopyOrigin:=xlFormatFromLeftOrAbove
    Sheets("ANEXO 7").Range("K7").FormulaR1C1 = "=TRIM(RC[-1])"
    Range("K7").Select
    Selection.Copy
    Range("J7").Select
    Selection.End(xlDown).Select
    Range("K9086").Select
    Range(Selection, Selection.End(xlUp)).Select
    ActiveSheet.Paste
    Selection.End(xlUp).Select

    Range(Selection, Selection.End(xlDown)).Select
    Application.CutCopyMode = False
    Selection.Copy
    
    Range("J7").Select
    Selection.PasteSpecial Paste:=xlPasteValues, Operation:=xlNone, SkipBlanks _
        :=False, Transpose:=False
    Range("K7").Select
    Range(Selection, Selection.End(xlDown)).Select
    Application.CutCopyMode = False
    Selection.ClearContents

    Range("K10").Select

    Columns("K:K").Select
    Selection.Delete Shift:=xlToLeft
    Columns("L:L").Select
    Selection.ColumnWidth = 7.44

    Columns("M:M").Select
    With Selection
        .HorizontalAlignment = xlLeft
        .VerticalAlignment = xlCenter
        .Orientation = 0
        .AddIndent = False
        .IndentLevel = 0
        .ShrinkToFit = False
        .ReadingOrder = xlContext
        .MergeCells = False
    End With
    
    Sheets("ANEXO 7").Columns("N:O").ColumnWidth = 6.78
    Sheets("ANEXO 7").Columns("P:W").Style = "Comma"
    Sheets("ANEXO 7").Columns("X:X").ColumnWidth = 20.33
    Sheets("ANEXO 7").Columns("P:P").ColumnWidth = 16.67
    
    MsgBox ("Passo 01 e 02 concluídos!!! O próximo estágio demorará um pouco mais... ")
    
    Call difal_passo_02
    
End Sub

Sub difal_passo_02()
'
    ' Passo 1 - Colocar Nomes das colunas
    Sheets("ANEXO 7").Range("Z6").Value = "CHAVE"
    Sheets("ANEXO 7").Range("AA6").Value = "CNPJ.SERIE.NUM_NF"
    Sheets("ANEXO 7").Range("AB6").Value = "CHAVE DE PESQUISA"
    Sheets("ANEXO 7").Range("AC6").Value = "CFOP"
    Sheets("ANEXO 7").Range("AD6").Value = "LISTA CFOP ÚNICOS POR NF"
    Sheets("ANEXO 7").Range("AE6").Value = "QTD DE CFOP ÚNICOS POR NF"
    Sheets("ANEXO 7").Range("AF6").Value = "CLASSIFICACAO" & Chr(10) & "PRELIMINAR"
    Sheets("ANEXO 7").Range("AI6").Value = "COMBINAÇÃO DE CFOP ÚNICOS"
    Sheets("ANEXO 7").Range("AJ6").Value = "CLASSIFICAÇÃO PRELIMINAR"

    
    last_line = Sheets("ANEXO 7").Range("A7").End(xlDown).Row
    
    Sheets("ANEXO 7").Select
    
    ' Passo 2 - Colocar Nomes das colunas
    
    Range("AI7").Formula2R1C1 = "=SORT(UNIQUE(RC[-5]:R[99993]C[-5]))"
    
    ' passo 00 - colacar a fórmula
    Range("Z7").FormulaR1C1 = "=RC[-15]"
    
    
    ' passo 01 - copia a formula
    Range("Z7").Copy
    
    ' passo 02 - seleciona o range que vai colar a fórmula
    Range("Z" & last_line).Select
    Range(Selection, Selection.End(xlUp)).Select
    
    ' passo 03 - cola a fórmula
    ActiveSheet.Paste
    Application.CutCopyMode = False
    
    ' passo 04 - copia as fórmulas que acabaram de ser coladas
    Columns("AZ:AZ").Select
    Selection.Copy

    ' passo 05 - cola somente os valores
    Selection.PasteSpecial Paste:=xlPasteValues, Operation:=xlNone, SkipBlanks _
        :=False, Transpose:=False
    Application.CutCopyMode = False
    
    ' passo 00 - colacar a fórmula
    Range("AA7").FormulaR1C1 = "=TEXTJOIN(""."",TRUE,RC[-19],IFERROR(VALUE(RC[-21]),TRIM(RC[-21])),IFERROR(VALUE(RC[-23]),TRIM(RC[-23])))"
    
    ' passo 01 - copia a formula
    Range("AA7").Copy
    
    ' passo 02 - seleciona o range que vai colar a fórmula
    Range("AA" & last_line).Select
    Range(Selection, Selection.End(xlUp)).Select
    
    ' passo 03 - cola a fórmula
    ActiveSheet.Paste
    Application.CutCopyMode = False
    
    ' passo 04 - copia as fórmulas que acabaram de ser coladas
    Columns("AA:AA").Select
    Selection.Copy

    ' passo 05 - cola somente os valores
    Selection.PasteSpecial Paste:=xlPasteValues, Operation:=xlNone, SkipBlanks _
        :=False, Transpose:=False
    Application.CutCopyMode = False
    
    ' passo 00 - colacar a fórmula
    Range("AB7").FormulaR1C1 = "=IF(TRIM(RC[-2])<>"""",RC[-2],RC[-1])"

    ' passo 01 - copia a formula
    Range("AB7").Copy
    
    ' passo 02 - seleciona o range que vai colar a fórmula
    Range("AB" & last_line).Select
    Range(Selection, Selection.End(xlUp)).Select
    
    ' passo 03 - cola a fórmula
    ActiveSheet.Paste
    ' passo 04 - copia as fórmulas que acabaram de ser coladas
    Columns("AB:AB").Select
    Selection.Copy
    
    ' passo 05 - cola somente os valores
    Selection.PasteSpecial Paste:=xlPasteValues, Operation:=xlNone, SkipBlanks _
        :=False, Transpose:=False
    Application.CutCopyMode = False
    
    Columns("Z:AB").Select
    Range("Z6").Activate
    Columns("Z:AB").EntireColumn.AutoFit
    Range("AB7").Select
    Application.CutCopyMode = False
    
    ' passo 00 - colacar a fórmula
    Range("AC7").FormulaR1C1 = "=RC[-14]"
    ' passo 01 - copia a formula
    Range("AC7").Copy
    ' passo 02 - seleciona o range que vai colar a fórmula
    Range("AC" & last_line).Select
    Range(Selection, Selection.End(xlUp)).Select
    ' passo 03 - cola a fórmula
    ActiveSheet.Paste
    Selection.End(xlUp).Select
    ' passo 04 - copia as fórmulas que acabaram de ser coladas
    Columns("AC:AC").Select
    Selection.Copy

    ' passo 05 - cola somente os valores
    Selection.PasteSpecial Paste:=xlPasteValues, Operation:=xlNone, SkipBlanks _
        :=False, Transpose:=False
    Application.CutCopyMode = False
    

    

    
    ' passo 00 - colacar a fórmula
    Range("AD7").Formula2R1C1 = "=TEXTJOIN("", "", TRUE, (UNIQUE(FILTER(C[-1],C[-2]=RC[-2]))))"
    ' passo 01 - copia a formula
    Range("AD7").Copy
    ' passo 02 - seleciona o range que vai colar a fórmula
    Range("AD" & last_line).Select
    Range(Selection, Selection.End(xlUp)).Select
    ' passo 03 - cola a fórmula
    ActiveSheet.Paste
    Range("AD9086").Select
    ' passo 04 - copia as fórmulas que acabaram de ser coladas
    Columns("AD:AD").Select
    Selection.Copy

    ' passo 05 - cola somente os valores
    Selection.PasteSpecial Paste:=xlPasteValues, Operation:=xlNone, SkipBlanks _
        :=False, Transpose:=False
    Application.CutCopyMode = False

    
    ' passo 00 - colacar a fórmula
    Range("AE7").Formula2R1C1 = "=LEN(TEXTJOIN("", "", TRUE, (UNIQUE(FILTER(C[-2],C[-3]=RC[-3])))))/4"
    ' passo 01 - copia a formula
    Range("AE7").Copy
    ' passo 02 - seleciona o range que vai colar a fórmula
    Range("AE" & last_line).Select
    Range(Selection, Selection.End(xlUp)).Select

    ' passo 03 - cola a fórmula
    ActiveSheet.Paste

    ' passo 04 - copia as fórmulas que acabaram de ser coladas
    Columns("AE:AE").Select
    Selection.Copy

    ' passo 05 - cola somente os valores
    Selection.PasteSpecial Paste:=xlPasteValues, Operation:=xlNone, SkipBlanks _
        :=False, Transpose:=False

           
    Application.CutCopyMode = False
    
    ' passo 00 - colacar a fórmula
    Range("AF7").FormulaR1C1 = "=VLOOKUP(RC[-2],C35:C36,2,FALSE)"
    ' passo 01 - copia a formula
    Range("AF7").Copy
    ' passo 02 - seleciona o range que vai colar a fórmula
    Range("AF" & last_line).Select
    Range(Selection, Selection.End(xlUp)).Select
    ' passo 03 - cola a fórmula
    ActiveSheet.Paste

    Application.CutCopyMode = False

    Columns("AF:AF").Select
    Range("AF6").Activate
    Selection.ColumnWidth = 18.33
    
    
    Range("AF6").Select
    Range(Selection, Selection.End(xlToLeft)).Select
    Application.CutCopyMode = False
    
    With Selection.Interior
        .Pattern = xlSolid
        .PatternColorIndex = xlAutomatic
        .Color = 10498160
        .TintAndShade = 0
        .PatternTintAndShade = 0
    End With
    With Selection.Font
        .ThemeColor = xlThemeColorDark1
        .TintAndShade = 0
    End With
    With Selection
        .HorizontalAlignment = xlCenter
        .VerticalAlignment = xlCenter
        .WrapText = False
        .Orientation = 0
        .AddIndent = False
        .IndentLevel = 0
        .ShrinkToFit = False
        .ReadingOrder = xlContext
        .MergeCells = False
    End With
    With Selection
        .HorizontalAlignment = xlCenter
        .VerticalAlignment = xlCenter
        .WrapText = True
        .Orientation = 0
        .AddIndent = False
        .IndentLevel = 0
        .ShrinkToFit = False
        .ReadingOrder = xlContext
        .MergeCells = False
    End With
    Range("Z6").Select
    Range(Selection, Selection.End(xlDown)).Select
    Range(Selection, Selection.End(xlToRight)).Select
    Selection.Borders(xlDiagonalDown).LineStyle = xlNone
    Selection.Borders(xlDiagonalUp).LineStyle = xlNone
    With Selection.Borders(xlEdgeLeft)
        .LineStyle = xlContinuous
        .ColorIndex = 0
        .TintAndShade = 0
        .Weight = xlThin
    End With
    With Selection.Borders(xlEdgeTop)
        .LineStyle = xlContinuous
        .ColorIndex = 0
        .TintAndShade = 0
        .Weight = xlThin
    End With
    With Selection.Borders(xlEdgeBottom)
        .LineStyle = xlContinuous
        .ColorIndex = 0
        .TintAndShade = 0
        .Weight = xlThin
    End With
    With Selection.Borders(xlEdgeRight)
        .LineStyle = xlContinuous
        .ColorIndex = 0
        .TintAndShade = 0
        .Weight = xlThin
    End With
    With Selection.Borders(xlInsideVertical)
        .LineStyle = xlContinuous
        .ColorIndex = 0
        .TintAndShade = 0
        .Weight = xlThin
    End With
    With Selection.Borders(xlInsideHorizontal)
        .LineStyle = xlContinuous
        .ColorIndex = 0
        .TintAndShade = 0
        .Weight = xlThin
    End With
    Columns("AI:AJ").Select
    Columns("AI:AJ").EntireColumn.AutoFit
    Range("AI6").Select
    With Selection
        .HorizontalAlignment = xlCenter
        .VerticalAlignment = xlCenter
        .WrapText = True
        .Orientation = 0
        .AddIndent = False
        .IndentLevel = 0
        .ShrinkToFit = False
        .ReadingOrder = xlContext
        .MergeCells = False
    End With
    Range("AI6:AJ6").Select
    With Selection.Interior
        .Pattern = xlSolid
        .PatternColorIndex = xlAutomatic
        .Color = 10498160
        .TintAndShade = 0
        .PatternTintAndShade = 0
    End With
    With Selection.Font
        .ThemeColor = xlThemeColorDark1
        .TintAndShade = 0
    End With
    Range(Selection, Selection.End(xlDown)).Select
    Selection.Borders(xlDiagonalDown).LineStyle = xlNone
    Selection.Borders(xlDiagonalUp).LineStyle = xlNone
    With Selection.Borders(xlEdgeLeft)
        .LineStyle = xlContinuous
        .ColorIndex = 0
        .TintAndShade = 0
        .Weight = xlThin
    End With
    With Selection.Borders(xlEdgeTop)
        .LineStyle = xlContinuous
        .ColorIndex = 0
        .TintAndShade = 0
        .Weight = xlThin
    End With
    With Selection.Borders(xlEdgeBottom)
        .LineStyle = xlContinuous
        .ColorIndex = 0
        .TintAndShade = 0
        .Weight = xlThin
    End With
    With Selection.Borders(xlEdgeRight)
        .LineStyle = xlContinuous
        .ColorIndex = 0
        .TintAndShade = 0
        .Weight = xlThin
    End With
    With Selection.Borders(xlInsideVertical)
        .LineStyle = xlContinuous
        .ColorIndex = 0
        .TintAndShade = 0
        .Weight = xlThin
    End With
    With Selection.Borders(xlInsideHorizontal)
        .LineStyle = xlContinuous
        .ColorIndex = 0
        .TintAndShade = 0
        .Weight = xlThin
    End With


    Selection.End(xlUp).Select
    
    Application.CutCopyMode = False
        
    Call difal_passo_03
    
    
End Sub


Sub difal_passo_03()

    ' criar planilha com nome específico
    Sheets.add.name = "AUX CFOP"
    Sheets("AUX CFOP").Select
    
    primeira_linha = 1
    segunda_linha = primeira_linha + 1
    
    
    'nomes dos grupos
    ativo_variable = "ativo imobilizado"
    uso_ou_consumo_variable = "uso ou consumo"

    
    ' Códigos de ativo imobilizado
    linha = primeira_linha
        Sheets("AUX CFOP").Range("A" & linha).Value = "COD CFOP"
        Sheets("AUX CFOP").Range("B" & linha).Value = "Grupo"
        Sheets("AUX CFOP").Range("C" & linha).Value = "Descricao CFOP"
        
    linha = linha + 1
        Sheets("AUX CFOP").Range("A" & linha).Value = 1406
        Sheets("AUX CFOP").Range("B" & linha).Value = ativo_variable
        descricao = "Compra de bem para o ativo imobilizado cuja mercadoria está sujeita ao regime de substituição tributária"
        Sheets("AUX CFOP").Range("C" & linha).Value = descricao
        
        
    linha = linha + 1
        Sheets("AUX CFOP").Range("A" & linha).Value = 1551
        Sheets("AUX CFOP").Range("B" & linha).Value = ativo_variable
        descricao = "Compra de bem para o ativo imobilizado"
        Sheets("AUX CFOP").Range("C" & linha).Value = descricao

    linha = linha + 1
        Sheets("AUX CFOP").Range("A" & linha).Value = 1552
        Sheets("AUX CFOP").Range("B" & linha).Value = ativo_variable
        descricao = "Transferência de bem do ativo imobilizado"
        Sheets("AUX CFOP").Range("C" & linha).Value = descricao
    
    linha = linha + 1

        Sheets("AUX CFOP").Range("A" & linha).Value = 1553
        Sheets("AUX CFOP").Range("B" & linha).Value = ativo_variable
        descricao = "Devolução de venda de bem do ativo imobilizado"
        Sheets("AUX CFOP").Range("C" & linha).Value = descricao
        
    linha = linha + 1
        Sheets("AUX CFOP").Range("A" & linha).Value = 1554
        Sheets("AUX CFOP").Range("B" & linha).Value = ativo_variable
        descricao = "Retorno de bem do ativo imobilizado remetido para uso fora do estabelecimento"
        Sheets("AUX CFOP").Range("C" & linha).Value = descricao
    
    linha = linha + 1
        Sheets("AUX CFOP").Range("A" & linha).Value = 1555
        Sheets("AUX CFOP").Range("B" & linha).Value = ativo_variable
        descricao = "Entrada de bem do ativo imobilizado de terceiro, remetido para uso no estabelecimento"
        Sheets("AUX CFOP").Range("C" & linha).Value = descricao
    
    linha = linha + 1
        Sheets("AUX CFOP").Range("A" & linha).Value = 1604
        Sheets("AUX CFOP").Range("B" & linha).Value = ativo_variable
        descricao = "Lançamento do crédito relativo à compra de bem para o ativo imobilizado"
        Sheets("AUX CFOP").Range("C" & linha).Value = descricao
    
    linha = linha + 1
        Sheets("AUX CFOP").Range("A" & linha).Value = 2406
        Sheets("AUX CFOP").Range("B" & linha).Value = ativo_variable
        descricao = "Compra de bem para o ativo imobilizado cuja mercadoria está sujeita ao regime de substituição tributária"
        Sheets("AUX CFOP").Range("C" & linha).Value = descricao
    
    linha = linha + 1
        Sheets("AUX CFOP").Range("A" & linha).Value = 2551
        Sheets("AUX CFOP").Range("B" & linha).Value = ativo_variable
        descricao = "Compra de bem para o ativo imobilizado"
        Sheets("AUX CFOP").Range("C" & linha).Value = descricao
    
    linha = linha + 1
        Sheets("AUX CFOP").Range("A" & linha).Value = 2552
        Sheets("AUX CFOP").Range("B" & linha).Value = ativo_variable
        descricao = "Transferência de bem do ativo imobilizado"
        Sheets("AUX CFOP").Range("C" & linha).Value = descricao
    
    linha = linha + 1
        Sheets("AUX CFOP").Range("A" & linha).Value = 2553
        Sheets("AUX CFOP").Range("B" & linha).Value = ativo_variable
        descricao = "Devolução de venda de bem do ativo imobilizado"
        Sheets("AUX CFOP").Range("C" & linha).Value = descricao
    
    linha = linha + 1
        Sheets("AUX CFOP").Range("A" & linha).Value = 2554
        Sheets("AUX CFOP").Range("B" & linha).Value = ativo_variable
        descricao = "Retorno de bem do ativo imobilizado remetido para uso fora do estabelecimento"
        Sheets("AUX CFOP").Range("C" & linha).Value = descricao
    
    linha = linha + 1
        Sheets("AUX CFOP").Range("A" & linha).Value = 2555
        Sheets("AUX CFOP").Range("B" & linha).Value = ativo_variable
        descricao = "Entrada de bem do ativo imobilizado de terceiro, remetido para uso no estabelecimento"
        Sheets("AUX CFOP").Range("C" & linha).Value = descricao
    
    linha = linha + 1
        Sheets("AUX CFOP").Range("A" & linha).Value = 3551
        Sheets("AUX CFOP").Range("B" & linha).Value = ativo_variable
        descricao = "Compra de bem para o ativo imobilizado"
        Sheets("AUX CFOP").Range("C" & linha).Value = descricao
    
    linha = linha + 1
        Sheets("AUX CFOP").Range("A" & linha).Value = 3553
        Sheets("AUX CFOP").Range("B" & linha).Value = ativo_variable
        descricao = "Devolução de venda de bem do ativo imobilizado"
        Sheets("AUX CFOP").Range("C" & linha).Value = descricao
    
    linha = linha + 1
        Sheets("AUX CFOP").Range("A" & linha).Value = 5412
        Sheets("AUX CFOP").Range("B" & linha).Value = ativo_variable
        descricao = "Devolução de bem do ativo imobilizado, em operação com mercadoria sujeita ao regime de substituição tributária"
        Sheets("AUX CFOP").Range("C" & linha).Value = descricao
    
    linha = linha + 1
        Sheets("AUX CFOP").Range("A" & linha).Value = 5551
        Sheets("AUX CFOP").Range("B" & linha).Value = ativo_variable
        descricao = "Venda de bem do ativo imobilizado"
        Sheets("AUX CFOP").Range("C" & linha).Value = descricao
        
    linha = linha + 1
        Sheets("AUX CFOP").Range("A" & linha).Value = 5552
        Sheets("AUX CFOP").Range("B" & linha).Value = ativo_variable
        descricao = "Transferência de bem do ativo imobilizado"
        Sheets("AUX CFOP").Range("C" & linha).Value = descricao
    
    linha = linha + 1
        Sheets("AUX CFOP").Range("A" & linha).Value = 5553
        Sheets("AUX CFOP").Range("B" & linha).Value = ativo_variable
        descricao = "Devolução de compra de bem para o ativo imobilizado"
        Sheets("AUX CFOP").Range("C" & linha).Value = descricao
    
    linha = linha + 1
        Sheets("AUX CFOP").Range("A" & linha).Value = 5554
        Sheets("AUX CFOP").Range("B" & linha).Value = ativo_variable
        descricao = "Remessa de bem do ativo imobilizado para uso fora do estabelecimento"
        Sheets("AUX CFOP").Range("C" & linha).Value = descricao
    
    linha = linha + 1
        Sheets("AUX CFOP").Range("A" & linha).Value = 5555
        Sheets("AUX CFOP").Range("B" & linha).Value = ativo_variable
        descricao = "Devolução de bem do ativo imobilizado de terceiro, recebido para uso no estabelecimento"
        Sheets("AUX CFOP").Range("C" & linha).Value = descricao
    
    linha = linha + 1
        Sheets("AUX CFOP").Range("A" & linha).Value = 6412
        Sheets("AUX CFOP").Range("B" & linha).Value = ativo_variable
        descricao = "Devolução de bem do ativo imobilizado, em operação com mercadoria sujeita ao regime de substituição tributária"
        Sheets("AUX CFOP").Range("C" & linha).Value = descricao

    linha = linha + 1
        Sheets("AUX CFOP").Range("A" & linha).Value = 6551
        Sheets("AUX CFOP").Range("B" & linha).Value = ativo_variable
        descricao = "Venda de bem do ativo imobilizado"
        Sheets("AUX CFOP").Range("C" & linha).Value = descricao
    
    linha = linha + 1
        Sheets("AUX CFOP").Range("A" & linha).Value = 6552
        Sheets("AUX CFOP").Range("B" & linha).Value = ativo_variable
        descricao = "Transferência de bem do ativo imobilizado"
        Sheets("AUX CFOP").Range("C" & linha).Value = descricao
    
    linha = linha + 1
        Sheets("AUX CFOP").Range("A" & linha).Value = 6553
        Sheets("AUX CFOP").Range("B" & linha).Value = ativo_variable
        descricao = "Devolução de compra de bem para o ativo imobilizado"
        Sheets("AUX CFOP").Range("C" & linha).Value = descricao
    
    linha = linha + 1
        Sheets("AUX CFOP").Range("A" & linha).Value = 6554
        Sheets("AUX CFOP").Range("B" & linha).Value = ativo_variable
        descricao = "Remessa de bem do ativo imobilizado para uso fora do estabelecimento"
        Sheets("AUX CFOP").Range("C" & linha).Value = descricao
        
    linha = linha + 1
        Sheets("AUX CFOP").Range("A" & linha).Value = 6555
        Sheets("AUX CFOP").Range("B" & linha).Value = ativo_variable
        descricao = "Devolução de bem do ativo imobilizado de terceiro, recebido para uso no estabelecimento"
        Sheets("AUX CFOP").Range("C" & linha).Value = descricao
    
    linha = linha + 1
        Sheets("AUX CFOP").Range("A" & linha).Value = 7551
        Sheets("AUX CFOP").Range("B" & linha).Value = ativo_variable
        descricao = "Venda de bem do ativo imobilizado"
        Sheets("AUX CFOP").Range("C" & linha).Value = descricao

    linha = linha + 1
        Sheets("AUX CFOP").Range("A" & linha).Value = 7553
        Sheets("AUX CFOP").Range("B" & linha).Value = ativo_variable
        descricao = "Devolução de compra de bem para o ativo imobilizado"
        Sheets("AUX CFOP").Range("C" & linha).Value = descricao


'códigos de uso ou consumo


    linha = linha + 1
       Sheets("AUX CFOP").Range("A" & linha).Value = 1407
       Sheets("AUX CFOP").Range("B" & linha).Value = uso_ou_consumo_variable
       descricao = "Compra de mercadoria para uso ou consumo cuja mercadoria está sujeita ao regime de substituição tributária"
       Sheets("AUX CFOP").Range("C" & linha).Value = descricao


    linha = linha + 1
       Sheets("AUX CFOP").Range("A" & linha).Value = 1556
       Sheets("AUX CFOP").Range("B" & linha).Value = uso_ou_consumo_variable
       descricao = "Compra de material para uso ou consumo"
       Sheets("AUX CFOP").Range("C" & linha).Value = descricao

    linha = linha + 1
       Sheets("AUX CFOP").Range("A" & linha).Value = 1557
       Sheets("AUX CFOP").Range("B" & linha).Value = uso_ou_consumo_variable
       descricao = "Transferência de material para uso ou consumo"
       Sheets("AUX CFOP").Range("C" & linha).Value = descricao

    linha = linha + 1
       Sheets("AUX CFOP").Range("A" & linha).Value = 2407
       Sheets("AUX CFOP").Range("B" & linha).Value = uso_ou_consumo_variable
       descricao = "Compra de mercadoria para uso ou consumo cuja mercadoria está sujeita ao regime de substituição tributária"
       Sheets("AUX CFOP").Range("C" & linha).Value = descricao

    linha = linha + 1
       Sheets("AUX CFOP").Range("A" & linha).Value = 2556
       Sheets("AUX CFOP").Range("B" & linha).Value = uso_ou_consumo_variable
       descricao = "Compra de material para uso ou consumo"
       Sheets("AUX CFOP").Range("C" & linha).Value = descricao
       
    linha = linha + 1
       Sheets("AUX CFOP").Range("A" & linha).Value = 2557
       Sheets("AUX CFOP").Range("B" & linha).Value = uso_ou_consumo_variable
       descricao = "Transferência de material para uso ou consumo"
       Sheets("AUX CFOP").Range("C" & linha).Value = descricao


    linha = linha + 1
       Sheets("AUX CFOP").Range("A" & linha).Value = 3556
       Sheets("AUX CFOP").Range("B" & linha).Value = uso_ou_consumo_variable
       descricao = "Compra de material para uso ou consumo"
       Sheets("AUX CFOP").Range("C" & linha).Value = descricao
       
    linha = linha + 1
       Sheets("AUX CFOP").Range("A" & linha).Value = 5413
       Sheets("AUX CFOP").Range("B" & linha).Value = uso_ou_consumo_variable
       descricao = "Devolução de mercadoria destinada ao uso ou consumo, em operação com mercadoria sujeita ao regime de substituição tributária"
       Sheets("AUX CFOP").Range("C" & linha).Value = descricao

    linha = linha + 1
       Sheets("AUX CFOP").Range("A" & linha).Value = 5556
       Sheets("AUX CFOP").Range("B" & linha).Value = uso_ou_consumo_variable
       descricao = "Devolução de compra de material de uso ou consumo"
       Sheets("AUX CFOP").Range("C" & linha).Value = descricao
       
    linha = linha + 1
       Sheets("AUX CFOP").Range("A" & linha).Value = 5557
       Sheets("AUX CFOP").Range("B" & linha).Value = uso_ou_consumo_variable
       descricao = "Transferência de material de uso ou consumo"
       Sheets("AUX CFOP").Range("C" & linha).Value = descricao

    linha = linha + 1
       Sheets("AUX CFOP").Range("A" & linha).Value = 6413
       Sheets("AUX CFOP").Range("B" & linha).Value = uso_ou_consumo_variable
       descricao = "Devolução de mercadoria destinada ao uso ou consumo, em operação com mercadoria sujeita ao regime de substituição tributária"
       Sheets("AUX CFOP").Range("C" & linha).Value = descricao
       
    linha = linha + 1
       Sheets("AUX CFOP").Range("A" & linha).Value = 6556
       Sheets("AUX CFOP").Range("B" & linha).Value = uso_ou_consumo_variable
       descricao = "Devolução de compra de material de uso ou consumo"
       Sheets("AUX CFOP").Range("C" & linha).Value = descricao

    linha = linha + 1
       Sheets("AUX CFOP").Range("A" & linha).Value = 6557
       Sheets("AUX CFOP").Range("B" & linha).Value = uso_ou_consumo_variable
       descricao = "Transferência de material de uso ou consumo"
       Sheets("AUX CFOP").Range("C" & linha).Value = descricao

    linha = linha + 1
       Sheets("AUX CFOP").Range("A" & linha).Value = 7556
       Sheets("AUX CFOP").Range("B" & linha).Value = uso_ou_consumo_variable
       descricao = "Devolução de compra de material de uso ou consumo"
       Sheets("AUX CFOP").Range("C" & linha).Value = descricao
       
       
    'Estilizar Tabela de CFOPS
    Range("A" & primeira_linha).Select
    Range(Selection, Selection.End(xlToRight)).Select
    Range(Selection, Selection.End(xlDown)).Select
    Selection.Borders(xlDiagonalDown).LineStyle = xlNone
    Selection.Borders(xlDiagonalUp).LineStyle = xlNone
    With Selection.Borders(xlEdgeLeft)
        .LineStyle = xlContinuous
        .ColorIndex = 0
        .TintAndShade = 0
        .Weight = xlThin
    End With
    With Selection.Borders(xlEdgeTop)
        .LineStyle = xlContinuous
        .ColorIndex = 0
        .TintAndShade = 0
        .Weight = xlThin
    End With
    With Selection.Borders(xlEdgeBottom)
        .LineStyle = xlContinuous
        .ColorIndex = 0
        .TintAndShade = 0
        .Weight = xlThin
    End With
    With Selection.Borders(xlEdgeRight)
        .LineStyle = xlContinuous
        .ColorIndex = 0
        .TintAndShade = 0
        .Weight = xlThin
    End With
    With Selection.Borders(xlInsideVertical)
        .LineStyle = xlContinuous
        .ColorIndex = 0
        .TintAndShade = 0
        .Weight = xlThin
    End With
    With Selection.Borders(xlInsideHorizontal)
        .LineStyle = xlContinuous
        .ColorIndex = 0
        .TintAndShade = 0
        .Weight = xlThin
    End With
    Columns("A:A").EntireColumn.AutoFit
    Columns("B:B").EntireColumn.AutoFit
    Columns("C:C").EntireColumn.AutoFit
    Columns("C:C").Select
    With Selection
        .HorizontalAlignment = xlLeft
        .VerticalAlignment = xlCenter
        .WrapText = False
        .Orientation = 0
        .AddIndent = False
        .IndentLevel = 0
        .ShrinkToFit = False
        .ReadingOrder = xlContext
        .MergeCells = False
    End With
    Range("B" & primeira_linha & ":CF" & primeira_linha).Select
    With Selection.Interior
        .Pattern = xlSolid
        .PatternColorIndex = xlAutomatic
        .Color = 10498160
        .TintAndShade = 0
        .PatternTintAndShade = 0
    End With
    Selection.Font.Bold = True
    With Selection.Font
        .ThemeColor = xlThemeColorDark1
        .TintAndShade = 0
    End With
    Columns("A:B").Select
    Selection.ColumnWidth = 20.11
    
    'Copiar transposto os valores de CFOP considerados na tabela CFOP
    

    'Copiar os códigos CFOP
    Range("A" & segunda_linha).Select
    Range(Selection, Selection.End(xlDown)).Select
    Selection.Copy
    
    'Colar os códigos CFOP transpondo
    Sheets("ANEXO 7").Select
    Range("AL6").Select
    Selection.PasteSpecial Paste:=xlPasteAll, Operation:=xlNone, SkipBlanks:= _
        False, Transpose:=True
    
    'Copiar a classificação do GRUPO
    Sheets("AUX CFOP").Select
    Range("B" & segunda_linha).Select
    Range(Selection, Selection.End(xlDown)).Select
    Selection.Copy
    
    'Colar a classificação do GRUPO transpondo
    Sheets("ANEXO 7").Select
    Range("AL5").Select
    Selection.PasteSpecial Paste:=xlPasteAll, Operation:=xlNone, SkipBlanks:= _
        False, Transpose:=True
    Columns("AL:CB").Select
    Columns("AL:CB").EntireColumn.AutoFit
    Range("BW6").Select
    Selection.End(xlToLeft).Select
       
       
    '
    ' Colocar fórmulas no anexo 7 de forma a trazer a classificação automática
    '
       
    Sheets("ANEXO 7").Select
    Sheets("ANEXO 7").Range("AK6").Value = "CLASSIFICAÇÃO AUTOMÁTICA VIA CFOP"
    Sheets("ANEXO 7").Range("AL7").FormulaR1C1 = "=IFERROR(IF(SEARCH(TEXT(R6C,""0000""),RC35)>0,R5C,""""),"""")"
    Sheets("ANEXO 7").Range("AL7").Select
    Selection.Copy
    Range("AL6").Select
    Selection.End(xlToRight).Select
    Range("CB7").Select
    Range(Selection, Selection.End(xlToLeft)).Select
    ActiveSheet.Paste
    Application.CutCopyMode = False
    Selection.Copy
    Range("AI7").Select
    Selection.End(xlDown).Select
    Range("AL59").Select
    Range(Selection, Selection.End(xlUp)).Select
    ActiveSheet.Paste
    Application.CutCopyMode = False
    Range("AK7").Select
    ActiveCell.FormulaR1C1 = _
        "=TEXTJOIN("", "", TRUE,(UNIQUE(TRANSPOSE(UNIQUE(RC[1]:RC[43])))))"
    Range("AK7").Select
    Selection.Copy
    Range("AI7").Select
    Selection.End(xlDown).Select
    Range("AK59").Select
    Range(Selection, Selection.End(xlUp)).Select
    ActiveSheet.Paste
    Range("AI6").Select
    Range(Selection, Selection.End(xlToRight)).Select
    Application.CutCopyMode = False
    With Selection
        .WrapText = False
        .Orientation = 0
        .AddIndent = False
        .IndentLevel = 0
        .ShrinkToFit = False
        .ReadingOrder = xlContext
        .MergeCells = False
    End With
    With Selection
        .VerticalAlignment = xlBottom
        .WrapText = False
        .Orientation = 0
        .AddIndent = False
        .IndentLevel = 0
        .ShrinkToFit = False
        .ReadingOrder = xlContext
        .MergeCells = False
    End With
    With Selection
        .VerticalAlignment = xlCenter
        .WrapText = False
        .Orientation = 0
        .AddIndent = False
        .IndentLevel = 0
        .ShrinkToFit = False
        .ReadingOrder = xlContext
        .MergeCells = False
    End With
    With Selection.Interior
        .PatternColorIndex = xlAutomatic
        .Color = 10498160
        .TintAndShade = 0
        .PatternTintAndShade = 0
    End With
    With Selection.Font
        .ThemeColor = xlThemeColorDark1
        .TintAndShade = 0
    End With
    Columns("AK:AK").Select
    Columns("AK:AK").EntireColumn.AutoFit
    Range("AI6").Select
    Range(Selection, Selection.End(xlToRight)).Select
    Range(Selection, Selection.End(xlDown)).Select
    Selection.Borders(xlDiagonalDown).LineStyle = xlNone
    Selection.Borders(xlDiagonalUp).LineStyle = xlNone
    With Selection.Borders(xlEdgeLeft)
        .LineStyle = xlContinuous
        .ColorIndex = 0
        .TintAndShade = 0
        .Weight = xlThin
    End With
    With Selection.Borders(xlEdgeTop)
        .LineStyle = xlContinuous
        .ColorIndex = 0
        .TintAndShade = 0
        .Weight = xlThin
    End With
    With Selection.Borders(xlEdgeBottom)
        .LineStyle = xlContinuous
        .ColorIndex = 0
        .TintAndShade = 0
        .Weight = xlThin
    End With
    With Selection.Borders(xlEdgeRight)
        .LineStyle = xlContinuous
        .ColorIndex = 0
        .TintAndShade = 0
        .Weight = xlThin
    End With
    With Selection.Borders(xlInsideVertical)
        .LineStyle = xlContinuous
        .ColorIndex = 0
        .TintAndShade = 0
        .Weight = xlThin
    End With
    With Selection.Borders(xlInsideHorizontal)
        .LineStyle = xlContinuous
        .ColorIndex = 0
        .TintAndShade = 0
        .Weight = xlThin
    End With
    Range("AI4").Select

    
    ultima_linha_anexo_07 = Sheets("ANEXO 7").Range("A3").End(xlDown).Row
    Sheets("ANEXO 1").Select
    Range("DN3").FormulaR1C1 = "=IFERROR(VLOOKUP(RC[-105],'ANEXO 7'!C[-92]:C[-86],7,FALSE),IFERROR(VLOOKUP(RC[-113]& "".""&RC[-104]&"".""&RC[-103],'ANEXO 7'!C27:C[-86],6,FALSE),""-""))"
    Range("DO3").FormulaR1C1 = "=IF(RC[-7]<>""Sim"",""Não"",IF(OR(RC[-1]=""uso ou consumo"",RC[-1]=""ativo imobilizado""),""Sim"",""Não""))"
    Range("DP3").FormulaR1C1 = "=IF(RC[-8]=RC[-1],""Não"",""Sim"")"
       
    With Sheets("ANEXO 1")
        ultima_linha = .Range("A" & .Rows.Count).End(xlUp).Row
        .Range("DN3:DN" & ultima_linha).Formula = .Range("DN3").Formula
        .Range("DO3:DO" & ultima_linha).Formula = .Range("DO3").Formula
        .Range("DP3:DP" & ultima_linha).Formula = .Range("DP3").Formula
    End With
    
    Call formatar_aux_cfop
    
End Sub


Sub formatar_aux_cfop()

    Sheets("AUX CFOP").Select
    Range("A1").Select
    Range(Selection, Selection.End(xlToRight)).Select
    Cells.Select
    With Selection.Interior
        .Pattern = xlNone
        .TintAndShade = 0
        .PatternTintAndShade = 0
    End With
    Range("A1").Select
    Range(Selection, Selection.End(xlToRight)).Select
    With Selection.Interior
        .Pattern = xlSolid
        .PatternColorIndex = xlAutomatic
        .Color = 6299648
        .TintAndShade = 0
        .PatternTintAndShade = 0
    End With
    With Selection.Font
        .ThemeColor = xlThemeColorDark2
        .TintAndShade = 0
    End With
    Selection.Font.Bold = True
    With Selection
        .HorizontalAlignment = xlCenter
        .WrapText = False
        .Orientation = 0
        .AddIndent = False
        .IndentLevel = 0
        .ShrinkToFit = False
        .ReadingOrder = xlContext
        .MergeCells = False
    End With
    Columns("B:B").Select
    With Selection
        .HorizontalAlignment = xlLeft
        .VerticalAlignment = xlBottom
        .WrapText = False
        .Orientation = 0
        .AddIndent = False
        .IndentLevel = 0
        .ShrinkToFit = False
        .ReadingOrder = xlContext
        .MergeCells = False
    End With
    With Selection
        .HorizontalAlignment = xlCenter
        .VerticalAlignment = xlBottom
        .WrapText = False
        .Orientation = 0
        .AddIndent = False
        .IndentLevel = 0
        .ShrinkToFit = False
        .ReadingOrder = xlContext
        .MergeCells = False
    End With
    Columns("A:A").Select
    With Selection
        .HorizontalAlignment = xlGeneral
        .VerticalAlignment = xlBottom
        .WrapText = False
        .Orientation = 0
        .AddIndent = False
        .IndentLevel = 0
        .ShrinkToFit = False
        .ReadingOrder = xlContext
        .MergeCells = False
    End With
    With Selection
        .HorizontalAlignment = xlCenter
        .VerticalAlignment = xlBottom
        .WrapText = False
        .Orientation = 0
        .AddIndent = False
        .IndentLevel = 0
        .ShrinkToFit = False
        .ReadingOrder = xlContext
        .MergeCells = False
    End With
    Range("C6").Select
    
    Application.CutCopyMode = False
    
    Call colocar_filtros_no_anexo_01
    
End Sub

Sub colocar_filtros_no_anexo_01()
    
    Sheets("ANEXO 1").Select
    
    ' Ajustar cor do cabecalho
    Range("DJ1:DM2").Interior.Pattern = xlSolid
    Range("DJ1:DM2").Interior.PatternColor = 16777215
    Range("DJ1:DM2").Interior.Color = 65535
    
    ' Ajustar fonte do cabecalho
    Range("DJ1:DM2").Font.ThemeColor = xlThemeColorLight1
    
    ' Ajustar largura
    Columns("DJ:DM").ColumnWidth = 22
    
    ' Texto do cabeçalho
    Range("DJ1").FormulaR1C1 = "FILTRO 01 " & Chr(10) & "Analisar Inicialmente"
    Range("DK1").FormulaR1C1 = "FILTRO 02 " & Chr(10) & "Analisar Valores" & Chr(10) & "Relevantes"
    Range("DK1").FormulaR1C1 = "FILTRO 02 " & Chr(10) & "Analisar Valores" & Chr(10) & "Relevantes"
    Range("DL1").FormulaR1C1 = "FILTRO 03 " & Chr(10) & "Copiar Colar " & Chr(10) & "BD --> BE " & Chr(10) & "ou " & Chr(10) & "BO --> BP"
    Range("DM1").FormulaR1C1 = "FILTRO 04" & Chr(10) & "Apagar Valores"
    
    ' Fórmulas na linha 03
    Range("DJ3").FormulaR1C1 = "=IF(IF(RC[-2]<>""Sim"",""-"",IF(OR(RC[4]=""uso ou consumo"",RC[4]=""ativo imobilizado""),LOWER(LEFT(RC[7],12)),""-""))=""inicialmente"",""analisar inicialmente para verificar cobrança indevida em funcao dos dados na NF-e"",""-"")"
    Range("DK3").FormulaR1C1 = "=IF(AND(RC[-3]=""Sim"",RC[3]=""outros"",LEFT(LOWER(RC[6]),12)=""inicialmente""),""analisar inicialmente para verificar cobrança indevida em função do destinação dada"",""-"")"
    Range("DL3").FormulaR1C1 = "=IF(AND(RC[3]=""Sim"",RC[4]=""Sim""),""Copiar e colar valores"",""-"")"
    Range("DM3").FormulaR1C1 = "=IF(AND(RC[2]=""Não"", RC[3]=""Sim""),""apagar valores"",""-"")"
    
    ' Seleciona as fórmulas
    Range("DJ3:DM3").Select
    Selection.Copy
    
    ultima_linha = Sheets("ANEXO 1").Range("A3").End(xlDown).Row
        
    Range("DJ" & ultima_linha).Select
    Range(Selection, Selection.End(xlUp)).Select
    ActiveSheet.Paste
    Selection.End(xlUp).Select
    
    Application.CutCopyMode = False
    
    MsgBox ("Classifique as combinações do anexo 7")
End Sub


