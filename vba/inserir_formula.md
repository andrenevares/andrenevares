# Inserir Fórmula

#### Usando Formulalocal
```vba
Sheets("ANEXO 2").Range("BN3").Formulalocal = ="SE(AC3>0; SE(AC3<AA3;AA3-AC3;0);""-"")"
```
- Quando na fórmula houver a necessidade de usar __"__ deve-se usar __""__
