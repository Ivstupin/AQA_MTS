using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
/*Задание 1:
Заменить в строке все вхождения 'test' на 'testing'. Удалить из текста все символы, являющиеся цифрами. */
internal class Program1
{
    private static void Main1(string[] args)
    {
        string test = "fgtest5757test5675tet00";
        Console.WriteLine($"originString: {test}");
        string replacedStringtest = test.Replace("test", "testing");
        Console.WriteLine($"Replace: {replacedStringtest}");
        char[] charsNumbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        while (replacedStringtest.IndexOfAny(charsNumbers) > -1)
        {
            replacedStringtest = replacedStringtest.Remove(replacedStringtest.IndexOfAny(charsNumbers), 1);
        }
        Console.WriteLine($"{replacedStringtest}");
    }
}
