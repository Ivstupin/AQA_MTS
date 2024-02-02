using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_HW2
{
    public class Product2 : Product1
    {
        //(название, цена, дата производства, срок годности),
        public string? name;
        public double price;
        public DateTime    production_Date;  //дата производства
        public DateTime  expiration_Date; // срок годности

        public Product2(string name, double price, DateTime production_Date, DateTime expiration_Date)
        {
            this.name = name;
            this.price = price;
            this.production_Date = production_Date;
            this.expiration_Date = expiration_Date;
        }

        public override void PrintInfo() 
        {
            Console.WriteLine($"""
            название: {name}
            цена: {price}
            дата производства: {production_Date}
            срок годности : {expiration_Date}
            """);
        }


        public override void StorageLife(DateTime sysdate)        //поиск просроченного товара (на момент текущей даты).

        {
            if (sysdate < expiration_Date)
            {
                Console.WriteLine("Товар не просрочен");
            }
            else
            {
                Console.WriteLine("Товар просрочен");
            }

        }

    }
}
