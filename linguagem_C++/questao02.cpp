#include <iostream>
using namespace std;

int main() {
    float a, b, x;
    
    cout << "qual o valor de a? ";
    cin >> a;
    cout << "qual o valor de b? ";
    cin >> b;
    x = ((a + b * b) / 3) + ((a - b) / 4 * b) ;

    cout << "\nO valor de X é .... " << x;
}
