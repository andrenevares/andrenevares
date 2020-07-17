# Parte 07
> Notes from Mscorey, made by André Nevares 
## User Registration

### Youtube - Video - Link
- [Python Django Tutorial: Full-Featured Web App Part 7 - Login and Logout System](https://youtu.be/3aVqWaLjqS4)

### O que veremos
- Sistema de Autenticação
- Login
- Logout
- If login

### Views nativas de ```login``` e ```logout```

1. __projeto > urls.py__  importaremos as views nativas do django.
2. ```from django.contrib.auth import views as auth_views```

##### Sintaxe ```login```: 
```path ('login/', auth_views.LoginView.as_view(), name='login'),```

##### Sintaxe ```logout```: 
```path ('login/', auth_views.LogoutView.as_view(), name='logout'),```

Ao invés de criarmos um app para ```login```e outro app para ```logout``` podemos usar o app ```users``` o que faz mais sentido.

Para isso precisamos dizer ao Django isso...  Nós vamos dizer ao django onde olhar pelos templates

Então dentro da função ```as_view()``` vamos colocar ```as_view(template_name='users/login.html', name='login')```

#### Sintaxes ```login``` e ```logout```: 
```path ('login/', auth_views.LoginView.as_view(template_name=('users/login.html', name='login'), name='login'),```
```path ('logout/', auth_views.LogoutView.as_view(template_name=('users/logout.html', name='logout'), name='logout'),```

### Criar template ```login```
Vamos copiar o código html do ```register.html``` para servir de base para o nosso template.

Fazer alguns ajustes

### Ajustar o ```{% url '...' %}```
- As páginas precisam ser ajustadas para serem redirecionadas de forma dinâmica
- A página __register.html__ deve ter um link para ```{% url 'login' %}```
- A página __login.html__ deve ter um link para```{% url 'register' %}```

### Criar template ```login```

Se digitarmos um usuário que não esteja correto, nós vamos receber a mensagem de erro.

Mas ao mesmo tempo, se digitarmos um usuário correto, vamos ter outro tipo de erro

### Mudar redirect do login no ```settings.py```
O Django de forma nativa irá redirecionar o usuário para a página do seu perfil.  Acontece que ainda não criamos essa parte da aplicação ainda... E mesmo que tivéssemos criado, não parece uma boa idéia redirecionar para a página de profile tão logo o usuário tenha se logado. Nós podemos mudar o redirecionamento nativo do django relativo ao login no nosso ```settings.py``` para isso

1. Abrir o ```settings.py```
2. ```LOGIN_REDIRECT_URL = 'blog-home'```

Ainda não temos a mensagem de sucesso... Mas vamos ajustar isso

### Register --> Login
Quando um usuário tiver sucesso ao se logar ele deve ser redirecionado para a página de login... Faz muito mais sentido que ele faça o LOGIN logo tão logo ele crie uma conta

Dessa forma vamsos ajustar o nosso ```users > views.py```


```
  messages.success(request, f'Sua conta foi criada com sucesso você já pode se logar')
  return redirect('login')
```

### Logout nativo
Dentro do nosso urls.py temos para o logout

```path ('logout/', auth_views.LogoutView.as_view(template_name=('users/logout.html', name='logout'), name='logout'),```

E se tirássemos ```template_name=('users/logout.html', name='logout')```

ficando assim:  

```path ('logout/', auth_views.LogoutView.as_view(template_name=(), name='logout'),```

Vamos examinar o comportamento padrão do django...

ao irmos para a url ```localhost:8000/logout/``` realmente conseguimos fazer logout... No entanto estamos com a interface visual do Django... 

Temos inclusive um link para que façamos o nosso login... Ao clicarmos ali nós somos direcionados para a página de login nativo do Django!



