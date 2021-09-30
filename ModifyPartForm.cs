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
                && (!Int32.TryParse(ModifyInventoryTxtBox.Text, out number))
                && (!Decimal.TryParse(PriceCostTextBox.Text, out d))
                && (!Int32.TryParse(MaxTxtBox.Text, out number))
                && (!Int32.TryParse(MinTxtBox.Text, out number))
                && (!(string.IsNullOrWhiteSpace(MachineCoNameTxtBox.Text)
                || (isInHouse && !Int32.TryParse(MachineCoNameTxtBox.Text, out number))));
        }

        private void checkOnRBSwitch()
        {
            int number;
            if (string.IsNullOrWhiteSpace(MachineCoNameTxtBox.Text) || (isInHouse && !Int32.TryParse(MachineCoNameTxtBox.Text, out number)))
            {
                MachineCoNameTxtBox.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                MachineCoNameTxtBox.BackColor = System.Drawing.Color.White;
            }
            ModifySaveBtn.Enabled = allowSave();
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
                Outsourced o = (Outsourced)Inventory.CurrentPart;
                MachineIdLabel.Text = o.CompanyName;
                MachineCoNameTxtBox.Text = o.CompanyName;
                isInHouse = false;
                OutsourcedRadioBtn.Checked = true;
            }
        }

        private void MachineCoNameTxtBox_TextChanged(object sender, EventArgs e)
        {
            checkOnRBSwitch();
        }

        //private void ModifyPartForm_Load(object sender, EventArgs e)
        //{
        //    checkRadioBtn();
        //}

        private void ModifySaveBtn_Click(object sender, EventArgs e)
        {

            if (InHouseRadioBtn.Checked)
            {
                InHouse inHouse = new InHouse((Inventory.PartStockPile.Count + 1), ModifyNameTxtBox.Text, Convert.ToInt32(ModifyInventoryTxtBox.Text),
                Convert.ToDecimal(PriceCostTextBox.Text),
                Convert.ToInt32(MaxTxtBox.Text), Convert.ToInt32(MinTxtBox.Text), Convert.ToInt32(MachineCoNameTxtBox.Text));

                if (String.IsNullOrWhiteSpace(ModifyNameTxtBox.Text))
                {
                    MessageBox.Show("Name cannot be empty");
                }

                if (int.Parse(ModifyInventoryTxtBox.Text) > int.Parse(MaxTxtBox.Text))
                {
                    MessageBox.Show("Inventory stock level cannot exceed Max stock level");
                    return;
                }

                if (int.Parse(MinTxtBox.Text) > int.Parse(MaxTxtBox.Text))
                {
                    MessageBox.Show("Minimum stock level cannot exceed max stock level");
                    return;
                }
                else
                {
                    Inventory.swap(inHouse);
                }
            }
            else
            {
                OutsourcedRadioBtn.Checked = true;
                Outsourced outsourced = new Outsourced((Inventory.PartStockPile.Count + 1), ModifyNameTxtBox.Text, Convert.ToInt32(ModifyInventoryTxtBox.Text),
                Convert.ToDecimal(PriceCostTextBox.Text),
                Convert.ToInt32(MaxTxtBox.Text), Convert.ToInt32(MinTxtBox.Text), (MachineCoNameTxtBox.Text));
                if (String.IsNullOrWhiteSpace(ModifyNameTxtBox.Text))
                {
                    MessageBox.Show("Name cannot be empty");
                }

                if (int.Parse(ModifyInventoryTxtBox.Text) > int.Parse(MaxTxtBox.Text))
                {
                    MessageBox.Show("Inventory stock level cannot exceed Max stock level");
                    return;
                }

                if (int.Parse(MinTxtBox.Text) > int.Parse(MaxTxtBox.Text))
                {
                    MessageBox.Show("Minimum stock level cannot exceed max stock level");
                    return;
                }
                else
                {
                    Inventory.swap(outsourced);
                }

            }
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
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

        private void ModifyCancelBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        
        private void InHouseRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Inhouse");
            MachineIdLabel.Text = "Machine ID";
        }

        private void OutsourcedRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            MachineIdLabel.Text = "Company Name";

        }

        private void ModifyNameTxtBox_TextChanged_1(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrWhiteSpace(ModifyNameTxtBox.Text))
                {
                    ModifyNameTxtBox.BackColor = System.Drawing.Color.Yellow;
                }
                else
                {
                    ModifyNameTxtBox.BackColor = System.Drawing.Color.White;
                }
                
            }
        }



        private void ModifyInventoryTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(ModifyInventoryTxtBox.Text, out var outParse))
            {
                ModifyInventoryTxtBox.BackColor = System.Drawing.Color.White;
               
            }
            else
            {
                ModifyInventoryTxtBox.BackColor = System.Drawing.Color.Yellow;
                MessageBox.Show("Must be an int.");
            }
           
        }

        private void PriceCostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(PriceCostTextBox.Text, out var outParse))
            {
                PriceCostTextBox.BackColor = System.Drawing.Color.White;
            }
            else
            {
                PriceCostTextBox.BackColor = System.Drawing.Color.Yellow;
                MessageBox.Show("Must be a decimal");
            }
            
        }

        private void MaxTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(MaxTxtBox.Text,out var outParse))
            {
                MaxTxtBox.BackColor = System.Drawing.Color.White;
            }
            else
            {
                MaxTxtBox.BackColor = System.Drawing.Color.Yellow;
                MessageBox.Show("Must be a number");
            }
            
        }

        private void MinTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(MinTxtBox.Text, out var outParse))
            {
                MinTxtBox.BackColor = System.Drawing.Color.White;
            }
            else
            {
                MinTxtBox.BackColor = System.Drawing.Color.Yellow;
                MessageBox.Show("Must be a number");
            }
            
        }

        //private void MachineCoNameTxtBox_TextChanged_1(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(MachineCoNameTxtBox.Text))
        //    {
        //        MachineCoNameTxtBox.BackColor = System.Drawing.Color.Yellow;
        //    }
        //    else
        //    {
        //        MachineCoNameTxtBox.BackColor = System.Drawing.Color.White;
        //    }

        //}
    }
    }



    
