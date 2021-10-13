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

        public static int partCount;

        public static BindingList<Part> partStockPile = new BindingList<Part>();
        internal object associatedParts;

        public Part(int pID, string Frank, int inS, decimal price, int max, int min)
        {
            PartID = pID;
            this.Name = Frank;
            InStock = inS;
            Price = price;
            Max = max;
            Min = min;
           
        }

        public Part(string n, int inS, decimal price, int max, int min)
        {
            PartID = partCount++;
            Name = n;
            InStock = inS;
            Price = price;
            Max = max;
            Min = min;
        }

        internal void Add(Part selectedPart)
        {
            throw new NotImplementedException();
        }
    }
}

