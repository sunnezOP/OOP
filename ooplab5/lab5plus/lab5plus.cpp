#include <iostream>
#include "LetterStrings.h";
#include "Strings.h";
using namespace std;

int main()
{
    LetterStrings ltstr = LetterStrings("coolstorybob");
    cout << ltstr.GetStr() << "\n";
    ltstr.Shift();
    cout << ltstr.GetStr() << "\n";
    cout << ltstr.GetLength() << "\n";
}