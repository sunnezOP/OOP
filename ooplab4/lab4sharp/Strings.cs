using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lab4
{
    class Strings
    {
        string str;
        int size;
        public Strings()
        {

        }
        public Strings(string s)
        {
            str = s;
        }
        public Strings(Strings s)
        {
            str = s.str;
        }
        public int CountLength()
        {
            size = str.Length;
            return size;
        }
        public string GetStr()
        {
            return str;
        }   
        public static Strings operator +(Strings c1, Strings c2)
        {
            return new Strings { str = String.Concat(c1.str, c2.str) };
        }
        public static Strings operator !(Strings c1)
        {
            var Str = new Strings(c1);
            var Str1 = new Strings(c1+c1);
            string st = Str1.str.ToString();
            char[] mass = st.ToCharArray();
            int j = 0;
            for (int i = 0; i < Str1.str.Length; i+=2)
            {
                mass[i] = Str.str[j];
                mass[i + 1] = Str.str[j];
                j++;
            }
            string updatedstr = new string(mass);
            var Str3 = new Strings(updatedstr);
            return Str3;
        }
    }
}