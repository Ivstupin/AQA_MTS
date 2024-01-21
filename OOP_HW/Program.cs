using OOP_HW.Triangles;
namespace OOP_HW

{
    internal class Program
    {
        static void Main(string[] args)
        {
            
             Triangle[] triangles = {

             new LogicCreatingTriangle(3, 4, 5).ReturnTriangleType(),
             new LogicCreatingTriangle(7, 8, 9).ReturnTriangleType(),
             new LogicCreatingTriangle(8, 8, 8).ReturnTriangleType(),
             new LogicCreatingTriangle(9, 9, 10).ReturnTriangleType(),
             new Square(10,10),
             new Square(7,5)

         };
            for (int i = 0; i < triangles.Length; i++)
             {
                 triangles[i].Area();
             }
        }
    }
}
/*
 * Задание 1:
Создать класс для подсчета площади треугольников
реализовать классы для равнобедренного, равностороннего, прямоугольного и разностороннего треугольника
для каждого использовать свою формулу для подсчета площади
площадь разностороннего треугольника считаем по формуле герона
Создать отдельный класс который будет отвечать за логину создания треугольников. В нем вернуть нужный объект треугольника проверив его стороны
добавить класс квадрат и прямоугольник и логику подсчета площади для него
добавить класс для реализации иерархии фигур
создавь массив квадратов, прямоугольник и треугольников и вывести их площади
*/
