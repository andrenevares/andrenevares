# Clear a Python console

> Fonte Stack Overflow by Ryan Duffield in [this post](https://stackoverflow.com/questions/517970/how-to-clear-the-interpreter-console)
```
>>> import os
>>> clear = lambda: os.system('cls')
>>> clear()
```

