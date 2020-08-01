# users > ```views.py```


## Com ```UserCreationForm```

```python
from django.shortcuts import render # criado automaticamente pelo django
from django.contrib.auth.forms import UserCreationForm # para usar os forms
from django.contrib import messages # para poder enviar as mensagens
from django.shortcuts import redirect # para redirecionar o usuário caso...
from django.contrib.auth.decorators import login_required # caso tenhamos páginas com acesso restrito!

def register(request):
    if request.method == 'POST':
        form = UserCreationForm(request.POST)
        if form.is_valid():
            form.save() # é somente isso que precisa para salvar no banco do dados!
            username = form.cleaned_data.get('username')
            messages.sucess(request, f'Conta criada para {username}!  Você já pode fazer o seu login!')
            return redirect('login') # faz mais sentido direcionar o usuário para a página de login depois que ele criar uma conta
    else:
        form = UserCreationForm()
    
    return render(request, 'users/register.html', {'form': form} )

@login_required
def profile(request):
    return render(request, 'users/profile.html')  
```
