using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_HW
{
    public class TestData
    {
        public static object[] DivideCasesInt =
           {
            new object[] {23,3,7},
            new object[] {24,2,12},
            new object[] {24,4,6},
            new object[] {24,1,24},
            new object[] {24,24,1},
            new object[] {-24,4,-6},
            new object[] {24,-4,-6},
            new object[] {-24,-4,6}
        };

        public static object[] DivideCasesDouble =
          {
            new object[] { 3.0, 2.0, 1.5 },
            new object[] { -3.0, 2.0, -1.5 },
            new object[] { 3.0, -2.0, -1.5 },
            new object[] { -3.0, -2.0, 1.5 },
            new object[] { 18.40, 5.7, 3.2280701754385963d}
        };
    }
}
