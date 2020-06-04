#pragma once
#include "Figure.h"
#include <cmath>
class Square :
	public Figure
{
	int x1, x2, x3, x4, y1, y2, y3, y4;
public:
	Square(int X1,int X2, int X3, int X4, int Y1, int Y2, int Y3, int Y4)
	{
		x1 = X1;
		x2 = X2;
		x3 = X3;
		x4 = X4;
		y1 = Y1;
		y2 = Y2;
		y3 = Y3;
		y4 = Y4;
	}
	double Area() override
	{
		double a = sqrt(pow(x2 - x1, 2) + pow(y2 - y1, 2));
		return a * a;
	}

	double Perimetr() override
	{
		double a = sqrt(pow(x2 - x1, 2) + pow(y2 - y1, 2));
		return a * 4;
	}
};

