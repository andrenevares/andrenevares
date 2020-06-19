# Pointer

```
#include <iostream>

using namespace std;


int main() {
// Isso é um pointer que será usado para armazenar um endereço de memória
int *pointer; 
int id = 10;

// o endereço será aplicado ao pointer.
pointer = &id; 

cout << pointer;

    return 0;
}
```

#### Output
``` 0x7ffc85eeb484```
> esse é o endereço


## ```pointer``` vs ```*pointer```
```
#include <iostream>

using namespace std;


int main() {

int *pointer; // Isso é um pointer que será usado para armazenar um endereço de memória
int id = 10;

// o endereço será aplicado ao pointer.
pointer = &id; 

    cout << pointer << endl; // resultado será 
    cout << *pointer << endl; // resultado será 10

    return 0;
}

```

## Types of pointers
- Ponteiros em C++ tem que ser do mesmo tipo
- Veja o exemplo a

```
#include <iostream>

using namespace std;


int main() {
    
    int *intPointer;
    int intVariable = 20;
    
    intPointer = &intVariable;
    cout << "intPointer = &intVariable... " << intPointer << endl;
    
    float *floatPointer;
    float floatVariable = 20.2;
    
    floatPointer = &floatVariable;
    cout << "floatPointer = &floatVariable... " << intPointer << endl;

    string *stringPointer;
    string stringVariable = "Andre";
    
    stringPointer = &stringVariable;
    cout << "stringPointer = &stringVariable... " << intPointer << endl;
    
    return 0;
}
```


#### Output:
```
intPointer = &intVariable... 0x7ffc67374b38                                                      
floatPointer = &floatVariable... 0x7ffc67374b38                                                  
stringPointer = &stringVariable... 0x7ffc67374b38                                                
```

# Benefícios de ponteiros
- Dynamic memmory allocation
- 
