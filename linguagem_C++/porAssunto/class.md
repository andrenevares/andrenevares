# Class em C++

## Estrutura básica
- a palavra ```class``` com ```c``` minúsculo;
- o nome da ```class``` deve ser maiúscula;

### Estrutura Básica
```
class Book {
};
```

### Contructor
- É uma função que tem o mesmo nome de uma class.
- o contructor é a única função chamada quando criamos um objeto dentro daquela class.

```
#include <iostream>
#include <string.h>

using namespace std;
// class name always start with Capital Letter (good practice)
class Book {
public:    
    // variables and properties
    int price;
    //functions 
    Book() { 
        price = 100;  
    } // Book é o constructor.  Tem o mesmo nome
};

int main() {
        Book book; // primeiro objeto com nome de book.  Poderia ser outro
    cout << book.price;
    return 0;
}
```

O resultado será 100.

## Criando uma segunda função
```

#include <string.h>

using namespace std;
// class name always start with Capital Letter (good practice)
class Book {

public:    
    // variables and properties
    int price;
    //functions 
    Book() {
        price = 100;  
    }
    
    void setPrice(){
        price = 500;
    }
    
};


int main(){
        Book book; // criado o objeto book
        book.setPrice();
    
    cout << book.price;

    return 0;
}
```
- O resultado continuará a ser 100;
- a segunda função nunca foi chamada.
- a única função que foi chamada foi a __constructor__, ou seja, aquela que recebe o nome da função
- para chamar uma função que não seja __constructor__, nós temos que chamar explicitamente!

```

#include <string.h>

using namespace std;
// class name always start with Capital Letter (good practice)
class Book {

public:    
    // variables and properties
    int price;
    //functions 
    Book() {
        price = 100;  
    }
    
    void setPrice(){
        price = 500;
    }
    
};


int main(){
        Book book; // criado o objeto book
        book.setPrice();
    
    cout << book.price;

    return 0;
}

```
- Agora o resultado foi 500;
- O __constructor__ foi chamado;
- atribuiu a variável price o valor de 100;
- mas depois foi chamada a função ```setPrice()```;
- essa segunda função atribuiu a variável price o valor de 500;
- desta forma o valor que será exibido será o de 500;

## Criando um segundo objeto;
```
#include <iostream>
#include <string.h>

using namespace std;
// class name always start with Capital Letter (good practice)
class Book {

public:    
    // variables and properties
    int price;
    //functions 
    Book() {
        price = 100;  
    }
    
    void setPrice(){
        price = 500;
    }
    
};

int main(){
        Book book; // criado o objeto book
        book.setPrice();
        Book book2;
    
    cout << book.price << endl;
    cout << book2.price << endl;
    return 0;
}

```
O reultado foi
```
500
100
```

- nós criamos um segundo objeto;
- no primeiro objeto ```book``` nós chamamos a segunda função, logo o valor de ```price``` foi sobreposto para __100__;
- no segunfo objeto ```book2``` nós __não__ chamamos a segunda função, logo somente o  __constructor___ foi chamado.
- Dessa forma, o valor ```book2.price``` é atribuído pela função __constructor___, logo o valor é __500__.


## Adicionando mais funções e propriedades;
```
#include <iostream>
#include <string.h>

using namespace std;
// class name always start with Capital Letter (good practice)
class Book {

public:    
    // variables and properties
    int price;
    string name, author, title;
    //functions 
    Book() {
        // Setting default values ir user do not set any value.
        name = "";
        author = "";
        title = "";
        price = 100;  
    }
    void setPrice(int priceValue) {
        price = priceValue;
    }
};

int main(){
        Book book; // criado o objeto book
        book.setPrice();
        Book book2;
    
    cout << book.price << endl;
    cout << book2.price << endl;
    return 0;
}
```
