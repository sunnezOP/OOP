using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Strings();
            var c2 = new Strings("12345");
            var c3 = new Strings(c2);

            c3 = !c3;
            c1 = c2 + c3;
            Console.WriteLine(c1.GetStr());
            Console.WriteLine(c2.GetStr());
            Console.WriteLine(c3.GetStr());
        }
    }
}