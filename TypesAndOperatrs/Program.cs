namespace TypesAndOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*const string name = "Bob";
            Console.WriteLine($" \t {name}");
            //string name = "Bot";*/

            
            bool isWhiteBreadFresh = true;
            ushort whiteBreadPrice = 150;
            ushort butterPrice = 230;
            ushort milkPrice = 170;
            float milkFatPercentage = 1.2f;
            ushort iceCreamPrice = 350;



            Console.Write($"Введите начальную сумму: ");
            string? sumString = Console.ReadLine();
            short sum = Convert.ToInt16(sumString);

            if (sum > 0)
            {




                if (!isWhiteBreadFresh)
                {
                    Console.WriteLine($"Батон не свежий");
                }

                else if (sum >= whiteBreadPrice)
                {
                    if (sum>= whiteBreadPrice)

                    {
                        sum = Convert.ToInt16(sum - whiteBreadPrice);
                    }
                    else
                    {
                        Console.WriteLine($"Денег не хватает");
                    }
                    

                }
                else
                {
                    Console.WriteLine($"Батон не свежий");
                }

                sum = (short)(sum - butterPrice);

                if (milkFatPercentage == 1.2f)
                {
                    sum = Convert.ToInt16(sum - milkPrice);
                }
                if (sum >= iceCreamPrice)
                {
                    sum = Convert.ToInt16(sum - iceCreamPrice);
                }
                Console.WriteLine($"Остаток суммы: {sum}");
            }

            else
            {
                Console.WriteLine($"Сумма не может быть меньше 0 или 0 ");
            }
            
            /*


            int j = 20;
            Console.WriteLine("J = " + j);
            Console.WriteLine($"J =  + {j}");
            

            Console.WriteLine("Name");
            string? name = Console.ReadLine();
            Console.WriteLine($"{name}");

            int age = Convert.ToInt32(name); */

        }

        /*string name = "Bot";
        string name = "Bot";
        string name = "Bot";
        string name = "Bot";*/
    }
}