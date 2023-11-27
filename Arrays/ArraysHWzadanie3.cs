// Задание 3
//Создайте и заполните массив случайным числами и выведете максимальное, минимальное и среднее значение.
//Для генерации случайного числа используйте метод Random() . Пусть будет возможность создавать массив произвольного размера. Пусть размер массива вводится с консоли.


using System;

namespace Arrays3 // Note: actual namespace depends on the project name.
{
    static class Program3
    {
        static void Main(string[] args)
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











            /*
           while (true) 
            {
                Console.Clear();

                int[] array = array.Random[]; //создаём массив
                Console.WriteLine("Введите целое число для его удаления из массива [1, 2, 6, 2, 3, 3, 0, 3, 4]: \n");
                int usersNumbersToDelete = Convert.ToInt32(Console.ReadLine());

                int indexUsersNumbersToDelete = 0;  // переменная для хранения индекса в массиве введённого числа
                int countUsersNumbersNotIn = 0; //  счётчик вхождений для обработки значений не из массива
                int countNotDistinctNumbersInArrays = 0; //  счётчик повторяющихся значений в массиве

                for (int i = 0; i < array.GetLength(0); i++) //цикл для поиска индекса
                {
                    if (array[i] == usersNumbersToDelete)
                    {
                        countNotDistinctNumbersInArrays++;
                    }
                    else
                    {
                        countUsersNumbersNotIn += 1;
                    }
}
                if (countUsersNumbersNotIn == array.GetLength(0))
                {
                    Console.WriteLine ($"Число {usersNumbersToDelete} отсутствует в массиве");
                }
                while (countNotDistinctNumbersInArrays >=1) //цикл для обработки повторяющихся значений в массиве
                {
                    int[] newArray = new int[array.GetLength(0) - 1]; //новый массив с уменьшением размера на 1 в каждой итерации цикла while
                    
                    for (int i = 0; i < array.GetLength(0); i++) //цикл для поиска индекса
                    {
                        if (array[i] == usersNumbersToDelete)
                        {
                            indexUsersNumbersToDelete = i;
                        }
                    }
                    
                    for (int i = 0; i < indexUsersNumbersToDelete; i++) // цикл 1,вносим значения в новый массив до введённного символа
                    {
                        newArray[i] = array[i]; // в новый массив вносим значения из старого
                    }

                    for (int i = indexUsersNumbersToDelete + 1; i <= array.GetUpperBound(0); i++) // цикл 2,вносим значения в новый массив после введённого символа + 1, тем самым пропуская введённое значение
                    {
                        newArray[i - 1] = array[i]; 
                    }

                    countNotDistinctNumbersInArrays -= 1; // уменьшаем счётчик повторяющихся символов в массиве на 1 в кажой итерации

                    array = newArray;  // присваиваем в старый массив новый
                }
                                       
                    for (int i = 0; i < array.GetLength(0); i++) // цикл для вывода массива на консоль
                {
                    Console.WriteLine(array[i]);
                }
                
                Console.ReadLine(); // ожидание ввода с  консоли */
        }
        }
    }

    

            
        
    
