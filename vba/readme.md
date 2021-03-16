# Visual Basic Application

- [Atualizar Dinâmica](https://github.com/andrenevares/andrenevares/blob/master/vba/atualizar_din%C3%A2mica.md)
- [Adcionar Nova Aba](https://github.com/andrenevares/andrenevares/blob/master/vba/add-new-sheet.md)
- [Alterar valor da célula](https://github.com/andrenevares/andrenevares/blob/master/vba/alterar_valor_celula.md)
- [Aplicar Bordas em um intervalo](https://github.com/andrenevares/andrenevares/blob/master/vba/bordas_em_intervalo.md)
- [Apagar conteúdo das células até a última linha preenchida](https://github.com/andrenevares/andrenevares/blob/master/vba/apagar_conteudo_das_celulas_ate_a_ultima_celula_preeenchida.md)
- [Copiar e Colar em um intervalo](https://github.com/andrenevares/andrenevares/blob/master/vba/copiar_colar_intervalor.md)
- [Formatar Cabeçalho](https://github.com/andrenevares/andrenevares/blob/master/vba/formatar_cabecalho.md)
- [Inserir fórmula](https://github.com/andrenevares/andrenevares/blob/master/vba/inserir_formula.md)
- [Largura da Coluna](https://github.com/andrenevares/andrenevares/blob/master/vba/ajuste_largura_colunas.md)
- [Limpar Valores de um range](https://github.com/andrenevares/andrenevares/blob/master/vba/limpar-valores.md)
- [Renomar Aba](https://github.com/andrenevares/andrenevares/blob/master/vba/renomear_aba.md)
- [Última Linha](https://github.com/andrenevares/andrenevares/blob/master/vba/last_row.md)

## Contar vírgulas em uma célula
```excel
=(NÚM.CARACT(A2)-NÚM.CARACT(SUBSTITUIR(A2;",";"")))+1
```
| A | B |
| :-:| :-:|
|1221, 2541, 3545	| 3 |
| 1114, 1121 |	2 |
| 1211 |	1 |


