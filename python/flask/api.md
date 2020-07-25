# API
> André Nevares - Notes from CS50 web programming with python and javascript.

Aplicattion Programming Interface

To comunicate with other languages we gonna dive into a laguage

## JSON
Human readable
Computer readable

### Example 01
```
{
    "origin": "Tokyo",
    "Destination": "Shangai",
    "Duration": 185
}
```

### Example 02
```
{
    "origin": "Tokyo",
    "Destination": "Shangai",
    "Duration": 185
    "Passengers": ["Alice", "Bob"]
}
```
### Example 03
If i want to include airport codes???
```
{
    "origin": {
        "city": "Tokyo",
        "code": "HND"
    },
    "Destination": {
        "city": "Shangai",
        "code": "PVG"
    },
    "Duration": 185
    "Passengers": ["Alice", "Bob"]
}
```
> Python and Javascript handle very well with this type of data!!!

## URL

- ```/flights/``` - It´s going to give the list of all flights, for instance
- ```/flights/28``` - All information about flight 28
- ```/flights/28/passegers``` - list of all passengers in flight 28
- ```/flights/28/passegers/6``` - All information about passenger with it 6

## HTTP Methods

- GET: retrieve resource
- POST: create a new resource
- PUT: replace a resource
- PATCH: update a resource
- DELETE: delete a resource

# requests

## request.get
> library requests library

```
import requests

def main():
    res = request.get("htts://www.google.com/)
    print(res.text)

if __name__ = "__main__":
    main()

```
## others
- request.get(url)
- request.post(url)
- request.put(url)
- request.patch(url)
- request.delete(url)

# fixer.io api
[fixer.io/documentation](https://fixer.io/documentation)

to acess for fixer.io probably you want to get your private key

I my case i have a private key set 

```da04b80dcfe078ca287161f10eb8c6c1```

### Example
```
// "latest" endpoint - request the most recent exchange rate data

http://data.fixer.io/api/latest

    ? access_key = YOUR_ACCESS_KEY
    & base = GBP
    & symbols = USD,AUD,CAD,PLN,MXN

// André, click on the URL above to get the most recent exchange
// rates for USD, AUD, CAD, PLN and MXN
```

> Base USD is restricted... so the code will not run... Read the documentation.

My url: 

http://data.fixer.io/api/latest?access_key=da04b80dcfe078ca287161f10eb8c6c1&base=EUR&symbols=GBP



```
{"success":true,"timestamp":1581118386,"base":"EUR","date":"2020-02-08","rates":{"GBP":0.849344}}
```

If we format this ...

```
{   
    "success":true,
    "timestamp":1581118386,
    "base":"EUR",
    "date":"2020-02-08",
    "rates":{"GBP":0.849344}
}
```

## Currency0.py

```
python 02currency0.py
```

the result is gonna be:
```
{'success': True, 'timestamp': 1581118386, 'base': 'EUR', 'date': '2020-02-08', 'rates': {'GBP': 0.849344}}
```

# Status Code
- 200 OK (sucess)
- 201 Created (sucess)
- 400 Bad Request
- 403 Forbidden
- 404 Not Found
- 405 Method Not Allowed
- 422 Unprocessable Entity
- ...

# How design your own API

Go to airline5 folder
- from flask import jsonify

```
from flask import jsonify, request

(...)

(...)

@app.route("/api/flights/<int:flight_id>")
def flight_api(flight_id):
    """Return details about a single flight."""

    # Make sure flight exists.
    flight = Flight.query.get(flight_id)
    if flight is None:
        return jsonify({"error": "Invalid flight_id"}), 422

    # Get all passengers.
    passengers = flight.passengers
    
    # List of the names is empty
    names = []
    for passenger in passengers:
        names.append(passenger.name)
    return jsonify({
            "origin": flight.origin,
            "destination": flight.destination,
            "duration": flight.duration,
            "passengers": names
        })
```

## API Key
Do not need to worry about it right now...
Limits also...


## Creating a API for CS50 goodreading


```
{
    "books":
        [
            {
                "id":50019613,
                "isbn":"0441172717",
                "isbn13":"9780441172719",
                "ratings_count":212,
                "reviews_count":544,
                "text_reviews_count":12,
                "work_ratings_count":668452,
                "work_reviews_count":1149598,
                "work_text_reviews_count":18450,
                "average_rating":"4.22"
            }
        ]
}
```


