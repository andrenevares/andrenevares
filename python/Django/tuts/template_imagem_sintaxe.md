# Sintaxe para exibir imagens

usar __.url__ 

```html
    <img src="{{ nome_do_model.nomeImagem.url }}" alt="">
```

Eu criei uma funcionalidade que faz o upload de uma imagem.  Como faço para exibir a imagem?

digamos que você criou um model chamado Autor.  

```
from django.db import models

class Autor(models.Model):
    nome = models.CharField(max_length=100)
    imagem = models.ImageField(upload_to='autores/images') 
```

Utilizando a sintaxe {{ autor.image }} virá um pedaço da url... mas não funcionará

A sintaxe correta deve ser 

```html
    <img src="{{ autores.imagem.url }}" alt="">
```


