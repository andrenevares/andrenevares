from flask_wtf import FlaskForm
from wtforms import StringField, PasswordField, SubmitField, BooleanField, TextAreaField, IntegerField
from wtforms.validators import DataRequired, Length

class LoginForm(FlaskForm):
    username = StringField('Username', validators=[DataRequired(), Length(min=2, max=20)])
    password = PasswordField('Password', validators=[DataRequired()])
    remember = BooleanField('Remember Me')
    submit = SubmitField('Login')

class RegistrationForm(FlaskForm):
    username = StringField('Username',
                           validators=[DataRequired(), Length(min=2, max=20)])
    password = PasswordField('Password', validators=[DataRequired()])
    submit = SubmitField('Sign Up')

class BookForm(FlaskForm):
    isbn = StringField('ISBN', validators=[DataRequired()])  
    title = StringField('Title', validators=[DataRequired()])
    author = StringField('Author', validators=[DataRequired()])
    year = StringField('Year', validators=[DataRequired()])
    
    submit = SubmitField('Insert this new book')

class SearchForm(FlaskForm):
    search = StringField('Search for Title, Author or ISBN', validators=[DataRequired()])  
    submit = SubmitField('I fell luck')

class ReviewForm(FlaskForm):
    title = StringField('Title', validators=[DataRequired()])  
    rating = IntegerField('Rating 1 - 5', validators=[DataRequired()])
    content = TextAreaField('Your Review', validators=[DataRequired()])
    submit = SubmitField('Post a Review')



#content will use TextAreaField