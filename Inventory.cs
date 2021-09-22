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

        public static Part CurrentPart { get; set; }
        public static int CurrentPartID { get; set; }
        public static int CurrentPartIndex { get; set; }
        public static int CurrentPartName { get; set; }
        public static int CurrentPartMin { get; set; }
        public static int CurrentPartMax { get; set; }
    

        // Part Methods
        public static void addPart(Part part)
            {
                partStockPile.Add(part);
            }


        public static Part lookupPart(int currentPartID)
        {
            throw new NotImplementedException();
        }

        internal static void swap (Part part)
        {

        }



        public static bool updatePart (Part part, int PartID)
        {
            PartStockPile.RemoveAt(PartID);
            PartStockPile.Insert(PartID, part);
            return true;
        }
    }
}
