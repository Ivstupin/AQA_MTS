using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_HW
{
    public static class Calculator

    {
        public static int Divide(int a, int b)
        {
            return a/b;
        }

        public static double Divide(double a, double b)
        {
            if (b == 0) throw new DivideByZeroException();
            return a/b;
        }

    }
}
