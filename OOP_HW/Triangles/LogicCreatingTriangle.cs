using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_HW.Triangles;

namespace OOP_HW
{
    public class LogicCreatingTriangle : Triangle
    {
        public LogicCreatingTriangle(double a, double b, double c) : base(a, b, c)
        {

        }

        
        public Triangle ReturnTriangleType()
        {
            //все стороны равны
            if (a == b && a == c)
            {
                return new EquilateralTriangle(a, b, c);
            }
            // две стороны равны
            else if (a == b || a == c || b == c)
            {
                return new IsoscelesTriangle(a, b, c);
            }
            // прямоугольный
            else if ((c * c) == (a * a) + (b * b))
            {
                return new RightAngledTriangle(a, b, c);
            }
            // разностороний
            else
            {
                return new VersatileTriangle(a, b, c);
            }
        }



        public override void Area()
        {
            
        }
    }

}
