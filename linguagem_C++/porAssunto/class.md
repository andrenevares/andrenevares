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
    }
};

int main() {
        Book meuObjeto;
    cout << meuObjeto.price;
    return 0;
}
```

O resultado será 100.

## Criando um segundo objeto
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


int main()
{
        Book meuObjeto;
    
    cout << meuObjeto.price;

    return 0;
}
```
- O resultado continuará a ser 100;
- a segunda função nunca foi chamada.
- a única função que foi chamada foi a __constructor__, ou seja, aquela que recebe o nome da função
- para chamar uma função que não seja __constructor__, nós temos que chamar explicitamente!

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
        Book meuObjeto;
        meuObjeto.setPrice();
    
    cout << meuObjeto.price;

    return 0;
}

```
- Agora o resultado foi 500;
- O __constructor__ foi chamado;
- atribuiu a variável price o valor de 100;
- mas depois foi chamada a função ```setPrice()```;
- essa segunda função atribuiu a variável price o valor de 500;
- desta forma o valor que será exibido será o de 500;

