using OOP_HW.Triangles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HW
{
    public class Rectangle : Triangle
    {
        public Rectangle(double A, double B) : base(A, B)
        {

        }

        public override void Area()
        {
            double Square = a * b;
            Console.WriteLine($"S треугольника(Rectangle): {Square} см2");
        }
    }
}
