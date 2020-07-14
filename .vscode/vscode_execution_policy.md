# Execution Policy

Para Ativar o virtual enviroment no __Power Shell__ do Visual Studio Code podemos nos deparar com a seguinte dificuldade:

```
.\venv\Scripts\activate : O arquivo D:\django_projects\venv\Scripts\activate.ps1 não pode ser carregado porque a execução de scripts foi desabilitada neste 
sistema. Para obter mais informações, consulte about_Execution_Policies em https://go.microsoft.com/fwlink/?LinkID=135170.
No linha:1 caractere:1
+ .\venv\Scripts\activate
+ ~~~~~~~~~~~~~~~~~~~~~~~
    + CategoryInfo          : ErrodeSegurança: (:) [], PSSecurityException
    + FullyQualifiedErrorId : UnauthorizedAccess
```

Nesse caso minha solução foi digitar no __Power Shell__ do Visual Studio:

```Set-ExecutionPolicy Unrestricted -Scope CurrentUser```
