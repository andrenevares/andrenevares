# Criar uma view

## View com HttpResponse
```python
from django.shortcuts import render
from django.http import HttpResponse

def nome_qualquer(request):
    return HttpResponse 'Isso aqui é o que vai aparecer na tela se tivermos sucess'
```

## View com render
```python
from django.shortcuts import render
from .models import Project

def nome_qualquer(request):
    projects = Project.objects.all()
    return render(request, 'personal/home.html', {'projects': projects})
```

## View com render passando valores para o teample
```python
from django.shortcuts import render
from .models import Project

def nome_qualquer(request):
    projects = Project.objects.all()
    return render(request, 'personal/home.html', {'projects': projects})
```

