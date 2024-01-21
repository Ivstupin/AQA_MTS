using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_HW.Triangles;
namespace OOP_HW
{
    public class Square : Triangle
    {
        public Square(double A, double B) : base(A, B)
        {

        }

        public override void Area()
        {
            double Square = a * b;
            Console.WriteLine($"S квадрата(Square): {Square} см2");
        }
    }
}
