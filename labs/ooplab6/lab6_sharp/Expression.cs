using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    class Expression
    {
        double _a, _c, _b;

        public Expression(double a, double b, double c)
        {
            _a = a;
            _c = c;
            _b = b;
        }
        public void Set_a(double a)
        {
            _a = a;
        }
        public void Set_c(double c)
        {
            _c = c;
        }
        public void Set_b(double b)
        {
            _b = b;
        }
        public double Get_a()
        {
            return _a;
        }
        public double Get_c()
        {
            return _c;
        }
        public double Get_b()
        {
            return _b;
        }
        public double GetAnswer()
        {
          //  try
            //{
                if (_c == 0) throw new DivideByZeroException();
                if ((_a>0 && _b<0) || (_a<0 && _b>0) || (_a*_b+2<1)) throw new ArithmeticException();
                if ((41 - _b / _c + 1) == 0) throw new DivideByZeroException();
                return ((Math.Log(_a*_b+2)*_c)/(41-_b/_c+1));
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Divide by Zero! Info: " + ex.Message);
            //    Environment.Exit(0);
            //    return 0;
            //}
            //catch (ArithmeticException ex)
            //{
            //    Console.WriteLine("Negative logarifm! Info: " + ex.Message);
            //    Environment.Exit(1);
            //    return 0;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error! Info: " + ex.Message);
            //    Environment.Exit(2);
            //    return 0;
            //}
        }
    }
}