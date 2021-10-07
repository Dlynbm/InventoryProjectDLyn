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
            Inventory.PartStockPile.Add(new InHouse( "Wheel", 101, 12.99m, 150, 1, 100));
            Inventory.PartStockPile.Add(new InHouse( "Peddle", 102 , 15.99m, 130, 5, 100));
            Inventory.PartStockPile.Add(new Outsourced( "Chain", 10, 9.99m, 100, 10, "DM Designs"));
            Inventory.PartStockPile.Add(new Outsourced( "Seat", 104, 5.99m, 150, 100, "Shuman"));

            //Inventory.ProductStockPile.Add(new InHouse(1, "Yellow Car", 101, 12.99m, 150, 1, 100));
            //Inventory.ProductStockPile.Add(new InHouse(2, "Blue Car", 102, 15.99m, 130, 5, 100));
            //Inventory.ProductStockPile.Add(new Outsourced(3, "Red Car", 10, 9.99m, 100, 10, "DM Designs"));
            //Inventory.ProductStockPile.Add(new Outsourced(4, "Black Car", 104, 5.99m, 150, 100, "Shuman"));


            Application.Run(new Form1());
        }
    }
}
