using System;
using System.Collections.Generic;
using System.Text;

namespace Nezhevets
{
    class Matrix
    {
        char[][] array;
        int vowels;

        public Matrix(char[][] arr)
        {
            array = arr;
        }

        public char[] this[int index]
        {
            get
            {
                if (index == 1)
                {
                    char[] diag = new char[array.Length];
                    int k = -1;
                    for (int i = 0; i < array.Length; i++)
                    {
                        for (int j = 0; j < array.Length; j++)
                        {
                            if (i == j) diag[++k] = array[i][j];
                        }
                    }
                    return diag;
                }
                else
                {
                    char[] diag = new char[array.Length];
                    int k = -1;
                    for (int i = 0; i < array.Length; i++)
                    {
                        for (int j = 0; j < array.Length; j++)
                        {
                            if (i == j) diag[++k] = array[j][i];
                        }
                    }
                    return diag;
                }
            }
        }
        public int Vowels
        {
            get
            {
                vowels = VowelsCount();
                return vowels;
            }
        }
        int VowelsCount()
        {
            int number = 0;
            char[] vowels = { 'a', 'e', 'i', 'u', 'o', 'y' };
            Dictionary<char, int> dict = new Dictionary<char, int>(vowels.Length);
            foreach (char ch in vowels)
                dict.Add(ch, 0);
            for (int i = 0; i < array.GetLength(0); i++)
            {
                foreach (char ch in array[i])
                {
                    if (dict.ContainsKey(ch))
                        number++;
                }
            }
            return number;
        }
    }
}