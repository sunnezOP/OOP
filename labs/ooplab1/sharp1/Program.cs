using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Comparison(int a, int b, out bool res)
        {
            int abinar, bbinar, ibinar;
            res = false;
            for (int i = 0; i < 32; i++)
            {
                ibinar = 1 << i;
                abinar = a & ibinar;
                bbinar = b & ibinar;
                if ((abinar ^ bbinar) != 0)
                {
                    res = false;
                    break;
                }
                else
                {
                    res = true;
                }
            }
        }
        static int adding(int a, int b)
        {
            int result = 0;
            int abinar, bbinar, cbinar = 0, nbinar;
            int bits = 32;

            for (int n = 0; n < bits; ++n)
            {
                nbinar = 1 << n;
                abinar = a & nbinar;
                bbinar = b & nbinar;
                if ((abinar ^ bbinar) != 0)
                {
                    result |= ~cbinar & nbinar;
                }
                else if (abinar != 0)
                {
                    result |= cbinar;
                    cbinar = nbinar;
                }
                else
                {
                    result |= cbinar;
                    cbinar = 0;
                }
                cbinar <<= 1;
            }
            return result;
        }


        static void Main(string[] args)
        {
            bool res;
            int a1 = 4, a2 = 32;
            Program method = new Program();
            Comparison(a1, a2, out res);
            int a = 2, b = 3;
            int ans = adding(a, b);

            Console.ReadLine();
        }
    }
}
