using System;

namespace Nezhevets
{
    class Program
    {
        static void Main(string[] args)
        {
            char[][] arr = new char[][]
            {
                     new char[] {'a','b','c','d'},
                     new char[] {'e','f','g','h'},
            };

            var matr = new Matrix(arr);

            Console.WriteLine(matr.Vowels);
        }
    }
}
