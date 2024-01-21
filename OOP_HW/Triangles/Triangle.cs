using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_HW;

namespace OOP_HW.Triangles
{ //родитель треугольников и квадратов

    public abstract class Triangle
    {
        public double a;
        public double b;
        public double c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public Triangle(double A, double B)
        {
            a = A;
            b = B;
        }

        public abstract void Area();
    }
}





        
    
   



