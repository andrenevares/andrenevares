# Static - Configurar o ```settings.py``` 

## Settings
```python
STATIC_URL = '/static/'

STATIC_ROOT = os.path.join(BASE_DIR, 'static')
```

## ```urls.py```

```python
(...)
from django.conf.urls.static import static
from django.conf import settings

(...)

urlpatterns += static(settings.STATIC_URL, document_root=settings.STATIC_ROOT)
``` 
