namespace Generics_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point<int> pointInt = new(5,8);
            Point<string> pointString = new("5", "8");
            pointInt.Print();
            pointString.Print();
        } 
    }
}


   /* Реализовать класс Point, который определяет точку на координатной плоскости. В классе реализовать:
внутренние поля x, y;
конструктор с 2 параметрами;
свойства доступа к внутренним полям класса;
метод, выводящий значения внутренних полей класса.
   */
    