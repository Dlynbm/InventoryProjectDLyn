using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryProjectDLyn
{
    public partial class AddPartForm : Form
    {
        public AddPartForm()
        {
            InitializeComponent();
        }

        public static object CurrentRow { get; private set; }
        public object DataGridParts { get; private set; }

        private void AddPartCancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }



        private void PartSaveBtn_Click(object sender, EventArgs e)
        {

            //Inventory.PartStockPile.Add(Part);
        }
    }
}
