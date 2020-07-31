# ```def __str__```


## Dunder method
é chamado de dunder method

Dunder vem da junção de duas palavras: Double + under score...


## Para que serve o dunder method?

Podemos dizer para o Django como deve chamar um objeto.

Imagine que façamos uma query por um Post.  Quando vem o objeto, ele vem com o título, com ID, conteúdo...  

Podemos querer que mostre alguma coisa... Por exemplo, o ID do post.  Ao invés de um nome esquisito nós teremos um nome que faz mais sentido!

É para isso que usamod o ```def __str__```.

## Exemplo:

```python
  def __str__(self):
    return self.title
```



