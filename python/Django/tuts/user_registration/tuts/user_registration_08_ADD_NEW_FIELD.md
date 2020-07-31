# Adcionando campos para o usuário

## Como podemos colocar mais campos dentro do ```UserCreationForm```

- Precisamos criar um novo form
- Esse novo form vai herdar do ```UserCreationForm```
- Vamor dar o nome de ```UserRegisterForm```... mas poderia ser qualquer um

## Campos padrão para um form register
- Username
- Password
- Confirm Password

## Como colocar mais campos?
1. Criar users > ```forms.py```
2. importar forms
3. importar User
4. importar UserCreationForm
5. criar um novo form que vai herdar do UserCreationForm
6. configurar por meio da class meta
7. substituir o UserCreationForm pelo form que foi criado

### ```forms.py```

Podemos criar um form que vai herdar do ```UserCreationForm```

```python
from django import forms
from django.contrib.auth.models import User
from django.contrib.auth.forms import UserCreationForm

class UserRegisterForm(UserCreationForm)
  email = forms.EmailField()
  
  class Meta:
    model = User
    fields = ['username', 'email', 'password1', 'password2']

```
> EmailField() pode receber um argumento required.  Por padrão required = True.  Se quisessemos que fosse padrão poderíamos 

## class meta
- Deixa que façamos as configurações necessárias
- E faz com que as configurações fiquem em um só lugar
- o model que será afetado
- os campos que queremos no nosso form e na seguinte ordem... 

Vamos especificar o model que queremos que o esta class interaja.  Como queremos que o model que a class meta interaja seja o User, a sintaxe fica:

```python
model = User
```

Depois vamos colocar os campos que serão exibidos no nosso form.  Os campos, fields, serão:

```python
fields = ['username', 'email', 'password1', 'password2']
```

## substituir o ```UserCreationForm``` pelo ```UserRegisterForm``` no ```views.py```

##### Código com o ```UserCreationForm```
```python
(...)
from django.contrib.auth.forms import UserCreationForm # para usar os forms
from django.contrib import messages # para poder enviar as mensagens
from django.shortcuts import redirect # para redirecionar o usuário caso...

def register(request):
    if request.method == 'POST':
        form = UserCreationForm(request.POST)
        if form.is_valid():
            form.save() # é somente isso que precisa para salvar no banco do dados!
            username = form.cleaned_data.get('username')
            messages.sucess(request, f'Conta criada para {username}!')
    else:
        form = UserCreationForm()
    
    return render(request, 'users/register.html', {'form': form} )
```

##### Código com o ```UserRegisterForm```

1. Importar o ```UserRegisterForm```
2. Substituir o ```UserCreationForm``` pelo ```UserRegisterForm```
3. Apagar o import do ```UserCreationForm``` pois não vamos mais usar...

```python
from django.shortcuts import render # esse import é padrão
from django.contrib import messages # para poder enviar as mensagens
from django.shortcuts import redirect # para redirecionar o usuário caso...
from .forms import

def register(request):
    if request.method == 'POST':
        form = UserRegisterForm(request.POST)
        if form.is_valid():
            form.save() # é somente isso que precisa para salvar no banco do dados!
            username = form.cleaned_data.get('username')
            messages.sucess(request, f'Conta criada para {username}!')
    else:
        form = UserRegisterForm()
    
    return render(request, 'users/register.html', {'form': form} )
```

Agora veremos o novo campo no nosso formulário.
