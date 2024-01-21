using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_HW.Triangles;

namespace OOP_HW
{
    public class RightAngledTriangle : Triangle
    {
        public RightAngledTriangle(double a, double b, double c) : base(a, b, c)
        {

        }

        public override void Area()
        {
            double RightAngledTriangle = a * b / 2;
            Console.WriteLine($"S прямоугольного(RightAngledTriangle) треугольника : {RightAngledTriangle} см2");
        }
    }
}
/*Площадь прямоугольного определяется за формулой равной половине произведения катетов треугольника. S=1/2 (a*b). 
    Где a и b - катеты прямоугольного треугольника. S - площадь прямоугольного треугольника (измеряется в сантиметрах квадратных см^2). 
    Пример: Катеты прямоугольного треугольника равны a=4 см, b = 6 см. В таком случае площадь прямоугольного треугольника будет равна: S = 1 / 2 * (4 * 6) = 12 см ^ 2. (сантиметров квадратных).*/