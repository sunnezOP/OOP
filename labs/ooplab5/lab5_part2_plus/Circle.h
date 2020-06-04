#pragma once
#include "Figure.h"
class Circle :
	public Figure
{
    int Radius;
    double PI = 3.14;
public:
    Circle(int radius)
    {
        Radius = radius;
    }
    double Area() override
    {
        return 2 * PI * Radius;
    }

    double Perimetr() override
    {
        return PI * Radius * Radius;
    }
};

