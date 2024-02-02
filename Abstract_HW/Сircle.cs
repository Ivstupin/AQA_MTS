
namespace Abstract_HW
{
    public class Сircle : Rectangle 
    {
        
        public double A { get; set; }
        public Сircle(double A) : base(A) { this.A = A; }

        public override double Area()  // Формула расчета площади окружности S = π * R 2.
        {
            return Math.PI * Math.Pow(A, 2);
        }
        public override double Perimeter() //  2 * π * r
        {
            return 2 * Math.PI * A;
        }
    }
}
