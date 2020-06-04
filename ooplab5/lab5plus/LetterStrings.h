#pragma once
#include "Strings.h"
#include <iostream>
#include <string>
#include <algorithm>

using namespace std;

class LetterStrings :
    public Strings
{
    string _str;
public:
    LetterStrings(string s) : Strings(s)
    {
        _str = s;
    }
    void Shift()
    {   
        if (_str.length() > 0) 
        {
            rotate(_str.rbegin(), _str.rbegin() + 1, _str.rend());
        }
    }
    string GetStr()
    {
        return _str;
    }
};