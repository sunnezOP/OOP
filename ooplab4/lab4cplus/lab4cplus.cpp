#include <iostream>
#include "Strings.h"

using namespace std;

int main() {
    Strings c1 = Strings();
    Strings c2 = Strings("1234");
    Strings c3 = Strings(c2);

    c3 = c3 ^ '2';
    c1 = c2 + c3;
    cout << c1.GetStr() << "\n";
    cout << c2.GetStr() << "\n";
    cout << c3.GetStr() << "\n";
}