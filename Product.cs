using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryProjectDLyn
{
    public class Product
    {
        public int ProductID { get; set; }

        public string Name { get; set; }

        public int InStock { get; set; }

        public decimal Price { get; set; }

        public int Min { get; set; }

        public int Max { get; set; }

        public static BindingList<Product> productStockPile = new BindingList<Product>();


        public Product(int pID, string n, int inS, decimal price, int max, int min)
        {
            ProductID = pID;
            Name = n;
            InStock = inS;
            Price = price;
            Max = max;
            Min = min;


        }

        public Product(string n, int inS, decimal price, int max, int min)
        {
            //ProductID = pID;
            Name = n;
            InStock = inS;
            Price = price;
            Max = max;
            Min = min;
        }
    }
}
