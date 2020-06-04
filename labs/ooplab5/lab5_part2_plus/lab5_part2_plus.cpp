#include <iostream>
#include "Circle.h"
#include "Figure.h"
#include "Square.h"

using namespace std;

int main()
{
    Square square(2, 3, 3, 4, 1, 2, 3, 4);
    Circle circle(4);
    cout << square.Area() << "\n";
    cout << square.Perimetr() << "\n";
    cout << circle.Area() << "\n";
    cout << circle.Perimetr() << "\n";
}
