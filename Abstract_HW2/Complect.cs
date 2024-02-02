using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Abstract_HW2
{
    internal class Complect : Product1
    {
        //(названия, цена, перечень продуктов)
        public string? name;
        public double price;
        public DateTime production_Date;  //дата производства
        public DateTime expiration_Date; // срок годности
        public string [] products;  //перечень продуктов
        
        public Complect(string name, double price, string[] products, DateTime production_Date, DateTime expiration_Date)     //перечень продуктов
        {
            this.price = price;
            this.products = products;
            this.name = name;
            this.production_Date = production_Date;
            this.expiration_Date = expiration_Date;
        }

        public override void PrintInfo()
        {

            Console.WriteLine($"""
            название: {name}
            цена: {price}
            перечень продуктов: 
            """);
            for (int i = 0; i < products.GetLength(0); i++) // цикл для вывода массива на консоль
            {
                Console.WriteLine(products[i]);
            }
        }


        public override void StorageLife(DateTime sysdate)
        {


            if (sysdate < expiration_Date)
            {
                Console.WriteLine("комплект не просрочен");
            }
            else
            {
                Console.WriteLine("комплект просрочен");
            }

        }
    }
}

