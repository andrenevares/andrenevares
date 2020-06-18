# While em C++

## Loop While 01
```
#include <iostream>

using namespace std;

int main() {
    int counter  = 10;
       
       while(counter > 0){
           cout << counter << endl;
           counter--;
       }
       
    return 0;
}

```

## Com loop defido pelo usuário
```
#include <iostream>

using namespace std;

int main() {
    int counter;
    cout << "How many times loop will run? ";
    cin >> counter;
   while(counter > 0){
       cout << counter << endl;
       counter--;
   }
       
    return 0;
}

```

## While com AND

### Somente uma condição atendida
> Esse código não vai rodar pois ambas as condições tem que ser verdadeiras
```
#include <iostream>

using namespace std;

int main() {
    int counter;
    bool check;
    cout << "How many times loop will run? ";
    cin >> counter;
    
    check = false;
    
   while(counter > 0 && check){
       cout << counter << endl;
       counter--;
   }
       
    return 0;
}

```
> Esse código não vai rodar pois ambas as condições tem que ser verdadeiras
### Ambas condições atendidas
```
#include <iostream>

using namespace std;

int main() {
    int counter;
    bool check;
    cout << "How many times loop will run? ";
    cin >> counter;
    
    check = true;
    
   while(counter > 0 && check){
       cout << counter << endl;
       counter--;
   }
       
    return 0;
}


```

## While com OR

### Somente uma condição atendida 
> O código vai rodar
```
#include <iostream>

using namespace std;

int main() {
    int counter;
    bool check;
    cout << "How many times loop will run? ";
    cin >> counter;
    
    check = false;
    
   while(counter > 0 &|| check){
       cout << counter << endl;
       counter--;
   }
       
    return 0;
}

```
