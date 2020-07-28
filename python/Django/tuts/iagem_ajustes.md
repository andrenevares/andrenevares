# Usar imagens

## Processo

Temos que ajustar 
1. ```settings.py``` do projeto
2. ```urls.py``` do projeto

## ```settings.py```
1. Vá até o arquivo __settings.py__
2. digitar o endereço no final do arquivo utilizando a seguinte sintaxe: ```MEDIA_ROOT = ''```

Para que funcione em qualquer computador, seja linux, windows, mac... devemos usar a sintace de sistema operacional.

Podemos colar do __DATABASES__ que fica dentro do __settings.py__

```python
MEDIA_URL = '/imagens/' 
MEDIA_ROOT = os.path.join(BASE_DIR, 'media')
```
- MEDIA_URL: será a URL que será exibida no navegador 
- MEDIA_ROOT: será onde ela será salva de fato, seja no servidor, seja na sua máquina

## ```urls.py``` do projeto

```python
(...)
from django.conf.urls.static import static
from django.conf import settings
(...)
urlpatterns += static(settings.MEDIA_URL, document_root=settings.MEDIA_ROOT)
```
