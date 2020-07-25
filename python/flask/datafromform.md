# How to get data from Bootstrap Form

## Form Example

```
<form action="/your-url" method="POST">
    <div class="form-control">
        <div class="form-group">
            <label>Username</label>
            <input class="form-control" type="text" name="username">
        </div>
        <div class="form-group">
            <label>Password</label>
            <input class="form-control" type="text" name="password">
        </div>
    </div>
</form>
```

## So we have two input fields
- ```name="username"```
- ```password="password"```

## Our basic structured for Flask

```
from flask import render_tamplate, request, redirect

@app.route("/your-url", methods=["GET", "POST"])
def your_function():
    return render_template("/your-url.html")
```


## commands to get data from our forms
There is more then one way to do it.
Inside of your function make this

i will call the first variable by name of data_all cause in this method we store in a dictionary all data
```
@app.route("/your-url", methods=["GET", "POST"])
def your_function():
    if request.method == "POST":
        data_all= request.form
        print(data_all)
        return redirect(request.url)

    return render_template("/your-url.html")
```


Method 01
```
data_all= request.form
```

Method 02
```
data_all= request.form
username = data_all['username']
password= data_all['password']
```

Method 03
```

username = data_all.get('username')
password= data_all.get('password')
```

Method 04
```
username = request.form.get('username')
password= request.form.get('password')
```


Method 05
```
username = request.form['username']
password = request.form['password']

```

That´s it for now guys...

Have fun!