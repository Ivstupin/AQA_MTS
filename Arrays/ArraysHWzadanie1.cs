//Создайте массив целых чисел. Напишете программу, которая выводит сообщение о том, входит ли заданное число в массив или нет. Пусть число для поиска задается с консоли.
namespace Arrays // Note: actual namespace depends on the project name.
{
    static class Program1
    {
        static void Main1(string[] args)
        {
            while (true)
            {
                Console.Clear();
                try
                {
                    int[] array = { 1, 9, 3, 6, 6, 5 };
                    Console.WriteLine("Введите целое число для поиска в массиве: ");
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
                catch (Exception)
                {
                    Console.WriteLine("Для ввода доступны только целые числа");
                }
                Console.WriteLine("Нажмите ENTER чтобы начать заново");
                Console.ReadLine();
            }
        }
    }
}