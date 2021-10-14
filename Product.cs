

using System.ComponentModel;

namespace InventoryProjectDLyn
{
     class Product
    {
        public int ProductID { get; set; }

        public string Name { get; set; }

        public int InStock { get; set; }

        public decimal Price { get; set; }

        public int Min { get; set; }

        public int Max { get; set; }
        public BindingList<Part> associatedPart = new BindingList<Part>();


        public static int productCount;




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
            ProductID = productCount++;
            Name = n;
            InStock = inS;
            Price = price;
            Max = max;
            Min = min;
        }

        

        
    }
}
