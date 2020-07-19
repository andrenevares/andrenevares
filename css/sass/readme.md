# Learn Sass In 20 Minutes | Sass Crash Course
> note from [youtube video](https://www.youtube.com/watch?v=Zz6eOVaaelI)

## CSS with superpowers
https://sass-lang.com/

Antes de começar a usar Sass, você precisa configurar o seu projeto. 

SASS recomenda que você instale o Sass primeiro

## Instalando Sass 
https://sass-lang.com/install

## Extensão no VScode
- nome: Live Sass Compiler
- na barra inferior do Vscode irá aparecer ___Watch Sass___

### o que isso irá fazer?
Vai pegar o nosso Sass e transformar em css, afinal o navegador só consegue ler CSS.

### Criando arquivos

```
style
└───style.scss
```

dentro do ```style.scss``` podemos escrever normalmente nosso css

Por exemplo:
```
header {
  backgroung: lightblue;
}
```

E como vamos transformar isso em ```css```?   
- clique o botão ___Watch Sass___
- Isso vai gerar o ```style.css``` do ```style.scss```

## Link no HTML 
```
<link rel="stylesheet" type="text/css" href="./styles/style.css">
```

## Ajustes automáticos
Vamos imaginar que façamos um código assim
```
header {
  backgroung: lightblue;
  display: flex;
  justify-content: center;
}
```
Uma das coisas que essa extensão faz de interessante é que ela já faz os ajustes necessários para os navegadores diferentes que não ofereçam suporte para uma ou outra coisa.

## Vriáveis
```
$bg-gray: #F6F6F6;

header {
  backgroung: $bg-gray;
  display: flex;
  justify-content: center;
}
```

## Nesting


```
$bg-gray: #F6F6F6;

header {
  backgroung: $bg-gray;
  display: flex;
  justify-content: center;
  h1 {
    color: FFF
  }
  
  p {
    (...)
  }
  
}
```

