// Задание 3
//Создайте и заполните массив случайным числами и выведете максимальное, минимальное и среднее значение.
//Для генерации случайного числа используйте метод Random() . Пусть будет возможность создавать массив произвольного размера. Пусть размер массива вводится с консоли.


using System;

namespace Arrays3 // Note: actual namespace depends on the project name.
{
    static class Program3
    {
        static void Main3(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.Write("Введите количество элементов будущего массива: \t");

                int countValuesOfArrays = Convert.ToInt32(Console.ReadLine());
                int[] array = new int[countValuesOfArrays]; // введённое значение присваем в размерность массива

                int maxValueOfArrays = array[0]; // максимальное значение в массиве
                int minValueOfArrays = array[0]; // минимальное значение в массиве
                int averageValueOfArrays = array[0]; // среднее значение в массиве

                Console.WriteLine("Вывод массива:");
                for (int i = 0; i <= array.GetUpperBound(0); i++)
                {
                    array[i] = new Random().Next(10); // рандом в массив
                    Console.WriteLine(array[i]);
                }

                for (int i = 0; i <= array.GetUpperBound(0); i++) // цикл для макс значения
                {
                    if (array[i] > maxValueOfArrays)
                    {
                        maxValueOfArrays = array[i];
                    }
                }
                Console.WriteLine($"Максимальное значение в массиве: \t{maxValueOfArrays}");

                for (int i = 0; i <= array.GetUpperBound(0); i++) // цикл для мин значения
                {
                    if (array[i] < minValueOfArrays)
                    {
                        minValueOfArrays = array[i];
                    }
                }
                Console.WriteLine($"Минимальное значение в массиве: \t{minValueOfArrays}");

                for (int i = 0; i <= array.GetUpperBound(0); i++) // цикл для среднего значения
                {

                    if (minValueOfArrays < array[i] && array[i] < maxValueOfArrays)
                    {
                        averageValueOfArrays = array[i];

                    }
                }
                Console.WriteLine($"Среднее значение в массиве:       \t{averageValueOfArrays}");

                Console.ReadLine();
            }
        }
    }
}
        
        
    

    

            
        
    
