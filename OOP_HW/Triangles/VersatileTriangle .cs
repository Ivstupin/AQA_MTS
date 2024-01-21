using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_HW.Triangles;


namespace OOP_HW
{

    public class VersatileTriangle(double a, double b, double c) : Triangle(a, b, c)
    {
        public override void Area()
        {
            double semiperimeter = (a + b + c) / 2; //полупериметр
            
            double areaVersatileTriangle = Math.Sqrt(semiperimeter * (semiperimeter - a) * (semiperimeter - b) * (semiperimeter - c));
            Console.WriteLine($"S разностороннего(VersatileTriangle) треугольника: {areaVersatileTriangle} см2");
        }
    
    }
    
    
}



/*S=\sqrt{p(p - a)(p-b)(p-c)} \] S - площадь разностороннего треугольника, a, b и c - длины трех сторон, p - полупериметр треугольника, равный (a+b+c)/2.
 * Прежде чем применять формулу Герона, необходимо вычислить полупериметр треугольника. Это можно сделать, сложив длины всех трех сторон и разделив на 2. 
 * После этого мы можем подставить значения длин сторон и полупериметра в формулу Герона и вычислить площадь треугольника.*/