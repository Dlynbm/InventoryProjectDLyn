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
            return (!string.IsNullOrWhiteSpace(ModifyNameTxtBox.Text)) &&
                (!(string.IsNullOrWhiteSpace(MachineCoNameTxtBox.Text) || (isInHouse && !Int32.TryParse(MachineCoNameTxtBox.Text, out number))));
        }

        private void checkOnRBSwitch()
        {
            int number;
            if (string.IsNullOrWhiteSpace(MachineCoNameTxtBox.Text) || (isInHouse && !Int32.TryParse(MachineCoNameTxtBox.Text, out number)))
            {
                MachineCoNameTxtBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                MachineCoNameTxtBox.BackColor = System.Drawing.Color.White;
            }
            ModifySaveBtn.Enabled = allowSave();
        }

        public ModifyPartForm()
        {
            InitializeComponent();
            ModifyPartIdTxtBox.Text = Inventory.CurrentPart.PartID.ToString();
            ModifyNameTxtBox.Text = Inventory.CurrentPart.Name;
            
            if (Inventory.CurrentPart is InHouse)
            {
                InHouse e = (InHouse)Inventory.CurrentPart;
                MachineCoNameTxtBox.Text = e.MachineID.ToString();
                isInHouse = true;
                InHouseRadioBtn.Checked = true;
            }
            else
            {
                Outsourced e = (Outsourced)Inventory.CurrentPart;
                MachineCoNameTxtBox.Text = e.CompanyName.ToString();
                isInHouse = false;
                OutsourcedRadioBtn.Checked = true;
            }
        }

        private void ModifyPartForm_Load(object sender, EventArgs e)
        {

        }

        private void ModifySaveBtn_Click(object sender, EventArgs e)
        {
            if(isInHouse)
            {
                Part part = new InHouse(Convert.ToInt32(ModifyPartIdTxtBox.Text), ModifyNameTxtBox.Text, Convert.ToInt32(ModifyInventoryTxtBox.Text), Convert.ToInt32(PriceCostTextBox.Text),
                    Convert.ToInt32(MaxTxtBox.Text), Convert.ToInt32(MinTxtBox.Text), Convert.ToInt32(MachineCoNameTxtBox.Text));
                Inventory.swap(part);
            }
            else
            {
                Part part = new Outsourced(Convert.ToInt32(ModifyPartIdTxtBox.Text), ModifyNameTxtBox.Text, Convert.ToInt32(ModifyInventoryTxtBox.Text), Convert.ToInt32(PriceCostTextBox.Text),
                    Convert.ToInt32(MaxTxtBox.Text), Convert.ToInt32(MinTxtBox.Text), MachineCoNameTxtBox.Text);
                Inventory.swap(part);
            }
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
             }


        private void ModifyCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void InHouseRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            MachineIdLabel.Text = "Machine ID";
            isInHouse = true;
            checkOnRBSwitch();

        }

        private void ModifyNameTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ModifyNameTxtBox.Text))
            {
                ModifyNameTxtBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                ModifyNameTxtBox.BackColor = System.Drawing.Color.White;
            }
            ModifySaveBtn.Enabled = allowSave();
        }

        private void MachineCoNameTxtBox_TextChanged(object sender, EventArgs e)
        {
            checkOnRBSwitch();
        }


        public void OutsourcedRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            MachineIdLabel.Text = "Company Name";
            isInHouse = false;
            //checkOnRBSwitch();
        }
    }
}

    
