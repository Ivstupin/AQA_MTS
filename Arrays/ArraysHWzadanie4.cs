//Задание 4
//Создайте 2 массива из 5 чисел.
//Выведите массивы на консоль в двух отдельных строках.
//Посчитайте среднее арифметическое элементов каждого массива и сообщите, для какого из массивов это значение оказалось больше (либо сообщите, что их средние арифметические равны).



using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Arrays4 // Note: actual namespace depends on the project name.
{
    static class Program4
    {
        static void Main4(string[] args)
        {
            
            int[] array1 = { 1, 80, 6, 2, 3 };
            int[] array2 = { 1, 90, 6, 2, 3 };
            int averageValueOfArrays1 = 0; // среднее значение в массиве1
            int averageValueOfArrays2 = 0; // среднее значение в массиве2


            Console.Write("Вывод массива1 на консоль:\t");
            for (int i = 0; i <= array1.GetUpperBound(0); i++)
            {
                Console.Write(array1[i]);
                averageValueOfArrays1 += array1[i];
            }
            
            Console.WriteLine();
            Console.Write("Вывод массива2 на консоль:\t");
            for (int i = 0; i <= array2.GetUpperBound(0); i++)
            {
                Console.Write(array2[i]);
                averageValueOfArrays2 += array2[i];
            }

            Console.WriteLine();
            Console.WriteLine();
            averageValueOfArrays1 /= 5;
            averageValueOfArrays2 /= 5;

            if (averageValueOfArrays1 > averageValueOfArrays2)
                Console.WriteLine($"Среднее арифметическое значение массива1 - {averageValueOfArrays1} больше чем среднее арифметическое значение массива2 - {averageValueOfArrays2}");

            else if (averageValueOfArrays1 < averageValueOfArrays2)
                Console.WriteLine($"Среднее арифметическое значение массива2 - {averageValueOfArrays2} больше чем среднее арифметическое значение массива1 - {averageValueOfArrays1}");

            else
                Console.WriteLine($"Среднее арифметическое значение массива1 - {averageValueOfArrays1} равно среднему арифметическому значению массива2 - {averageValueOfArrays2}");
        }
    }
}
        
        
    

    

            
        
    
