# App com render

## Com HttpResponse
```
from django.shortcuts import render
from django.http import HttpResponse

def home(request):
    return HttpResponse('<h1>Se aparece funcionou</h1>')
```

## Com render




### Views.py
```
from django.shortcuts import render

def home(request):
    return render(request, 'main/home.html')
```

### templates
```
nome_do_app
  |-templates
      |-nome_do_app
          |-home.html
```
