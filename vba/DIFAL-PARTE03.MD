Sub preparar_anexo_2()
    Call limpar_anexo_2_coluna_aa
End Sub

Private Sub limpar_anexo_2_coluna_aa()
    
    'Limpar Anexo 2 coluna AA
    Sheets("ANEXO 2").Select
    Range("AA3").Select
    Range(Selection, Selection.End(xlDown)).Select
    Selection.ClearContents

    Call criar_dinamica_anexo_1

End Sub

Private Sub criar_dinamica_anexo_1()
    
    Sheets.add.name = "DIN_ANEXO_1"
    
    Sheets("ANEXO 1").Select
    
    Cells.Select
    
    ActiveWorkbook.PivotCaches.Create(SourceType:=xlDatabase, SourceData:= _
        "ANEXO 1!R1C1:R1048576C124", Version:=6).CreatePivotTable TableDestination _
        :="DIN_ANEXO_1!R3C1", TableName:="Tabela dinâmica3", DefaultVersion:=6
    
    Sheets("DIN_ANEXO_1").Select
    
    Cells(3, 1).Select
    With ActiveSheet.PivotTables("Tabela dinâmica3")
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
    With ActiveSheet.PivotTables("Tabela dinâmica3").PivotCache
        .RefreshOnFileOpen = False
        .MissingItemsLimit = xlMissingItemsDefault
    End With
    ActiveSheet.PivotTables("Tabela dinâmica3").RepeatAllLabels xlRepeatLabels
    With ActiveSheet.PivotTables("Tabela dinâmica3").PivotFields("Chave Nfe")
        .Orientation = xlRowField
        .Position = 1
    End With
    ActiveSheet.PivotTables("Tabela dinâmica3").AddDataField ActiveSheet. _
        PivotTables("Tabela dinâmica3").PivotFields("ICMS DIFAL Produto Devido"), _
        "Contagem de ICMS DIFAL Produto Devido", xlCount
    With ActiveSheet.PivotTables("Tabela dinâmica3").PivotFields( _
        "Contagem de ICMS DIFAL Produto Devido")
        .Caption = "Soma de ICMS DIFAL Produto Devido"
        .Function = xlSum
    End With
    
    Call colocar_formula_aa_anexo_02
End Sub

Private Sub colocar_formula_aa_anexo_02()

    Sheets("ANEXO 2").Select
        
    Range("AA3").Select
    ActiveCell.FormulaR1C1 = "=VLOOKUP(RC[-12],DIN_ANEXO_1!C[-26]:C[-25],2,FALSE)"
    Range("AA3").Select
    Selection.Copy
    
    ' define o número da última linha
    ultima_linha = Sheets("ANEXO 2").Range("A3").End(xlDown).Row

    ' seleciona a última linha até a primeira que está completa
    Range("AA" & ultima_linha).Select
    Range(Selection, Selection.End(xlUp)).Select
    
    ' cola
    ActiveSheet.Paste
    Application.CutCopyMode = False
    
    Call criar_dinamica_do_anterior

End Sub


Private Sub criar_dinamica_do_anterior()
    Sheets.add.name = "DIN_ANTERIOR"
    Call mudar_nome_cabecalho_anterior
End Sub

Private Sub mudar_nome_cabecalho_anterior()
    
    'mudar o nome de dois campos de modo que nâo retorne erro na dinâmica
    Sheets("ANTERIOR").Range("BB1").FormulaR1C1 = "DIFAL SEM REDUCAO"
    Sheets("ANTERIOR").Range("BK1").FormulaR1C1 = "DIFAL COM REDUCAO"
    
    Call criar_dinamica_anexo_anterior
End Sub


Private Sub criar_dinamica_anexo_anterior()

    Sheets("ANTERIOR").Select
    Columns("A:DR").Select
    ActiveWorkbook.PivotCaches.Create(SourceType:=xlDatabase, SourceData:= _
        "ANTERIOR!R1C1:R1048576C122", Version:=6).CreatePivotTable TableDestination _
        :="DIN_ANTERIOR!R6C1", TableName:="Tabela dinâmica7", DefaultVersion:=6
    Sheets("DIN_ANTERIOR").Select
    Cells(6, 1).Select
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
    ActiveWorkbook.ShowPivotTableFieldList = True
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
    
    Call tabelas_din_anterior_parte01

End Sub

Private Sub tabelas_din_anterior_parte01()

    Sheets("DIN_ANTERIOR").Select
    
    ' Escrever o cabeçalho
    Range("F6").FormulaR1C1 = "CHAVE"
    Range("G6").FormulaR1C1 = "Analisar em principio"
    Range("H6").FormulaR1C1 = "Contagem"
    Range("I6").FormulaR1C1 = "DIFAL SEM REDUCAO"
    Range("J6").FormulaR1C1 = "DIFAL COM REDUCAO"
    Range("K6").FormulaR1C1 = "DIFAL Pago"
    Range("L6").FormulaR1C1 = "Qual foi pago?"
    Range("M6").FormulaR1C1 = "Chaves Somente de Analisar"
    Range("N6").FormulaR1C1 = "Chaves com difal pago normal"
    Range("O6").FormulaR1C1 = "Chaves com difal pago reduzido"
    Range("P6").FormulaR1C1 = "Chaves com nem um nem outro"
    
    ' Colocar as fórmulas
    Range("F7").FormulaR1C1 = "=RC[-5]"
    Range("G7").FormulaR1C1 = "=IF(LOWER(LEFT(VLOOKUP(RC[-1],'ANEXO 2'!C[8]:C[56],48,FALSE),12))=""em princípio"",""analisar"",""-"")"
    Range("H7").FormulaR1C1 = "=IF(RC7<>""-"",RC[-6],""-"")"
    Range("I7").FormulaR1C1 = "=IF(RC7<>""-"",RC[-6],""-"")"
    Range("J7").FormulaR1C1 = "=IF(RC7<>""-"",RC[-6],""-"")"
    Range("K7").FormulaR1C1 = "=IF(RC[-4]<>""-"",VLOOKUP(RC[-5],'ANEXO 2'!C[4]:C[21],18,FALSE),""-"")"
    Range("L7").FormulaR1C1 = "=IF(RC[-5]<>""-"",IF(INT(RC[-3])=INT(RC[-1]),""difal pago normal"",IF(INT(RC[-2])=INT(RC[-1]),""difal pago reduzido"",""nem um nem outro"")),""-"")"
    Range("M7").FormulaR1C1 = "=IF(RC[-6]<>""-"",RC[-7],""-"")"
    Range("N7").FormulaR1C1 = "=IF(RC[-2]=""difal pago normal"",RC[-8],""-"")"
    Range("O7").FormulaR1C1 = "=IF(RC[-3]=""difal pago reduzido"",RC[-9],""-"")"
    Range("P7").FormulaR1C1 = "=IF(RC[-4]=""nem um nem outro"",RC[-10],""-"")"
    
    ' Copiar o cabeçalho
    Range("F7").Select
    Range(Selection, Selection.End(xlToRight)).Select
    Selection.Copy
    
    ' Pegar a última linha por meio de XLDOWN B7
    ultima_linha = Sheets("DIN_ANTERIOR").Range("B7").End(xlDown).Row
    
    ' Seleção de todas as colunas por meio da coluna F
    Range("F" & ultima_linha).Select
    Range(Selection, Selection.End(xlUp)).Select
    
    ' Colar
    ActiveSheet.Paste
    Selection.End(xlUp).Select
    Application.CutCopyMode = False
    
    Call tabelas_din_anterior_parte02
    
End Sub
    
Private Sub tabelas_din_anterior_parte02()

    ultima_linha = Sheets("DIN_ANTERIOR").Range("A6").End(xlDown).Row
    
    Sheets("DIN_ANTERIOR").Range("R7").Formula2R1C1 = "=SORT(UNIQUE(RC[-5]:R[1000000]C[-5]))"
    Sheets("DIN_ANTERIOR").Range("R6").FormulaR1C1 = "=""Chaves únicas no total de "" & COUNTA(R[1]C#)"
    Sheets("DIN_ANTERIOR").Range("U7").Formula2R1C1 = "=SORT(UNIQUE(RC[-7]:R[1000000]C[-7]))"
    Sheets("DIN_ANTERIOR").Range("U6").FormulaR1C1 = "=""Chaves únicas pagas normal Mudar para SIM qtd = "" & COUNTA(R[1]C#)-1"
    Sheets("DIN_ANTERIOR").Range("X7").Formula2R1C1 = "=SORT(UNIQUE(RC[-9]:R[1000000]C[-9]))"
    Sheets("DIN_ANTERIOR").Range("X6").FormulaR1C1 = "=""Chaves únicas pagas normal Mudar para SIM qtd = "" & COUNTA(R[1]C#)-1"
    Sheets("DIN_ANTERIOR").Range("AA7").Formula2R1C1 = "=SORT(UNIQUE(RC[-11]:R[1000000]C[-11]))"
    Sheets("DIN_ANTERIOR").Range("AA6").FormulaR1C1 = "=""Chaves únicas pagas mas não encontrados valores que batam qtd = "" & COUNTA(R[1]C#)-1"
    
    Call formatar_din_anterior
End Sub

Private Sub formatar_din_anterior()

    Sheets("DIN_ANTERIOR").Select
    Rows("6:6").Select
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
        .HorizontalAlignment = xlGeneral
        .VerticalAlignment = xlCenter
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
    Columns("B:D").Select
    Range("B5").Activate
    Selection.ColumnWidth = 16.56
    Columns("F:F").Select
    Range("F5").Activate
    Selection.ColumnWidth = 23.89
    Columns("F:F").EntireColumn.AutoFit
    Columns("G:G").Select
    Range("G5").Activate
    Columns("G:G").EntireColumn.AutoFit
    Columns("G:G").Select
    Range("G5").Activate
    Selection.ColumnWidth = 7.56
    Columns("G:G").EntireColumn.AutoFit
    Columns("H:H").EntireColumn.AutoFit
    Columns("H:H").ColumnWidth = 8
    Columns("H:H").ColumnWidth = 10.44
    Columns("H:P").Select
    Range("H5").ColumnWidth = 13.11
    Columns("R:R").Select
    Range("R5").Activate
    Columns("R:R").EntireColumn.AutoFit
    Columns("U:U").Select
    Range("U5").Activate
    Columns("U:U").EntireColumn.AutoFit
    Columns("X:X").Select
    Range("X5").Activate
    Columns("X:X").EntireColumn.AutoFit
    Selection.ColumnWidth = 25.22
    Columns("U:U").Select
    Range("U5").Activate
    ActiveWindow.ScrollColumn = 16
    Range("U:U,AA:AA,X:X,R:R").Select
    Range("R5").Activate
    Selection.ColumnWidth = 46.11
    Range("F6").Select
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
    Range("R6").Select
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
    Range("U6").Select
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
    Range("X6").Select
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
    Range("AA6").Select
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
    Range("F6").Select
    Range(Selection, Selection.End(xlToRight)).Select
    With Selection.Interior
        .Pattern = xlSolid
        .PatternColorIndex = xlAutomatic
        .Color = 6299648
        .TintAndShade = 0
        .PatternTintAndShade = 0
    End With
    With Selection.Font
        .ThemeColor = xlThemeColorDark1
        .TintAndShade = 0
    End With
    Selection.Font.Bold = True
    Columns("G:G").Select
    Range("G6").Activate
    Selection.ColumnWidth = 13.22
    Range("R6").Select
    With Selection.Interior
        .Pattern = xlSolid
        .PatternColorIndex = xlAutomatic
        .Color = 6299648
        .TintAndShade = 0
        .PatternTintAndShade = 0
    End With
    With Selection.Font
        .ThemeColor = xlThemeColorDark1
        .TintAndShade = 0
    End With
    Selection.Font.Bold = True
    Range("U6").Select
    With Selection.Interior
        .Pattern = xlSolid
        .PatternColorIndex = xlAutomatic
        .Color = 6299648
        .TintAndShade = 0
        .PatternTintAndShade = 0
    End With
    With Selection.Font
        .ThemeColor = xlThemeColorDark1
        .TintAndShade = 0
    End With
    Selection.Font.Bold = True
    Range("X6").Select
    With Selection.Interior
        .Pattern = xlSolid
        .PatternColorIndex = xlAutomatic
        .Color = 6299648
        .TintAndShade = 0
        .PatternTintAndShade = 0
    End With
    With Selection.Font
        .ThemeColor = xlThemeColorDark1
        .TintAndShade = 0
    End With
    Selection.Font.Bold = True
    ActiveWindow.ScrollColumn = 19
    Range("AA6").Select
    With Selection.Interior
        .Pattern = xlSolid
        .PatternColorIndex = xlAutomatic
        .Color = 6299648
        .TintAndShade = 0
        .PatternTintAndShade = 0
    End With
    With Selection.Font
        .ThemeColor = xlThemeColorDark1
        .TintAndShade = 0
    End With
    Selection.Font.Bold = True
    Columns("S:T").Select
    Range("S6").Activate
    Range("S:T,V:W").Select
    Range("V6").Activate
    Range("S:T,V:W,Y:Z").Select
    Range("Y6").Activate
    Selection.ColumnWidth = 3.11

    Call inserir_novas_colunas_anexo_1_depois_da_dinamica

End Sub


Private Sub inserir_novas_colunas_anexo_1_depois_da_dinamica()

    Sheets("ANEXO 1").Select
    
    On Error Resume Next
      Sheets("ANEXO 1").ShowAllData
    On Error GoTo 0
    
    Columns("DU:EC").ColumnWidth = 25
    Columns("DU:EC").Font.name = "Arial"
    Columns("DU:EC").Font.Size = 8
        
    Range("DU1").FormulaR1C1 = "PAGAMENTO NORMAL DETECTADO"
    Range("DV1").FormulaR1C1 = "PAGAMENTO COM REDUCAO DETECTADO"
    Range("DW1").FormulaR1C1 = "CHECK COLUNAS DE PGTO NORMAL OU REDUCAO"
    Range("DX1").FormulaR1C1 = "COBRAR DIFAL - PASSO 01 (REPETINDO COLUNA DH)"
    Range("DY1").FormulaR1C1 = "COBRAR DIFAL - PASSO 02"
    Range("DZ1").FormulaR1C1 = "CHAVES PARA ANÁLISE MANUAL"
    Range("EA1").FormulaR1C1 = "ANÁLISE MANUAL"
    Range("EB1").FormulaR1C1 = "COBRAR DIFAL - PASSO 03"
    Range("EC1").FormulaR1C1 = "FILTRO - COPIAR E COLAR VALORES"
    
        
    Range("DU3").FormulaR1C1 = "=IFERROR(IF(VLOOKUP(RC[-112],DIN_ANTERIOR!C[-104],1,FALSE)<>""-"",""Pgto encontrado"",""-""),""-"")"
    Range("DV3").FormulaR1C1 = "=IFERROR(IF(VLOOKUP(RC[-113],DIN_ANTERIOR!C[-102],1,FALSE)<>""-"",""Pgto encontrado"",""-""),""-"")"
    Range("DW3").FormulaR1C1 = "=IF(OR(RC[-2]=""Pgto encontrado"",RC[-1]=""Pgto Encontrado""),""Pgto Encontrado"",""-"")"
    Range("DX3").FormulaR1C1 = "=RC[-16]"
    Range("DY3").FormulaR1C1 = "=IF(RC[-2]<>""-"",""Sim"",RC[-1])"
    Range("DZ3").FormulaR1C1 = "=IFERROR(IF(VLOOKUP(RC[-117],DIN_ANTERIOR!C[-103],1,FALSE)<>""-"",""Análise Manual"",""-""),""-"")"
    Range("EB3").FormulaR1C1 = "=IF(RC[-1]<>"""",RC[-1],RC[-3])"
    Range("EC3").FormulaR1C1 = "=IF(AND(RC[-1]=""Sim"",RC[-17]=""Copiar e colar valores""),""Copiar e colar Valores"",""-"")"

    Range("DU3:EC3").Select
    Selection.Copy
    ultima_linha = Sheets("ANEXO 1").Range("A3").End(xlDown).Row
    Range("DU" & ultima_linha).Select
    Range(Selection, Selection.End(xlUp)).Select
    ActiveSheet.Paste
    
    Call formatar_novas_colunas_anexo_1
End Sub

Private Sub formatar_novas_colunas_anexo_1()

    Sheets("ANEXO 1").Select
    
    ' Colocar bordas
    ultima_linha = Sheets("ANEXO 1").Range("A3").End(xlDown).Row
    Range("DU1:EC" & ultima_linha).Select
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
    
    ' Colorir Cabeçalho
    Range("DU1:EC1").Select
    With Selection.Interior
        .Pattern = xlSolid
        .PatternColor = 16777215
        .Color = 6299648
        .TintAndShade = 0
        .PatternTintAndShade = 0
    End With
    With Selection.Font
        .ThemeColor = xlThemeColorDark1
        .TintAndShade = 0
    End With
    Selection.Font.Bold = True
    Range("DU1").Select

End Sub

