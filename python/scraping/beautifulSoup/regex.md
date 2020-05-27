# Regex 

- Trata-se de uma Regular Expressions 
- É utilizada para identificar strings regulares
- Ou seja que contenham um padrão

## Exemplo

1. Escreva pelo menos uma vez a letra *__'a'__*;
2. Adicione a letra *__'b'__* 5 vezes;
3. Adicione a letra *__'c'__* um número par de vezes; 
4. Adicione pelo menos uma das letras *__'d'__* ou *__'e'__*; 

### Exemplos que seguem essa Regra
- aaaabbbbbccccd
- aabbbbbcce
- (...)

### Como escrever essa regular expression?
```aa*bbbbb(cc)*(d|e)```

### Dissencando:

#### aa*  
- Aqui temos pelo menos uma letra 'a' caracterizada por esta **a**a\*
- a segunda parte em negrito a**a**__\*__  representa a letra 'a' um número x de vezes.  Pode ser 0, quando teríamos tão somente ___a___ ou qualquer outro número como 4, quando teríamos ___aaaaa___

#### bbbbb  
- Aqui não há muito o que se falar... são tão somente *__bbbbb'__* ou seja uma sequência de __5 letras *'b'__*

#### (cc)*
- Aqui teremos úm número par N vezes

#### (d|e)
- Aqui poderá ser d ou e ... ou ambos !
