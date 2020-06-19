# Class

## Adding properties and functions

```
#include <iostream>
#include <string.h>

using namespace std;

class Book {
public:
    // variables and properties
    int price;
    string name, author, title;
    
    // functions
    Book(){
        name = "";
        author = "";
        title = "";
        price = 100;
    }
    void setPrice (int priceValue){
        price = priceValue;
    }
    
    void setNameOfBook (string nameOfBook){
        name = nameOfBook;
    }
    
    void setAuthor (string authorName){
        author = authorName;
    }
    
    void setTitle(string titleOfBook){
        title = titleOfBook;
    }
};

int main() {
    Book book; //create a book objeto from class Book
    book.setPrice(300);
    book.setNameOfBook("Learn C++");
    book.setAuthor("Andre");
    book.setTitle("Lerning C++ Cookbook");
    
    cout << book.title << endl;
    cout << book.author << endl;

    return 0;
}
```

## Adding a new object
```
#include <iostream>
#include <string.h>

using namespace std;

class Book {
public:
    // variables and properties
    int price;
    string name, author, title;
    
    // functions
    Book(){
        name = "";
        author = "";
        title = "";
        price = 100;
    }
    void setPrice (int priceValue) {
        if(priceValue > 0) {
            price = priceValue;    
        }
        else
            cout << "This is not a correct function" << endl;
    }
    
    void setNameOfBook (string nameOfBook){
        name = nameOfBook;
    }
    
    void setAuthor (string authorName){
        author = authorName;
    }
    
    void setTitle(string titleOfBook){
        title = titleOfBook;
    }
};

int main() {
    Book book; //create a book objeto from class Book
        book.setPrice(800);
        book.setNameOfBook("Learn C++");
        book.setAuthor("Andre");
        book.setTitle("Lerning C++ Cookbook");
    
    Book book2; //create a book2 objeto from class Book
        book2.setPrice(800);
        book2.setNameOfBook("Learn Python");
        book2.setAuthor("Rafael");
        book2.setTitle("Python Cookbook");
    
    cout << book.author << endl;
    cout << book2.author << endl;

    return 0;
}

```
