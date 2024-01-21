using OOP_HW.Triangles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HW
{
    public  class IsoscelesTriangle : Triangle
    {
        public IsoscelesTriangle(double a, double b, double c) : base(a, b, c)
        {

        }
        
        public override void Area()
        {
            double IsoscelesTriangle = c/4 * Math.Sqrt(4 * (a*a) - (c*c));
            Console.WriteLine($"S равнобедренного(IsoscelesTriangle) треугольника: {IsoscelesTriangle} см2");
        }
    }
}
/*Чтобы найти площадь равнобедренного треугольника, S = AC/4 * корень(4*(AB в квадрате)-AC в квадрате)
 * AC - основание, AB - сторона*/ 