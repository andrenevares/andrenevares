# Modelo para começar um projeto materialize

## Usando o CSS minificado

### Estrutura de Pastas
```
pasta
├───css
│   ├───main.css
│   └───materialize.min.css
├───fonts
│   └───roboto
├───img
├───js
│   └───materialize.min.js
└───index.html
``` 

### Template HTML básico

```html
<!DOCTYPE html>
<html>

    <head>
    </head>

    <body>
    </body>

    <script>
    </script>
    
</html>
```

### Template HTML > HEAD
```HTML
<head>
  <!-- Importar os Material Icons -->
  <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
  
  <!-- Importar os Icones Fontawesome --> 
  <script defer src="https://use.fontawesome.com/releases/v5.0.6/js/all.js"></script>
  
  <!-- importar o CSS do materialize -->
  <link type="text/css" rel="stylesheet" href="css/materialize.min.css" media="screen,projection" />
  
  <!-- importar o CSS de customização -->
  <link type="text/css" rel="stylesheet" href="css/main.css" />

  <!-- Avisar ao navegador que o site esta otimizado para Mobile -->
  <meta name="viewport" content="width=device-width, initial-scale=1.0" />

  <!-- Título -->
  <title>Materialize Theme</title>
</head>
```

