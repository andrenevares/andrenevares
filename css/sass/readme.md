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

```
style
└───style.scss
```

Para ...

```
style
└───style.css
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

## Variáveis
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
$and-bg-gray: #F6F6F6;
$and-dark-blue: #0E1E40
$and-mediun-blue: #0E1E40

header {
  backgroung: $and-bg-gray;
  display: flex;
  justify-content: center;
  button {
    background: $and-mediun-blue;
    &::after {
      content: "--"
    }
    &:hover {
      background: $and-dark-blue;
    }
  }
  
  p {
    (...)
  }
}
```
## Separar em Multiplas partes
```
style
└───style.css
└───style.scss
└───_header.scss
└───_viariables.scss
```
No arquivo main temos que fazer o import.

```
@import ".variables";
@import ".header";

```

## Mixins

Basicamente é como se fosse uma função.  Vai nos permitir que coloquemos várias linhas de códigos em um determinado local e depois chamar.
```
@mixin flexCenter {
  height: 100vh.;
  display: flex;
  justify-content: center;
  alings-itens: center;
}

header {
  @include flexCenter();
  (...)
}
```

Com variáveis...
```
@mixin flexCenter ($bg-color) {
  height: 100vh.;
  display: flex;
  justify-content: center;
  alings-itens: center;
  backgroung: $bg-color
}

header {
  @include flexCenter(red);
  (...)
}
```

## Inheritance

```
.contact {
@extend header;
}
```
