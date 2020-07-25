# Bcrypt

We do not want that passwords travel and been stored without encriptation
To handle this situation, to save and read encrypted data, we can use an extension called __bcrypt__

## Install
```

pip install flask-bcrypt
```
## Testing on Command Line
```
python
>>> from flask_bcrypt import Bcrypt
>>> bcrypt = Bcrypt()
>>> bcrypt.generate_password_hash('test123')
b'$2b$12$phUDf7Z1Wj3Zdl3d9UvDLOK90kyv/Aazyaux0BQcD8nawBjTJdTMG'
```
The ___b___ it´s means that the hash is written in bytes.

To get the hash without the ___b___ we use:
```
>>> bcrypt.generate_password_hash('test123').decode('utf-8')
'$2b$12$8Cp2e4KX/YReYEiq8c5COuw0cmQSVl9yEyYUtSFFJxbVgVQVZMF.q'
```

One password everytime we generate a new password
```
>>> bcrypt.generate_password_hash('test123').decode('utf-8')
'$2b$12$8Cp2e4KX/YReYEiq8c5COuw0cmQSVl9yEyYUtSFFJxbVgVQVZMF.q'
>>> bcrypt.generate_password_hash('test123').decode('utf-8')
'$2b$12$BKtepA7s6xzxAzQUtDrrkOVZEMJYfF5GCC4464I97Awp6R5DmQbAm'
>>> bcrypt.generate_password_hash('test123').decode('utf-8')
'$2b$12$jGxUUE1GrhJO.lBi8./qYuJie3uaTRI4u90YLYKTdxfERVZPKiR3y'
>>> bcrypt.generate_password_hash('test123').decode('utf-8')
'$2b$12$/DFUHuAEKah8b/69mcar1ep9RSbh6VImoCRrre073/D6IxZ6PMuxO'
>>> bcrypt.generate_password_hash('test123').decode('utf-8')
'$2b$12$Bxa6PbpXWfcbNyJlatq9Ku0SP0mydwC2Qgr1pq9N9dSvU8TFLC2ei'
```

## Store Hash password in a variable
```
hashed_password = bcrypt.generate_password_hash('test123').decode('utf-8')
```

## Checking the Password
```
>>> bcrypt.check_password_hash(hashed_password, 'test123') 
True
```

```
>>> bcrypt.check_password_hash(hashed_password, 'testing')
False
```

Now it´s easy to encrypt and check passwords 

i use this in this project.