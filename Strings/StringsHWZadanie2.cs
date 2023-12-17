using System.Text;
using System.Text.RegularExpressions;

namespace StringApp
{
    /* Используя метод вывода значения в консоль, выполните конкатенацию слов и выведите на экран следующую фразу:
Welcome to the TMS lessons.
Каждое слово должно быть записано отдельно и взято в кавычки, например "Welcome". Не забывайте о пробелах после каждого слова */


    static class Program2
    {
        static void Main2(string[] args)
        {
            string string1 = "Welcome ";
            string string2= "to ";
            string string3 = "the ";
            string string4 = "TMS ";
            string string5 = "lessons.";
            string stringConcat = string1 + string2 + string3 + string4 + string5;
            Console.WriteLine(stringConcat);
        }
    }
}