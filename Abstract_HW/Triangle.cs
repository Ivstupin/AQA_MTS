
namespace Abstract_HW
{
    public class Triangle : Figure
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }


        public override double Area()
        {
            // рассчитываем площадь по формуле Герона через полупериметр
            double semiperimeter = Perimeter() / 2; // a + b + c) / 2; //полупериметр
            double area = Math.Sqrt(semiperimeter * (semiperimeter - A) * (semiperimeter - B) * (semiperimeter - C));
            return area;
        }
        public override double Perimeter() //периметр треугольника  P=a+b+c где a, b, c - длины сторон треугольника.
        {
            return A + B + C;
        }

        public Triangle(double A, double B) 
        {
            this.A = A;
            this.B = B;
        } //конструктор для прямоугольника
        public Triangle(double A) 
        {
            
        } //конструктор для круга
        public Triangle(double A, double B, double C) 
        { 
            this.A = A;
            this.B = B;
            this.C = C;
        }
    }
}
 



/*S=\sqrt{p(p - a)(p-b)(p-c)} \] S - площадь разностороннего треугольника, a, b и c - длины трех сторон, p - полупериметр треугольника, равный (a+b+c)/2.
 * Прежде чем применять формулу Герона, необходимо вычислить полупериметр треугольника. Это можно сделать, сложив длины всех трех сторон и разделив на 2. 
 * После этого мы можем подставить значения длин сторон и полупериметра в формулу Герона и вычислить площадь треугольника.*/