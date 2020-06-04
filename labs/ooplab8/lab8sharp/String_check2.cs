using System;
using System.Collections.Generic;
using System.Text;

namespace lab8sharp
{
    class String_check2
    {
        public int Islower(string a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if ((a[i] == a.ToLower()[i]) && a[i] != ' ') sum++;
            }
            return sum;
        }
    }
}
