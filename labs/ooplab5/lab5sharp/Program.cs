using System;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            var ltstr = new LetterStrings("coolstorybob");
            Console.WriteLine(ltstr.GetStr());
            ltstr.Shift();
            Console.WriteLine(ltstr.GetStr());
            Console.WriteLine(ltstr.GetLength());
        }
    }
}