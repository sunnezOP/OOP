#pragma once
#include <iostream>
#include <string>

using namespace std;
class Strings
{
    string _str;
public:
    Strings(string s)
    {
        _str = s;
    }
    int GetLength()
    {
        return _str.size();
    }
};
