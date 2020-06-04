using System;
using System.Collections.Generic;
using System.Text;

namespace lab5_part2
{
    class Circle : Figure
    {
        private int Radius;

        public Circle(int radius)
        {
            Radius = radius;
        }
        public override double Area()
        {
            return 2 * Math.PI * Radius;
        }

        public override double Perimetr()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}