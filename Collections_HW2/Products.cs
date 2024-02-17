using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_HW2
{
    public class Products
    {
        

        public string ProductsName { get; set; }

        public int Price { get; set; }

        public int Quantity { get; set; }

        public Products( string productsName, int price, int quantity)
        {
            
            ProductsName = productsName;
            Price = price;
            Quantity = quantity;
        }
    }
}
