Sub criar_dinamica_anexo_1()
    ' Criar uma aba com nome específico
    Sheets.add.name = "DINAMICA_ANEXO_I"
    
    'Limpar Anexo 2 coluna AA
    Sheets("ANEXO 2").Select
    Range("AA3").Select
    Range(Selection, Selection.End(xlDown)).Select
    Selection.ClearContents

    'mudar o nome de dois campos de modo que nâo retorne erro na dinâmica
    Sheets("ANEXO 1").Range("BD1").FormulaR1C1 = "DIFAL SEM REDUCAO"
    Sheets("ANEXO 1").Range("BO1").FormulaR1C1 = "DIFAL COM REDUCAO"
    
    'Criar dinâmica do anexo I
    Sheets("ANEXO 1").Select
    Cells.Select
    Range("BE1").Activate
    ActiveWorkbook.PivotCaches.Create(SourceType:=xlDatabase, SourceData:= _
        "ANEXO 1!R1C1:R1048576C124", Version:=6).CreatePivotTable TableDestination _
        :="DINAMICA_ANEXO_I!R3C1", TableName:="Tabela dinâmica7", DefaultVersion:= _
        6
    Sheets("DINAMICA_ANEXO_I").Select
    Cells(3, 1).Select
    With ActiveSheet.PivotTables("Tabela dinâmica7")
        .ColumnGrand = True
        .HasAutoFormat = True
        .DisplayErrorString = False
        .DisplayNullString = True
        .EnableDrilldown = True
        .ErrorString = ""
        .MergeLabels = False
        .NullString = ""
        .PageFieldOrder = 2
        .PageFieldWrapCount = 0
        .PreserveFormatting = True
        .RowGrand = True
        .SaveData = True
        .PrintTitles = False
        .RepeatItemsOnEachPrintedPage = True
        .TotalsAnnotation = False
        .CompactRowIndent = 1
        .InGridDropZones = False
        .DisplayFieldCaptions = True
        .DisplayMemberPropertyTooltips = False
        .DisplayContextTooltips = True
        .ShowDrillIndicators = True
        .PrintDrillIndicators = False
        .AllowMultipleFilters = False
        .SortUsingCustomLists = True
        .FieldListSortAscending = False
        .ShowValuesRow = False
        .CalculatedMembersInFilters = False
        .RowAxisLayout xlCompactRow
    End With
    With ActiveSheet.PivotTables("Tabela dinâmica7").PivotCache
        .RefreshOnFileOpen = False
        .MissingItemsLimit = xlMissingItemsDefault
    End With
    ActiveSheet.PivotTables("Tabela dinâmica7").RepeatAllLabels xlRepeatLabels
    With ActiveSheet.PivotTables("Tabela dinâmica7").PivotFields("Chave Nfe")
        .Orientation = xlRowField
        .Position = 1
    End With
    ActiveSheet.PivotTables("Tabela dinâmica7").AddDataField ActiveSheet. _
        PivotTables("Tabela dinâmica7").PivotFields("Total Bruto Produtos"), _
        "Contagem de Total Bruto Produtos", xlCount
    ActiveSheet.PivotTables("Tabela dinâmica7").AddDataField ActiveSheet. _
        PivotTables("Tabela dinâmica7").PivotFields("DIFAL SEM REDUCAO"), _
        "Contagem de DIFAL SEM REDUCAO", xlCount
    With ActiveSheet.PivotTables("Tabela dinâmica7").PivotFields( _
        "Contagem de DIFAL SEM REDUCAO")
        .Caption = "Soma de DIFAL SEM REDUCAO"
        .Function = xlSum
    End With
    ActiveSheet.PivotTables("Tabela dinâmica7").AddDataField ActiveSheet. _
        PivotTables("Tabela dinâmica7").PivotFields("DIFAL COM REDUCAO"), _
        "Contagem de DIFAL COM REDUCAO", xlCount
    With ActiveSheet.PivotTables("Tabela dinâmica7").PivotFields( _
        "Contagem de DIFAL COM REDUCAO")
        .Caption = "Soma de DIFAL COM REDUCAO"
        .Function = xlSum
    End With

    ActiveWorkbook.ShowPivotTableFieldList = False


    Rows("3:3").HorizontalAlignment = xlGeneral
    Rows("3:3").VerticalAlignment = xlCenter
    Rows("3:3").WrapText = True
    Columns("B:D").ColumnWidth = 18.44
    Columns("C:D").Style = "Comma"
    Rows("3:3").RowHeight = 78.6
   
    Range("F3").FormulaR1C1 = "Chave"
    Range("G3").FormulaR1C1 = "Contagem"
    Range("H3").FormulaR1C1 = "DIFAL sem redução"
    Range("I3").FormulaR1C1 = "DIFAL com redução"
    Range("J3").FormulaR1C1 = "Valor Pago ICMS DIFAL 1141 (Destinatário) - Anexo II"
    Range("K3").FormulaR1C1 = "Em principio"
    Range("L3").FormulaR1C1 = "Checar se valor é SEM reducao"
    Range("M3").FormulaR1C1 = "Checar se valor é COM reducao"
    Range("N3").FormulaR1C1 = "Checa situação que não encontrou nem COM nem SEM redução"
    Range("O3").FormulaR1C1 = "Valor Correto"

    Range("F4").FormulaR1C1 = "=RC[-5]"
    Range("G4").FormulaR1C1 = "=RC[-5]"
    Range("H4").FormulaR1C1 = "=RC[-5]"
    Range("I4").FormulaR1C1 = "=RC[-5]"
    Range("J4").FormulaR1C1 = "=VLOOKUP(RC[-4],'ANEXO 2'!C[5]:C[22],18,FALSE)"
    Range("K4").FormulaR1C1 = "=IF(LOWER(LEFT(VLOOKUP(RC[-10],'ANEXO 2'!C[4]:C[52],48,FALSE),12))=""em princípio"",""Analisar"",""-"")"
    Range("L4").FormulaR1C1 = "=IF(INT(RC[-4])=INT(RC[-2]),""sem redução"",""-"")"
    Range("M4").FormulaR1C1 = "=IF(INT(RC[-4])=INT(RC[-3]),""com redução"",""-"")"
    Range("N4").FormulaR1C1 = "=IF(AND(RC[-2]=""-"",RC[-1]=""-""),""nem um nem outro"", ""-"")"
    Range("O4").FormulaR1C1 = "=IF(RC[-4]=""analisar"",IF(RC[-3]=""sem redução"",RC[-7],IF(RC[-2]=""com redução"",RC[-6],""ver manualmente"")),""-"")"
    
    ' formatar cabecalho da dinâmica
    Range("B3:D3").HorizontalAlignment = xlCenter
    Range("B3:D3").VerticalAlignment = xlCenter
    Range("B3:D3").WrapText = True


    ' formatar cabecalho da tabela ao lado da tabela dinâmica
    Range("F3:O3").Interior.Pattern = xlSolid
    Range("F3:O3").Interior.PatternColorIndex = xlAutomatic
    Range("F3:O3").Interior.Color = 6299648
    Range("F3:O3").Font.ThemeColor = xlThemeColorDark2
    Range("F3:O3").HorizontalAlignment = xlCenter
    Range("F3:O3").VerticalAlignment = xlCenter
    Range("F3:O3").WrapText = True
    
    Range("F4:O4").Select
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
    
    
    Range("A4").Select
    ultima_linha = Selection.End(xlDown).Row

    Range("F4").Select
    Range(Selection, Selection.End(xlToRight)).Select
    Selection.Copy
    
    Range("F" & ultima_linha).Select
    Range(Selection, Selection.End(xlUp)).Select
    ActiveSheet.Paste
    
    
    Columns("F:O").EntireColumn.AutoFit
    Columns("F:F").EntireColumn.AutoFit
    Columns("H:H").EntireColumn.AutoFit
    Columns("I:I").EntireColumn.AutoFit
    Columns("K:K").EntireColumn.AutoFit
    Columns("L:L").EntireColumn.AutoFit
    Columns("M:M").EntireColumn.AutoFit
    Columns("M:M").EntireColumn.AutoFit
    Columns("N:N").EntireColumn.AutoFit
    Columns("O:O").EntireColumn.AutoFit
    
    
    Application.CutCopyMode = False
    
    Range("F3").Select
    Range(Selection, Selection.End(xlToRight)).Select
    Selection.Font.Bold = True
    
    
    Columns("G:G").ColumnWidth = 9.44
    Columns("J:J").ColumnWidth = 12.78
    Columns("K:K").ColumnWidth = 10.44
    
    Columns("G:G").Select
    
    With Selection
        .HorizontalAlignment = xlCenter
        .Orientation = 0
        .AddIndent = False
        .IndentLevel = 0
        .ShrinkToFit = False
        .ReadingOrder = xlContext
        .MergeCells = False
    End With
    
    Columns("K:M").Select
    
    With Selection
        .HorizontalAlignment = xlCenter
        .Orientation = 0
        .AddIndent = False
        .IndentLevel = 0
        .ShrinkToFit = False
        .ReadingOrder = xlContext
        .MergeCells = False
    End With
    
    Columns("O:O").Select
    
    With Selection
        .HorizontalAlignment = xlRight
        .Orientation = 0
        .AddIndent = False
        .IndentLevel = 0
        .ShrinkToFit = False
        .ReadingOrder = xlContext
        .MergeCells = False
    End With
    
End Sub




