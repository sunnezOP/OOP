using System;
using System.Collections.Generic;
using System.Text;

namespace lab5_part2
{
    class Square : Figure
    {
        private int _x1, _x2, _x3, _x4, _y1, _y2, _y3, _y4;

        public Square(int x1, int x2, int x3, int x4, int y1, int y2, int y3, int y4)
        {
            _x1 = x1;
            _x2 = x2;
            _x3 = x3;
            _x4 = x4;
            _y1 = y1;
            _y2 = y2;
            _y3 = y3;
            _y4 = y4;
        }
        public override double Area()
        {
            double a = Math.Sqrt(Math.Pow(_x2 - _x1, 2) + Math.Pow(_y2 - _y1, 2));
            return a*a;
        }

        public override double Perimetr()
        {
            double a = Math.Sqrt(Math.Pow(_x2 - _x1, 2) + Math.Pow((_y2 - _y1), 2));
            return a*4;
        }
    }
     class bill:
        Square
    {

    }
    abstract class bill2:Figure

    {

    }
}
