using System.Collections.Generic;
using System.Linq;

namespace Collections_HW3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>();
            intList.Add(1);
            intList.Add(2);
            intList.Add(3);
            intList.Add(4);
            intList.Add(4);
            intList.Add(5);

            foreach (var item in intList)
            {
                Console.Write(item);
            }

            Console.WriteLine();

            var result = intList.Distinct();
            foreach (var item in result)
            {
                Console.Write(item);
            }
        }
    }
}

/*
 Коллекция содержит набор чисел в виде одной строки "1, 2, 3, 4, 4, 5". Избавиться от повторяющихся элементов в строке и вывести результат на экран.
 */