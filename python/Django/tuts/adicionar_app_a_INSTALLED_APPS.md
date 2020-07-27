# Adcionar um app a INSTALLED_APPS 

Toda vez que for criado um app será necessário avisar ao projeto que esse app exite!

Vá até o __projeto > settings.py__ dentro de __INSTALLED_APPS__ e adcione o __nome_do_app__

### Maneira simples:
```python
INSTALLED_APPS = [
  (...)
  'nome_do_app',
```

###  Maneira da documentação Django:
> Colocar o nome completo
```python
INSTALLED_APPS = [
  (...)
  'nome_do_app.apps.AlgumNomeConfig',
```

1.  buscar dentro do __nome_do_app__
2.  dentro do arquivo __apps.py__
3.  o nome da class ```AlgumNomeConfig```


#### estrutura do projeto
```terminal
meu_projeto
    |- nome_do_app
          |- apps.py
```
#### Arquivo ```apps.py ```
copiar o nome da class gerado automaticamente pelo comando startapp:

```python
from django.apps import AppConfig

class AlgumNomeConfig(AppConfig):
    name = 'questionario'
```
