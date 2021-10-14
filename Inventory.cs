using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace InventoryProjectDLyn
{
    class Inventory
    {

        private static BindingList<Part> partStockPile = new BindingList<Part>();
        //provides the PartStockPile List
        public static BindingList<Part> PartStockPile { get { return partStockPile; } set { partStockPile = value; } }

        private static BindingList<Product> productStockPile = new BindingList<Product>();
        //provides the PartStockPile List
        public static BindingList<Product> ProductStockPile { get { return productStockPile; } set { productStockPile = value; } }




        //records the current part chosen
        public static Part CurrentPart { get; set; }
        public static int CurrentPartID { get; set; }
        public static int CurrentPartIndex { get; set; }
        public static int CurrentPartName { get; set; }
        public static int CurrentPartMin { get; set; }
        public static int CurrentPartMax { get; set; }
        public static object TempPartInventory { get; internal set; }
        public static string PartTxt { get; set; }

        //records the current product chosen
        public static Product CurrentProduct { get; set; }
        public static int CurrentProductID { get; set; }
        public static int CurrentProductIndex { get; set; }
        public static int CurrentProductName { get; set; }
        public static int CurrentProductMin { get; set; }
        public static int CurrentProductMax { get; set; }
        public static object TempProductInventory { get; internal set; }
        public static string ProductTxt { get; set; }

        //records the current upperindex and lowerindex
        public static int CurrentIndexUpper { get; set; }
        public static int CurrentIndexLower { get; set; }

        //Product Methods
        public static Product LookupProduct(int currentProductID)
        {
            foreach (Product product in ProductStockPile)
            {
                if (product.ProductID == currentProductID)
                {
                    return product;
                }
            }
            Product emptyProduct = null;
            return emptyProduct;
        }

        // Part Methods
        public static void addPart(Part part)
        {
            PartStockPile.Add(part);
        }

        public static void addProduct(Product product)
        {
            ProductStockPile.Add(product);
        }

        //given an index it looks up a part with that ID
        public static Part lookupPart(int currentPartID)
        {
            foreach (Part part in PartStockPile)
            {
                if (part.PartID == currentPartID)
                {
                    return part;
                }
            }
            Part emptyPart = null;
            return emptyPart;
        }


        public static void swap (Part part)
        {
            //swap methods take current part and swaps with the new object just created
            PartStockPile.RemoveAt(CurrentPartID);
            PartStockPile.Add(part);

            for (int i = 0; i < PartStockPile.Count; i++)
            {
                if(PartStockPile[i].PartID == part.PartID)
                {
                    PartStockPile[i] = part;
                    return;
                }
            }
        }

       public static void update(Product product)
        {
            for (int i = 0; i < ProductStockPile.Count; i++)
            {
                if (ProductStockPile[i].ProductID == product.ProductID)
                    {
                    ProductStockPile[i] = product;
                    return;

                }
            }
        }
                
    }
}
