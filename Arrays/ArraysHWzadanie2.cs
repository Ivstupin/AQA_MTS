﻿/*Создайте массив целых чисел. Удалите все вхождения заданного числа из массива.
Пусть число задается с консоли. Если такого числа нет - выведите сообщения об этом.
В результате должен быть новый массив без указанного числа.*/

using System;

namespace Arrays // Note: actual namespace depends on the project name.
{
    static class Program
    {
        static void Main(string[] args)
        {

           while (true) 
            {
                Console.Clear();

                int[] array = { 1, 2, 5, 3, 4, 5, 3 }; //создаём массив
                Console.WriteLine("Введите целое число для его удаления из массива [1, 2, 5, 3, 4, 5, 3]: \n");
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
                while (countNotDistinctNumbersInArrays >= 1) //цикл для обработки посторяющихся значений в массиве
                {
                    int[] newArray = new int[array.GetLength(0) - 1]; //новый массив
                    //countUsersNumbersNotIn = 0;
                    for (int i = 0; i < array.GetLength(0); i++) //цикл для поиска индекса
                    {
                        if (array[i] == usersNumbersToDelete)
                        {
                            indexUsersNumbersToDelete = i;

                        }
                    }

                    if (countUsersNumbersNotIn == array.GetLength(0))
                    {
                        //Console.WriteLine($"Число {usersNumbersToDelete} отсутствует в массиве");
                        break;
                    }

                    for (int i = 0; i < indexUsersNumbersToDelete; i++) // цикл 1,вносим значения в новый массив до введённного символа
                    {
                        newArray[i] = array[i];
                    }

                    for (int i = indexUsersNumbersToDelete + 1; i <= array.GetUpperBound(0); i++) // цикл 2,вносим значения в новый массив после введённого символа
                    {
                        newArray[i - 1] = array[i];
                    }

                    countNotDistinctNumbersInArrays = countNotDistinctNumbersInArrays--;

                    array = newArray;  // присваиваем в старый массив новый
                }
                                       
                    for (int i = 0; i < array.GetLength(0); i++) // цикл для вывода массива на консоль
                {
                    Console.WriteLine(array[i]);
                }
                
                Console.ReadLine(); // ожидание вввода с  консоли
            }
        }
    }
}
    

            
        
    
