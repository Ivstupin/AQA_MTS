
namespace Abstract_HW
{
    public class Rectangle : Triangle
    {
        
    public double A { get; set; }
        public double B { get; set; }
        public Rectangle(double A) : base(A) 
        { this.A = A; }// наследуем конструктор из треугольника для круга

        public Rectangle(double A, double B) : base(A, B)
        {
            this.A = A;
            this.B = B;
        }

        public override double Area()
        {
            return A * B;
        }
        public override double Perimeter()
        {
            return A + B;
        }
    }
}

