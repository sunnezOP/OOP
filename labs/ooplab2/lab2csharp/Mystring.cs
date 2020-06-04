using System;
//using System.Collections.Generic;
//using System.Text;

namespace lab2csharp
{
    class Mystring
    {
        char[] mystring;
        public Mystring(string str)
        {
            mystring = str.ToCharArray();
        }
        public string Numbers()
        {
            string str="";
            for (int i = 0; i < mystring.Length; i++)
            {
                if (char.IsDigit(mystring[i]))
                {
                    str += mystring[i];
                }
            }
            return str;
        }
    }
}
