#pragma once
#include <iostream>
#include <string>
#include <conio.h>
using namespace std;
class Expression
{
    double _a, _b, _c;
public:
    Expression(double a, double b, double c)
    {
        _a = a;
        _b = b;
        _c = c;
    }
    void Set_a(double a)
    {
        _a = a;
    }
    void Set_b(double b)
    {
        _b = b;
    }
    void Set_c(double c)
    {
        _c = c;
    }
    double Get_a()
    {
        return _a;
    }
    double Get_b()
    {
        return _b;
    }
    double Get_c()
    {
        return _c;
    }
    double TryGetAnswer()
    {
        try
        {
            if (_c == 0) throw "Divide by Zero!";
            if ((_a>0 and _b<0) or (_a<0 and _b>0) or (_a*_b+2<1)) throw "Negative logaritm!";
            if ((41 - _b / _c + 1) == 0) throw "Divide by Zero!";
            return ((log(_a*_b+2)*_c)/(41-_b/_c+1));
        }
        catch (const char* ex)
        {
            cout << "ERROR: " << ex << endl;
            exit(1);
            return 0;
        }
    }
};