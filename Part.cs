using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryProjectDLyn
{
    abstract class Part
    {
        //properties
        public int PartID { get; set; }

        public string Name { get; set; } 
            
        public int InStock { get; set; }

        public decimal Price { get; set; }

        public int Min { get; set; }

        public int Max { get; set; }


        private static int partIDHolder = 0;

        public static BindingList<Part> partStockPile = new BindingList<Part>();

        public Part(int pID, string n, int inS, decimal price, int max, int min)
        {
            PartID = pID;
            Name = n;
            InStock = inS;
            Price = price;
            Max = max;
            Min = min;
           
        }

        public Part(string n, int inS, decimal price, int max, int min)
        {
            PartID = ++partIDHolder;
            Name = n;
            InStock = inS;
            Price = price;
            Max = max;
            Min = min;
        }

        

       

    }
}

