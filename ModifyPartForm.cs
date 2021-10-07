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
    public partial class ModifyPartForm : Form
    {
        private bool isInHouse;

        private bool allowSave()
        {
            int number;
            decimal d;
            return (!string.IsNullOrWhiteSpace(ModifyNameTxtBox.Text))

                && (!string.IsNullOrWhiteSpace(ModifyInventoryTxtBox.Text))
                && (!Int32.TryParse(ModifyInventoryTxtBox.Text, out number))

                && (!string.IsNullOrWhiteSpace(PriceCostTextBox.Text))
                && (!Decimal.TryParse(PriceCostTextBox.Text, out d))

                && (!string.IsNullOrWhiteSpace(MaxTxtBox.Text))
                && (!Int32.TryParse(MaxTxtBox.Text, out number))

                && (!string.IsNullOrWhiteSpace(MinTxtBox.Text))
                && (!Int32.TryParse(MinTxtBox.Text, out number))

            && (!(string.IsNullOrWhiteSpace(MachineCoNameTxtBox.Text))
            && (isInHouse && !Int32.TryParse(MachineCoNameTxtBox.Text, out number)));
        }

        private void ModifyPartForm_Load(object sender, EventArgs e)
        {
            checkRadioBtn();
        }

        private void checkOnRBSwitch()
        {
            if (InHouseRadioBtn.Checked)
            {
                int number;
                if (string.IsNullOrWhiteSpace(MachineCoNameTxtBox.Text) || (!Int32.TryParse(MachineCoNameTxtBox.Text, out number)))
                {
                    MachineCoNameTxtBox.BackColor = System.Drawing.Color.Yellow;
                    //MessageBox.Show("Must be a number.");
                    ModifySaveBtn.Enabled = false;
                }
                else
                {
                    MachineCoNameTxtBox.BackColor = System.Drawing.Color.White;
                    ModifySaveBtn.Enabled = true;
                }
            }
            else if (OutsourcedRadioBtn.Checked)
            {
                int number;
                if (Int32.TryParse(MachineCoNameTxtBox.Text, out number) || (string.IsNullOrWhiteSpace(MachineCoNameTxtBox.Text)))
                {
                    MachineCoNameTxtBox.BackColor = System.Drawing.Color.Yellow;
                    //MessageBox.Show("Must be a valid name, not a number");
                    ModifySaveBtn.Enabled = false;
                }
                else
                {
                    MachineCoNameTxtBox.BackColor = System.Drawing.Color.White;
                    ModifySaveBtn.Enabled = true;
                }

            }
        }


        //constructor, this sets the form with the current part being displayed
        public ModifyPartForm()
        {
            InitializeComponent();
            ModifyPartIdTxtBox.Text = Inventory.CurrentPart.PartID.ToString();
            ModifyNameTxtBox.Text = Inventory.CurrentPart.Name;
            ModifyInventoryTxtBox.Text = Inventory.CurrentPart.InStock.ToString();
            PriceCostTextBox.Text = Inventory.CurrentPart.Price.ToString();
            MaxTxtBox.Text = Inventory.CurrentPart.Max.ToString();
            MinTxtBox.Text = Inventory.CurrentPart.Min.ToString();

            if (Inventory.CurrentPart is InHouse)
            {
                //creates a part time object e
                InHouse e = (InHouse)Inventory.CurrentPart;
                MachineIdLabel.Text = e.MachineID.ToString();
                MachineCoNameTxtBox.Text = e.MachineID.ToString();
                isInHouse = true;
                InHouseRadioBtn.Checked = true;
            }
            else
            {
                Outsourced e = (Outsourced)Inventory.CurrentPart;
                MachineIdLabel.Text = e.CompanyName;
                MachineCoNameTxtBox.Text = e.CompanyName;
                isInHouse = false;
                OutsourcedRadioBtn.Checked = true;
            }
        }

        private void checkRadioBtn()
        {
            if (InHouseRadioBtn.Checked)
            {
                MachineIdLabel.Text = "Machine Id:";
            }
            else
            {
                MachineIdLabel.Text = "Company Name:";
            }
        }

        private void MachineCoNameTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (InHouseRadioBtn.Checked)
            {
                int number;
                if (string.IsNullOrWhiteSpace(MachineCoNameTxtBox.Text) || (!Int32.TryParse(MachineCoNameTxtBox.Text, out number)))
                {
                    MachineCoNameTxtBox.BackColor = System.Drawing.Color.Yellow;
                    MessageBox.Show("Must be a number.");
                    ModifySaveBtn.Enabled = false;
                }
                else
                {
                    MachineCoNameTxtBox.BackColor = System.Drawing.Color.White;
                    ModifySaveBtn.Enabled = true;
                }
            }
            else if (OutsourcedRadioBtn.Checked)
            {
                int number;
                if (Int32.TryParse(MachineCoNameTxtBox.Text, out number) || (string.IsNullOrWhiteSpace(MachineCoNameTxtBox.Text)))
                {
                    MachineCoNameTxtBox.BackColor = System.Drawing.Color.Yellow;
                    MessageBox.Show("Must be a valid name, not a number");
                    ModifySaveBtn.Enabled = false;
                }
                else
                {
                    MachineCoNameTxtBox.BackColor = System.Drawing.Color.White;
                    ModifySaveBtn.Enabled = true;
                }

            }
        }


    private void ModifySaveBtn_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(MaxTxtBox.Text) < Convert.ToInt32(MinTxtBox.Text))
            {
                MessageBox.Show("Min cannot be greater than max");
                return;
            }

            if (Convert.ToInt32(ModifyInventoryTxtBox.Text) < Convert.ToInt32(MinTxtBox.Text) || Convert.ToInt32(ModifyInventoryTxtBox.Text) > Convert.ToInt32(MaxTxtBox.Text))
            {
                MessageBox.Show("Inventory cannot be less than the min or greater than the max");
                return;
            }

            if (InHouseRadioBtn.Checked)

            {
                bool success = Int64.TryParse(MachineCoNameTxtBox.Text, out long number);
                if (!success)
                {
                    MachineCoNameTxtBox.BackColor = System.Drawing.Color.Yellow;
                    MessageBox.Show("Please enter only a number");
                    ModifySaveBtn.Enabled = false;

                }
                InHouse inHouse = new InHouse((Inventory.PartStockPile.Count + 1), 
                ModifyNameTxtBox.Text,
                Convert.ToInt32(ModifyInventoryTxtBox.Text),
                Convert.ToDecimal(PriceCostTextBox.Text),
                Convert.ToInt32(MaxTxtBox.Text), Convert.ToInt32(MinTxtBox.Text),
                Convert.ToInt32(MachineCoNameTxtBox.Text));
                Inventory.swap(inHouse);
                isInHouse = true;
            }
            else 
            {
                Outsourced outsourced = new Outsourced((Inventory.PartStockPile.Count + 1), 
                ModifyNameTxtBox.Text,
                Convert.ToInt32(ModifyInventoryTxtBox.Text),
                Convert.ToDecimal(PriceCostTextBox.Text),
                Convert.ToInt32(MaxTxtBox.Text), Convert.ToInt32(MinTxtBox.Text),
                (MachineCoNameTxtBox.Text));
                Inventory.swap(outsourced);
                isInHouse = false;
            }
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void InHouseRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Inhouse");
            MachineIdLabel.Text = "Machine ID";
            isInHouse = true;
            checkOnRBSwitch();
        }


        private void OutsourcedRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            MachineIdLabel.Text = "Company Name";
            isInHouse = false;
            checkOnRBSwitch();

        }




        private void ModifyCancelBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void ModifyNameTxtBox_TextChanged_1(object sender, EventArgs e)
        {
            {
                int number;
                if (Int32.TryParse(ModifyNameTxtBox.Text, out number) || (string.IsNullOrWhiteSpace(ModifyNameTxtBox.Text)))
                {
                    ModifyNameTxtBox.BackColor = System.Drawing.Color.Yellow;
                    //MessageBox.Show("Must be a valid name, not a number");
                    ModifySaveBtn.Enabled = false;
                }
                else
                {
                    ModifyNameTxtBox.BackColor = System.Drawing.Color.White;
                    ModifySaveBtn.Enabled = true;
                }
            }
        }


        private void ModifyInventoryTxtBox_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (string.IsNullOrWhiteSpace(ModifyInventoryTxtBox.Text) || (!Int32.TryParse(ModifyInventoryTxtBox.Text, out number)))
            {
                ModifyInventoryTxtBox.BackColor = System.Drawing.Color.Yellow;
                //MessageBox.Show("Must be a number.");
                ModifySaveBtn.Enabled = false;
            }
            else
            {
                ModifyInventoryTxtBox.BackColor = System.Drawing.Color.White;
                ModifySaveBtn.Enabled = true;
            }
        }

        private void PriceCostTextBox_TextChanged(object sender, EventArgs e)
        {
            //decimal d;
            if (string.IsNullOrWhiteSpace(PriceCostTextBox.Text) || (!decimal.TryParse(PriceCostTextBox.Text, out var outParse)))
            {
                PriceCostTextBox.BackColor = System.Drawing.Color.Yellow;
                //MessageBox.Show("Must be a decimal.");
                ModifySaveBtn.Enabled = false;
            }
            else
            {
                PriceCostTextBox.BackColor = System.Drawing.Color.White;
                ModifySaveBtn.Enabled = true;
            }
            

        }

        private void MaxTxtBox_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (string.IsNullOrWhiteSpace(MaxTxtBox.Text) || (!Int32.TryParse(MaxTxtBox.Text, out number)))
            {
                MaxTxtBox.BackColor = System.Drawing.Color.Yellow;
                //MessageBox.Show("Must be a number.");
                ModifySaveBtn.Enabled = false;
            }
            else
            {
                MaxTxtBox.BackColor = System.Drawing.Color.White;
                ModifySaveBtn.Enabled = true;
            }
        }

        private void MinTxtBox_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (string.IsNullOrWhiteSpace(MinTxtBox.Text) || (!Int32.TryParse(MinTxtBox.Text, out number)))
            {
                MinTxtBox.BackColor = System.Drawing.Color.Yellow;
                //MessageBox.Show("Must be a number.");
                ModifySaveBtn.Enabled = false;
            }
            else
            {
                MinTxtBox.BackColor = System.Drawing.Color.White;
                ModifySaveBtn.Enabled = true;
            }
            

        }



        

        


        

    }
}




    
