

#include <iostream>
#include "MyString.h"
#include "MyText.h"

using namespace std;

int main()
{
    MyString str1, str2, str3, str4;
    MyText text;
    str1.Str("adafaf");
    str2.Str("123123");
    str3.Str("!#!$$");
    str4.Str("asdasfdfwfwew123");
    text.AddString(str1);
    text.AddString(str2);
    text.AddString(str3);
    text.AddString(str4);
  //  text.RemoveString(1);
   // text.Erase();
    text.NumberinText();
}
