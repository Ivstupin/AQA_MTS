using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_HW2
{
    public class Batch : Product1
    {
        //(название, цена, количество шт, дата производства, срок годности)
        public string? name;
        public double price;
        public int quantity;
        public DateTime production_Date;  //дата производства
        public DateTime expiration_Date; // срок годности

        public Batch(string name, double price, int quantity, DateTime production_Date, DateTime expiration_Date)
        {
            this.name = name;
            this.price = price;
            this.production_Date = production_Date;
            this.expiration_Date = expiration_Date;
            this.quantity = quantity;
        }


        public override void PrintInfo()
        {
            Console.WriteLine($"""
            название: {name}
            цена: {price}
            количество: {quantity}
            дата производства: {production_Date}
            срок годности : {expiration_Date}
            """);
        }


        public override void StorageLife(DateTime sysdate)        //поиск просроченного товара (на момент текущей даты).

        {
            if (sysdate < expiration_Date)
            {
                Console.WriteLine("партия не просрочена");
            }
            else
            {
                Console.WriteLine("партия просрочена");
            }



        }
    }
}
