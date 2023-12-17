using System.Text;
using System.Text.RegularExpressions;

namespace StringApp
{
    /* Дана строка: “teamwithsomeofexcersicesabcwanttomakeitbetter.”
 Необходимо найти в данной строке "abc", записав всё что до этих символов в первую переменную, а также всё, что после них во вторую.
 Результат вывести в консоль. */


    static class Program3
    {
        static void Main3(string[] args)
        {
            string origin = "teamwithsomeofexcersicesabcwanttomakeitbetter";
            string[] originSlpit = origin.Split("abc");
            string origin1 = originSlpit[0];
            string origin2 = originSlpit[1];
            Console.WriteLine($"{origin1} {origin2}");

        }
    }
}