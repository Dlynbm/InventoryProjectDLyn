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
        public static BindingList<Part> TempList { get { return partStockPile; } set { partStockPile = value; } }
       
        //provides the PartStockPile List
        public static BindingList<Part> PartStockPile { get { return partStockPile; } set { partStockPile = value; } }

        //records the current part chosen
        public static Part CurrentPart { get; set; }
        public static int CurrentPartID { get; set; }
        public static int CurrentPartIndex { get; set; }
        public static int CurrentPartName { get; set; }
        public static int CurrentPartMin { get; set; }
        public static int CurrentPartMax { get; set; }
        public static object TempPartInventory { get; internal set; }
        public static string PartTxt { get; set; }


        // Part Methods
        public static void addPart(Part part)
            {
            PartStockPile.Add(part);
            }

        //given an index it looks up a part with that ID
        public static Part lookupPart(int currentPartID)
        {
            foreach (Part part in PartStockPile)
            {
                if(part.PartID == currentPartID)
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
        }
    }
}
