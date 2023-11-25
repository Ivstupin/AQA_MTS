//Создайте массив целых чисел. Напишете программу, которая выводит сообщение о том, входит ли заданное число в массив или нет. Пусть число для поиска задается с консоли.
using System.Text;

namespace StringApp // Note: actual namespace depends on the project name.
{
    static class Program
    {
        static void Main1(string[] args)
        {
            while (true)
            {
                int[] array = { 1, 9, 3, 6, 5 };
                Console.WriteLine("Введите целое число для поиска: ");
                int usersNumbers = Convert.ToInt32(Console.ReadLine());
                int tmpUsersNumbersIn = 1;
                int tmptmpUsersNumbersNotIn = 2;

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    if (array[i] == usersNumbers)
                    {
                        tmpUsersNumbersIn = 2;
                    }
                    else
                    {
                        tmptmpUsersNumbersNotIn = 3;
                    }
                }
                if (tmpUsersNumbersIn == 2)
                    Console.WriteLine($"Заданное число {usersNumbers} входит в массив");
                else if (tmptmpUsersNumbersNotIn == 3)
                    Console.WriteLine($"Заданное число {usersNumbers} не входит в массив");
            }
        }
    }
}