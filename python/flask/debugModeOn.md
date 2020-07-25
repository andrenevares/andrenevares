# How to set debug mode = true
> By andré nevares

## Introduction
If you are creating somethink, you problabaly will make mistakes, right?  
Maybe you might to make some changes? 
Well... i do.

By default Flask ```Debug mode: off```

If you made a change you will need to shut down using ```CTRL + C``` and restart again using ```flask run``` for instance...

But, there is more efficient way to work with Flask framework

You can set ```Debug mode: off```...  but how you can do that?


## How to set flask debug mode on (windows > powershell)


on your terminal:

```
$env:FLASK_APP = "app.py"
$env:FLASK_ENV = "development"
$env:FLASK_DEBUG=1
```

## Advantages
- You do not need to restart your flask app everytime you make a change...
- Just refresh your browser and then it´s done
