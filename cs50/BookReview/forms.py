from flask_wtf import FlaskForm
from wtforms import StringField, PasswordField, SubmitField, BooleanField, IntegerField, TextAreaField
from wtforms.validators import DataRequired, Length, Email, EqualTo, NumberRange


class RegistrationForm(FlaskForm):
    username = StringField(validators=[DataRequired(), Length(
        min=4, max=20)], render_kw={"placeholder": "Username"}, )
    password = PasswordField(validators=[DataRequired()], render_kw={
                             "placeholder": "Password"})
    confirm_password = PasswordField(validators=[DataRequired(), EqualTo('password')], render_kw={
                             "placeholder": "Confirm xPassword"})
    submit = SubmitField('Sign Up')


class LoginForm(FlaskForm):
    username = StringField(validators=[DataRequired()], render_kw={
                           "placeholder": "Username"})
    password = PasswordField(validators=[DataRequired()], render_kw={
                             "placeholder": "Password"})
    submit = SubmitField('Login')


class SearchForm(FlaskForm):
    search = StringField(validators=[DataRequired()], render_kw={
                         "placeholder": "Search"})
    submit = SubmitField('Search')


class ReviewForm(FlaskForm):
    header = StringField(validators=[DataRequired()], render_kw={
        "placeholder": "Small title "})
    rating = IntegerField(validators=[DataRequired(), NumberRange(
        min=1, max=5, message='Choose a value min 1 max 5')], render_kw={"placeholder": "Rating 1 to 5"})
    content = TextAreaField(validators=[DataRequired()], render_kw={
        "placeholder": "Type your comment"})

    submit = SubmitField('Post your comment')
