using System;
using System.Collections.Generic;
using System.Text;

namespace lab5
{
    class Strings
    {
        string str;
        public Strings(string s)
        {
            str = s;
        }
        public int GetLength()
        {
            return str.Length;
        }
    }
}