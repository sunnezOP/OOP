using System;

namespace lab2csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var str1 = new Mystring("hgffkmf223");
            var str2 = new Mystring("htr21");
            str2 = new Mystring(null);

            var text = new Text();
            text.AddString(str1);
            text.AddString(str2);
            text.RemoveString(2);
            text.Replace(2, str1);
            text.Numberofcolums();
            text.NumbersinText();
            text.Erase();
            //Console.WriteLine(text.NumbersinText());
        }
    }
}
