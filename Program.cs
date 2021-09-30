using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryProjectDLyn
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            //initialize test data
            Inventory.PartStockPile.Add(new InHouse(1, "Top", 101, 12.99m, 150, 1, 100));
            Inventory.PartStockPile.Add(new InHouse(2, "Bottom", 102 , 15.99m, 130, 5, 100));
            Inventory.PartStockPile.Add(new Outsourced(3, "Side", 10, 9.99m, 100, 10, "DM Designs"));
            Inventory.PartStockPile.Add(new Outsourced(4, "Middle", 104, 5.99m, 150, 100, "Shuman"));


            Application.Run(new Form1());
        }
    }
}
