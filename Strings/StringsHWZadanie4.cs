using System.Data.SqlTypes;
using System.Text;
using System.Text.RegularExpressions;

namespace StringApp
{ /* Задание 4
Дана строка: “Плохой день.”
Необходимо с помощью метода substring удалить слово "плохой". После чего необходимо используя команду insert создать строку со значением: Хороший день!!!!!!!!!.
Заменить последний "!" на "?" */


    static class Program
    {
        static void Main(string[] args)
        {
            string badDay = "Плохой день.";
            Console.WriteLine(badDay);
            string day = badDay.Substring(6);
            Console.WriteLine(day);
            string goodDay = day.Insert(0, "Хороший");
            Console.WriteLine(goodDay);
            string goodDay1 = goodDay.Insert(goodDay.Length-1, "!!!!!!!!!");
            Console.WriteLine(goodDay1);
            string question = goodDay1.Replace("!!!!!!!!!", "!!!!!!!!?");
            Console.WriteLine(question);
        }
    }
}