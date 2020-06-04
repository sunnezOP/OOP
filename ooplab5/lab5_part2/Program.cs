using System;

namespace lab5_part2
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure square = new Square(2, 3, 4, 2, 6, 8, 1, 1);
            Figure circle = new Circle(4);
            Console.WriteLine(square.Perimetr());
            Console.WriteLine(square.Area());
            Console.WriteLine(circle.Perimetr());
            Console.WriteLine(circle.Area());
        } 

    }
}