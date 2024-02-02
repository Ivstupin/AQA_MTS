namespace Abstract_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Figure[] figures =
        {
            new Rectangle(5,5),     // квадрат = 2 стороны раыны
            new Rectangle(5,15),     // прямоугольник = 1 сторона больше другой
            new Triangle(5, 5, 5), // равносторонний треугольник = 3 стороны равны
            new Triangle(5, 5, 8), // равнобедренный треугольник = 2 стороны равны 
            new Сircle(8)            // круг
        };




            // Вывести на экран сумму периметра и площади всех фигур в массиве.
            double perimeterAndArea = 0;
            foreach (Figure figure in figures)
            {
                perimeterAndArea = figure.Area() + figure.Perimeter();
            }
            Console.WriteLine(perimeterAndArea); 
        }
    }
    
}


/*
 
 Задание 1:
Написать иерархию классов «Фигуры».
Фигура -> Треугольник -> Прямоугольник -> Круг.
Реализовать метод подсчета площади и периметра для каждого типа фигуры.
Создать массив из 5 фигур.
Вывести на экран сумму периметра и площади всех фигур в массиве.

 */