using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceApp
{
     public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }


        public Product(int productId, string productName, decimal price, int stock)
        {
            ProductID = productId;
            ProductName = productName;
            Price = price;
            Stock = stock;
        }

        public void IncreaseStock(int amount)
        {
         Stock += amount;
         Console.WriteLine("Stock updated");
        }

        public void DecreaseStock(int amount)
        {
            if (Stock >= amount)
            {
            Stock -= amount;
            Console.WriteLine("Stock reduced");
            }
        }
    }
}

