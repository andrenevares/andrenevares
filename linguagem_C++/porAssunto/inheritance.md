# Inheritance
- Quando trazemos elementos de uma outra class para dentro...
```
#include <iostream>

using namespace std;

class Shape{
public:
    int width, height;
    
    void area(){
        cout << "This is Area of a Shape Class";
    }
    
};

// Isso é inreritance
class Rectangle: public Shape {
public:
    Rectangle(int w, int h){
        width = w;
        height= h;
    }
    void area(){
        cout << "The area of a retangle is: " << width*height << endl;
    }
};

int main() {
    Rectangle rectangle(3, 6); 
    rectangle.area();
    return 0;
}
``` 
