# Apagar Células
Apagar o conteúdo da Celula até a última linha preenchida

```
  ultima_linha = Sheets("Anexo 2").Range("AA3").End(xlDown).Row
  Sheets("Anexo 2").Range("AA3: AA" & ultima_linha).ClearContents
```
