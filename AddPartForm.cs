using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            if (InHouseRadio.Checked)
            {
                InHouse inHouse = new InHouse((Inventory.PartStockPile.Count + 1), AddPartNameTxtBx.Text, Convert.ToInt32(SavePartInventoryTxtBx.Text), 
                Convert.ToDecimal(AddPartPriceTxtBx.Text),
                Convert.ToInt32(AddPartMaxTxtBx.Text), Convert.ToInt32(AddPartMinTxtBx.Text), Convert.ToInt32(AddPartMachineCoTxtBx.Text));

                if(String.IsNullOrWhiteSpace(AddPartNameTxtBx.Text))
                {
                    MessageBox.Show("Name cannot be empty");
                }

                if(int.Parse(SavePartInventoryTxtBx.Text) > int.Parse(AddPartMaxTxtBx.Text))
                {
                    MessageBox.Show("Inventory stock level cannot exceed Max stock level");
                    return;
                }

                if (int.Parse(AddPartMinTxtBx.Text) > int.Parse(AddPartMaxTxtBx.Text))
                {
                    MessageBox.Show("Minimum stock level cannot exceed max stock level");
                    return;
                }
                else
                {
                    Inventory.addPart(inHouse);
                }
            }
            else
            {
                OutsourcedRadio.Checked = true;
                Outsourced outsourced = new Outsourced((Inventory.PartStockPile.Count + 1), AddPartNameTxtBx.Text, 
                Convert.ToInt32(SavePartInventoryTxtBx.Text), Convert.ToDecimal(AddPartPriceTxtBx.Text),
                Convert.ToInt32(AddPartMaxTxtBx.Text), Convert.ToInt32(AddPartMinTxtBx.Text), (AddPartMachineCoTxtBx.Text));
                if (String.IsNullOrWhiteSpace(AddPartNameTxtBx.Text))
                {
                    MessageBox.Show("Name cannot be empty");
                }

                if (int.Parse(SavePartInventoryTxtBx.Text) > int.Parse(AddPartMaxTxtBx.Text))
                {
                    MessageBox.Show("Inventory stock level cannot exceed Max stock level");
                    return;
                }

                if (int.Parse(AddPartMinTxtBx.Text) > int.Parse(AddPartMaxTxtBx.Text))
                {
                    MessageBox.Show("Minimum stock level cannot exceed max stock level");
                    return;
                }
                else
                {
                    Inventory.addPart(outsourced);
                }

            }
            
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void checkRadioBtn()
        {
            if (InHouseRadio.Checked)
            {
                PartMachineLbl.Text = "Machine Id:";
            }
            else
            {
                PartMachineLbl.Text = "Company Name:";
            }
        }

        private void InHouseRadio_CheckedChanged(object sender, EventArgs e)
        {

            PartMachineLbl.Text = "Machine ID";
        }

        private void OutsourcedRadio_CheckedChanged(object sender, EventArgs e)
        {

            PartMachineLbl.Text = "Company Name";
        }

        private void AddPartForm_Load(object sender, EventArgs e)
        {
            checkRadioBtn();
        }

    }
}
    
