# Login

Any aplication needs to login right?
In the project one of CS 50 from HARVARD X also...

The requirements are very simple for the registration and login

First you will need to set your database on HEROKU but the tutorial from HarvardX explains it.

Then you have to config the postgres like we write on the other file.

for the login we will use Flask-Login extension

## Flask Login
https://flask-login.readthedocs.io/en/latest/
As soon as i have time i will read all the documentation ok...
But for this project i have read just the best parts



## Install the extension with pip:
```
$ pip install flask-login
```

## import on INIT file and create a instance on INIT also
```
from flask-login import LoginManager
(...)

login_manager = LoginManager(app)
```


## 1. import login_manager instance into MODELS.PY 
1. You have to import into routes.py file the instance login_manager that was created on init file;

```
from bookreview import login_manager
```
So your code will be like this
```
from bookreview import app, login_manager
```

## 2. user_loader into MODELS
 You have to create a function with a decorator '@'called user_loader.  This is to reload user ID from the session. We need to put this in place so the extension could work!

```
@login_manager.user_loader
def load_user(user_id):
    return User.query.get(int(user_id))
```

## 3. In MODELS.PY you import ___UserMixin___
The extension will ask for some methods...
```
from flask_login import is_authenticated
from flask_login import is_active
from flask_login import is_anonymous
from flask_login import get_id()
```
This is the same of
```
from flask_login import UserMixin
```


## Adjust the class User
```
class User(db.Model):
    __tablename__ = 'user'
```
needs to be 

```
class User(db.Model, UserMixin):
    __tablename__ = 'user'
```

# The Login route

## Query user

## Query Password

## Import into routes login_user function
```
from flask_login import login_user
```


