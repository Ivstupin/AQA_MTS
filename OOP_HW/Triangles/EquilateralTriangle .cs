using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using OOP_HW.Triangles;

namespace OOP_HW
{


    public class EquilateralTriangle : Triangle
    {
        public EquilateralTriangle(double a, double b, double c) : base(a, b, c)
        {

        }

        public override void Area()
        {
            double EquilateralTriangle = a*a * Math.Sqrt(3)/4;
            Console.WriteLine($"S Равностороннего(EquilateralTriangle) треугольника: {EquilateralTriangle} см2");
        }
    }


}
/*Равносторонний тот, у которого все стороны имеют одинаковый размер.
S = a в квадрате * корень из трёх / 4 
*/
