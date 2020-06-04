using System;
using System.Collections.Generic;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            var expressions = new List<Expression>();
            expressions.Add(new Expression(1, 2, 1));
            expressions.Add(new Expression(0, -2, 0));
            try
            {
                foreach (var item in expressions)
                {
                    Console.WriteLine(item.GetAnswer());
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Divide by Zero! Info: " + ex.Message);
                Environment.Exit(0);
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine("Negative logarifm! Info: " + ex.Message);
                Environment.Exit(1);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error! Info: " + ex.Message);
                Environment.Exit(2);
            }
        }
    }
}