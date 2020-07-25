# Store data with forms and SQL Alchemy

One of requests is that you aplication needs to be able to store data into a database
This project uses Postgree DB.
## Flask package Structrure

Using Flask package with

1. Static Folder
2. templates folder
3. init.py
4. forms.py
5. models.py 
6. routes.py


## Postgree configuration on init.py 
1. this has to be on init.py 
2. For security reasons i am not saying the correct URI.  Just change it and go 
3. You will have to create a secret Key

### 3. Creating a secret key
```
>>> import secrets
>>> secrets.token_hex(16)
'6c5d6f47f7e6b2b2d7329a5ad1b12086'
```
> obs. Everytime you run this _secrets.token_hex(16)_ you will generate a __secret key__ 
```
app.config['SQLALCHEMY_TRACK_MODIFICATIONS'] = False
app.config['SECRET_KEY'] = '5791628bb0b13ce0c676dfde280ba245'
app.config['SQLALCHEMY_DATABASE_URI'] = 'postgresql://username:password@host:port/database'
```

## Forms

With the bootstrap models i had to change the html to get JINJA2 sintax

I need to make this

## Bootstrap SKETCH
I just make a raw of the data i want to create ok?
i used Bootstrap so i can get:
- inputfield username
- inputfield password
- submit button


## RegistrationForm on forms.py
Now i have a clean page that i can use to create the python forms
On my package structure i have to create a register and a login form...

## The registration Form 
In flask we have a package called __flask_wtf__

> __EqualTo__: On Valitator we can use an EqualTo if we want to create an structure of password and confirm_password...  But... On CS 50 Web Programming with Python and Javascript it´s not a requirement... To we keep it simple.

> __Remember me__: If we to create on the Login an remember_me check we will need to set from wtforms import BooleanField cause it´s a another type of field, ok?


```
from flask_wtf import FlaskForm
from wtforms import StringField, PasswordField, SubmitField
from wtforms.validators import DataRequired, Length

    class RegistrationForm(FlaskForm):
        username = StringField('Username',
                            validators=[DataRequired(), Length(min=2, max=20)])
        password = PasswordField('Password', validators=[DataRequired()])
        submit = SubmitField('Sign Up')
```



## Template _register.html_
```
  <form method="POST" action="">
    <!-- Add CSRF Token-->
    {{ form.hidden_tag() }}
    <div class="form-group">
      {{ form.username.label(class="form-control-label") }}
      {{ form.username(class="form-control form-control-lg") }}
    </div>
    <div class="form-group">
      {{ form.password.label(class="form-control-label") }}
      {{ form.password(class="form-control form-control-lg") }}
    </div>
    <div class="form-group">
      {{ form.submit(class="btn btn-primary") }}
    </div>
  </form>
```


# Now we check if we store our data
I have opened my command line

```
$ python
>>> from bookreview import db
>>> from bookreview.models import User
>>> user = User.query.first()
>>> user
User('andrenevares', '$2b$12$Y6Tf.roBChwS.u58Kb5bIuMRo7HCdSMKLG09T6Cblk22F3MaoQGVy')
```
As you can see we have stored our data!
Sucess!!!

If we want to see the username data
```
>>> user.username
'andrenevares'
```

If we want to see the password data stored

```
>>> user.password
'$2b$12$Y6Tf.roBChwS.u58Kb5bIuMRo7HCdSMKLG09T6Cblk22F3MaoQGVy'
```



# Unique Users

The validation just validate lenght, type and other things....
But in our code, untill now, there is nothing stopping the user to register with a username that already exists...

With this code if we try register on the aplication with an username already taken is what is going to happen... An __sqlalchemy.exc.InterityError__


## My solution

```
def register():
    form = RegistrationForm()
    # If the register is valid on submit then
    if form.validate_on_submit():
        # First let´s hash the password so we can store
        user_check = User.query.filter_by(username=form.username.data).first()
        if user_check:
            flash('This user is already taken and try again', 'danger')
            return redirect(url_for('register')) 
        else:
            hashed_password = bcrypt.generate_password_hash(form.password.data).decode('utf-8')
            user = User(username=form.username.data, password=hashed_password)
            db.session.add(user)
            db.session.commit() 
            flash('Account created! Please log in!', 'success')
            return redirect(url_for('login')) 
    return render_template('register.html', title='Register', form=form)
```
## Check if the user already is on our database
Let´s check if the user is in our database?
We can make this with:
```
user = User.query.filter_by(username=username.data).first()
```
If this query found any username will return the username

But...

If there is no user with this username, this query will return ___NONE___.

so the code is going the be something like this
```
user = User.query.filter_by(username=username.data).first()
if user != none:
    you can register..
else:
    you can not register
```

Other way to say that is if we found a user, then you 
```
user = User.query.filter_by(username=username.data).first()
if we found a user
    you can not register..
else:
    you can register
```

and the sintax for this is:

```
user = User.query.filter_by(username=username.data).first()
if user:
    you can not register..
else:
    you can register
```


## Custom Validation

This is on wtf documentation

```
def validate_field(self, field):
        if True:
            raise ValidationError('Validate Message')

```

> Do not forget to import on forms.py
> from wtforms.validators import ValidationError 


Example:
```
def validate_username(self, username):
        if True:
            raise ValidationError('Validate Message')
```







