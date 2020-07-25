# How to create a Secret Key

## Comands
01. open python terminal with ```python```

02. ``` >>> import secrets```
03. create a secret key setting the number of bytes like that
```
>>> secrets.token_hex(16)
>>> '95db58c701edcd1529b6f553c4b30353'
```
4. Copy and paste into your flask app
```
app.config['SECRET_KEY'] = '95db58c701edcd1529b6f553c4b30353'
```

Have fun!
