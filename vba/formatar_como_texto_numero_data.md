# Formatar coluna como...

### Formatar como Texto
```
  Sheets("ANEXO 1").Columns("M:M").NumberFormat = "@"
```

### Formatar como contábil
```
  ' Formatar as células das colunas tipo número
    Sheets("ANEXO 1").Columns("BG:BK").Style = "Comma"
```

### Formatar como Data

```
  Sheets("ANEXO 1").Columns("B").NumberFormat = "m/d/yyyy"
```
