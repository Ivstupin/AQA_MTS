using System.Collections;
using System.Collections.Generic;

namespace Collections_HW2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OperationsInvent operationsInvent = new();

                operationsInvent.AddUniqueId(new Products("Молоко", 99, 132));
                operationsInvent.AddUniqueId(new Products("Хлеб", 111, 68));
                operationsInvent.AddUniqueId(new Products("Сыр", 390, 109));

            while (true)
            {
                Console.Clear();

                Console.WriteLine($"""
               ----------------------------------------------------
               ----------------------Магазин-----------------------
               ----------------------------------------------------

               Чтобы просмотреть список всех товаров введите цифру 1
               ----------------------------------------------------
               Чтобы найти товар по идентификатору введите цифру 2 
               ----------------------------------------------------
               Чтобы обновить информацию о товаре введите цифру 3
               ----------------------------------------------------
               Чтобы удалить товар введите цифру 4
               ----------------------------------------------------
               
               """);

                string usersPrint = Console.ReadLine();

                switch (usersPrint)
                {
                    case "1":
              
                        operationsInvent.PrintAllProductsWithId();
                        Console.ReadLine();
                        break;

                    case "2":
                        operationsInvent.FindProductsById();
                        Console.ReadLine();
                        break;

                    case "3":

                        operationsInvent.RefreshParamsProducts();
                        Console.ReadLine();
                        break;

                    case "4":
                        operationsInvent.DeleteProducts();
                        Console.ReadLine();
                        break;
                }

            }


            
        }
    }
}

    
