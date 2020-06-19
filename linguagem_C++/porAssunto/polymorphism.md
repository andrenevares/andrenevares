# Polymorphism
- Quando sobrescrevemos valores herdados


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

// Isso é inreritance
class Triangle: public Shape {
public:
    Triangle(int w, int h){
        width = w;
        height= h;
    }
    // Isso é Polymorphism
    void area(){
        cout << "The area of a retangle is: " << (width*height) / 2 << endl;
    }
};

int main() {
    Rectangle rectangle(3, 6); 
    rectangle.area();
    Triangle triangle(3, 6); 
    triangle.area();
    return 0;
}
```
