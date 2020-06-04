using System;

namespace lab8sharp
{
    class Program
    {
        delegate int str(string a);
        static void Main(string[] args)
        {
            str string1 = new str(String_check.Islower);
            Console.WriteLine(string1.Invoke("God of WW"));
            String_check2 string2 = new String_check2();
            Console.WriteLine(string2.Islower("God of WW"));
        }
    }
}