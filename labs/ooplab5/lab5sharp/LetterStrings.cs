using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace lab5
{
    class LetterStrings : Strings
    {
        string str, str1, str2;
        public LetterStrings(string s) : base(s)
        {
            str = s;
        }
        public void Shift()
        {
            if (str.Length > 0)
            {
                str1 = string.Concat(str[str.Length - 1].ToString());
                str2 = string.Concat(str.Substring(0, str.Length - 1));
                str = str1 + str2;
            }
        }
        public string GetStr()
        {
            return str;
        }
    }
}