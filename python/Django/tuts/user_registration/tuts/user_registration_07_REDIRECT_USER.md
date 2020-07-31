# Redirecionar o usuário

## ```views.py```

```pyhton
(...) 
from django.shortcuts import redirect

def register(request):
    if request.method == 'POST':
        form = UserCreationForm(request.POST)
        if form.is_valid():
            form.save() # é somente isso que precisa para salvar no banco do dados!
            username = form.cleaned_data.get('username')
            messages.sucess(request, f'Conta criada para {username}!')
            return redirect('nome_do_path_que_você_quer_ir')
    else:
        form = UserCreationForm()
    
    return render(request, 'users/register.html', {'form': form} )

```
