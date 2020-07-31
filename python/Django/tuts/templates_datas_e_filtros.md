# Filtro para datas

Imaginemos que tenhamos um class ```post```!  E que para cada post nós temos a data que é criado o post!  Faz sentido, não?
O django possui uma série de parâmetros de modo a exibir a data da maneira X ou Y...

## Link para documentação:
- [django filter](https://docs.djangoproject.com/en/3.0/ref/templates/builtins/#date)

## Sem filtro

```html
<div>
  <p class="text-muted">{{ post.date_posted }}</p> 
</div>
```

## Com filtro

```html
<div>
  <p class="text-muted">{{ post.date_posted }}</p> 
</div>
```


