# Goodreads Api Key
Here is your developer key for using the Goodreads API. This key must be appended to every request using the form variable 'key'. (If you're using our write API, you'll need your secret too.)

key: FGNPjra4ZgnnfoHUKQ
secret: 1PMOwnozKwUaMZdbPrSYBmDjq4gMVhTGBscS1Xw4A

https://docs.cs50.net/web/2020/x/projects/1/project1.html

```
import requests
res = requests.get("https://www.goodreads.com/book/review_counts.json", params={"key": "FGNPjra4ZgnnfoHUKQ", "isbns": "9781632168146"})
print(res.json())
``` 