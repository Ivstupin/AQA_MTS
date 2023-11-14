namespace TypesAndOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*const string name = "Bob";
            Console.WriteLine($" \t {name}");
            //string name = "Bot";*/

            /*Console.WriteLine("Добро пожаловать в С#");
            Console.Write("Надеюсь Вы ");
            Console.Write("постигните нюансы в С#! \n");
            Console.WriteLine("И всё будет супер гуд!!!");
            bool isWhiteBreadFresh = true;
            ushort whiteBreadPrice = 150;
            ushort butterPrice = 230;
            ushort milkPrice = 170;
            float milkFatPercentage = 1.2f;



            int j = 20;
            Console.WriteLine("J = " + j);
            Console.WriteLine($"J =  + {j}");
            */

            Console.WriteLine("Name");
            string? name = Console.ReadLine();
            Console.WriteLine($"{name}");

            int age = Convert.ToInt32(name);

        }

        /*string name = "Bot";
        string name = "Bot";
        string name = "Bot";
        string name = "Bot";*/
    }
}