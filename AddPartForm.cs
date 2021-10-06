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
        //private bool isInHouse;

        private bool allowSave()
        {
            int number;
            double d;
            return (!string.IsNullOrWhiteSpace(AddPartNameTxtBx.Text)) &&

                (!string.IsNullOrWhiteSpace(SavePartInventoryTxtBx.Text)) &&
                (!Int32.TryParse(SavePartInventoryTxtBx.Text, out number)) &&

                (!string.IsNullOrWhiteSpace(AddPartPriceTxtBx.Text)) &&
                (!Double.TryParse(AddPartPriceTxtBx.Text, out d) &&

               (!string.IsNullOrWhiteSpace(AddPartMinTxtBx.Text)) &&
               (!Int32.TryParse(AddPartMinTxtBx.Text, out number)) &&

               (!string.IsNullOrWhiteSpace(AddPartMaxTxtBx.Text)) &&
               (!Int32.TryParse(AddPartMaxTxtBx.Text, out number)) &&

               (!(string.IsNullOrWhiteSpace(AddPartMachineCoTxtBx.Text)) &&
               (InHouseRadio.Checked && !Int32.TryParse(AddPartMachineCoTxtBx.Text, out number))));
        }

        private void checkRadioBtn()
        {
            int number;
            if (InHouseRadio.Checked)
            {
                if (string.IsNullOrWhiteSpace(AddPartMachineCoTxtBx.Text) && (InHouseRadio.Checked && !Int32.TryParse(AddPartMachineCoTxtBx.Text, out number)))
                    AddPartMachineCoTxtBx.BackColor = System.Drawing.Color.Yellow;
                PartSaveBtn.Enabled = false;
            }
            else
            {
                AddPartMachineCoTxtBx.BackColor = System.Drawing.Color.White;
                PartSaveBtn.Enabled = true;
            }
            {
                if (OutsourcedRadio.Checked)
            { 
                    if (string.IsNullOrWhiteSpace(AddPartMachineCoTxtBx.Text) && (Int32.TryParse(AddPartMachineCoTxtBx.Text, out number)))
                                AddPartMachineCoTxtBx.BackColor = System.Drawing.Color.Yellow;
                            PartSaveBtn.Enabled = false;
                        }
                else
                        {
                            AddPartMachineCoTxtBx.BackColor = System.Drawing.Color.White;
                            PartSaveBtn.Enabled = true;
                        }
                    }
            }
        

public AddPartForm()
        {
            InitializeComponent();
            AddPartIdTxtBx.Text = Inventory.PartStockPile.Count.ToString();
            //PartSaveBtn.Enabled = allowSave();
        }

        public static object CurrentRow { get; private set; }
        public object DataGridParts { get; private set; }

        private void AddPartCancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void PartSaveBtn_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(AddPartMaxTxtBx.Text) < Convert.ToInt32(AddPartMinTxtBx.Text))
            {
                MessageBox.Show("Min cannot be more than max");
                return;
            }
            if (Convert.ToInt32(SavePartInventoryTxtBx.Text) < Convert.ToInt32(AddPartMinTxtBx.Text) || Convert.ToInt32(SavePartInventoryTxtBx.Text) > Convert.ToInt32(AddPartMaxTxtBx.Text))

            {
                MessageBox.Show("Inventory cannot be less than the min or more than the max allowed!");
                return;
            }

            if (InHouseRadio.Checked)
            {
                bool success = Int64.TryParse(AddPartMachineCoTxtBx.Text, out long number);
                if(!success)
                {
                    AddPartMachineCoTxtBx.BackColor = System.Drawing.Color.Yellow;
                    MessageBox.Show("Please enter only a number");
                    return;
                }
                Inventory.PartStockPile.Add(new InHouse(AddPartNameTxtBx.Text,
                                                        Convert.ToInt32(SavePartInventoryTxtBx.Text),
                                                        Convert.ToDecimal(AddPartPriceTxtBx.Text),
                                                        Convert.ToInt32(AddPartMinTxtBx.Text),
                                                        Convert.ToInt32(AddPartMaxTxtBx.Text),
                                                        Convert.ToInt32(AddPartMachineCoTxtBx.Text)));
               
                this.Hide();
                Form1 f1 = new Form1();
                f1.Show();
            }
            else 
            {
                Inventory.PartStockPile.Add(new Outsourced(AddPartNameTxtBx.Text,
                                                        Convert.ToInt32(SavePartInventoryTxtBx.Text),
                                                        Convert.ToDecimal(AddPartPriceTxtBx.Text),
                                                        Convert.ToInt32(AddPartMinTxtBx.Text),
                                                        Convert.ToInt32(AddPartMaxTxtBx.Text),
                                                        AddPartMachineCoTxtBx.Text));
                this.Hide(); 
                Form1 f1 = new Form1();
                f1.Show();
            }
        }


            private void InHouseRadio_CheckedChanged(object sender, EventArgs e)
            {

            PartMachineLbl.Text = "Machine ID:";
            
            }

        private void OutsourcedRadio_CheckedChanged(object sender, EventArgs e)
        {
            PartMachineLbl.Text = "Company Name:";
        }

        private void AddPartForm_Load(object sender, EventArgs e)
        {
            checkRadioBtn();
        }

        private void AddPartNameTxtBx_TextChanged(object sender, EventArgs e)
        {
            {
                int number;
                if(Int32.TryParse(AddPartNameTxtBx.Text, out number) || (string.IsNullOrWhiteSpace(AddPartNameTxtBx.Text)))
                {
                    AddPartNameTxtBx.BackColor = System.Drawing.Color.Yellow;
                    MessageBox.Show("Must be a valid name, not a number");
                    PartSaveBtn.Enabled = false;

                }
                else
                {
                    AddPartMachineCoTxtBx.BackColor = System.Drawing.Color.White;
                    PartSaveBtn.Enabled = true;
                }
                //PartSaveBtn.Enabled = allowSave();

            }
        }


        private void SavePartInventoryTxtBx_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (string.IsNullOrWhiteSpace(SavePartInventoryTxtBx.Text) || (!Int32.TryParse(SavePartInventoryTxtBx.Text, out number)))
            {
                SavePartInventoryTxtBx.BackColor = System.Drawing.Color.Yellow;
                MessageBox.Show("Must be a number.");
                PartSaveBtn.Enabled = false;
            }
            else
            {
                SavePartInventoryTxtBx.BackColor = System.Drawing.Color.White;
                PartSaveBtn.Enabled = true;
            }
            //PartSaveBtn.Enabled = allowSave();
        }

        private void AddPartPriceTxtBx_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AddPartPriceTxtBx.Text) || (!decimal.TryParse(AddPartPriceTxtBx.Text, out var outParse)))
            {
                AddPartPriceTxtBx.BackColor = System.Drawing.Color.Yellow;
                MessageBox.Show("Must be a decimal.");
                PartSaveBtn.Enabled = false;
            }
            else
            {
                AddPartPriceTxtBx.BackColor = System.Drawing.Color.White;
                PartSaveBtn.Enabled = true;
            }
            //PartSaveBtn.Enabled = allowSave();
        }

        private void AddPartMaxTxtBx_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (string.IsNullOrWhiteSpace(AddPartMaxTxtBx.Text) || (!Int32.TryParse(AddPartMaxTxtBx.Text, out number)))
            {
                AddPartMaxTxtBx.BackColor = System.Drawing.Color.Yellow;
                MessageBox.Show("Must be a number.");
                PartSaveBtn.Enabled = false;

            }
            else
            {
                AddPartMaxTxtBx.BackColor = System.Drawing.Color.White;
                PartSaveBtn.Enabled = true;
               
            }
            //PartSaveBtn.Enabled = allowSave();
        }

        private void AddPartMinTxtBx_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (string.IsNullOrWhiteSpace(AddPartMinTxtBx.Text) || (!Int32.TryParse(AddPartMinTxtBx.Text, out number)))
            {
                AddPartMinTxtBx.BackColor = System.Drawing.Color.Yellow;
                MessageBox.Show("Must be a number.");
                PartSaveBtn.Enabled = false;
            }
            else
            {
                AddPartMinTxtBx.BackColor = System.Drawing.Color.White;
                PartSaveBtn.Enabled = true;
                
            }
            //PartSaveBtn.Enabled = allowSave();
        }

        private void AddPartMachineCoTxtBx_TextChanged (object sender, EventArgs e)
        {
            checkRadioBtn();
        }

      

    }
    }


    
