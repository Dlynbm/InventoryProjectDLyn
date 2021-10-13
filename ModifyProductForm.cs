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
    public partial class ModifyProductForm : Form
    {
        private BindingList<Part> associatedParts = new BindingList<Part>();

        private bool allowSave()
        {
            int number;
            decimal d;
            if (string.IsNullOrWhiteSpace(ModifyProductNameTxtBox.Text)) return false;

            if (string.IsNullOrWhiteSpace(ModifyProductInventoryTxtBox.Text)) return false;
            if (!Int32.TryParse(ModifyProductInventoryTxtBox.Text, out number)) return false;

            if (string.IsNullOrWhiteSpace(ModifyProductPriceTxtBox.Text)) return false;
            if (!Decimal.TryParse(ModifyProductPriceTxtBox.Text, out d)) return false;

            if (string.IsNullOrWhiteSpace(ModifyProductMaxTextBox.Text)) return false;
            if (!Int32.TryParse(ModifyProductMaxTextBox.Text, out number)) return false;

            if (string.IsNullOrWhiteSpace(ModifyProductMinTxtBox.Text)) return false;
            if (!Int32.TryParse(ModifyProductMinTxtBox.Text, out number)) return false;

            return true;
        }
        public ModifyProductForm()
        {
            InitializeComponent();
            ModifyProductIdTxtBx.Text = Inventory.CurrentProduct.ProductID.ToString();
            ModifyProductNameTxtBox.Text = Inventory.CurrentProduct.Name;
            ModifyProductInventoryTxtBox.Text = Inventory.CurrentProduct.InStock.ToString();
            ModifyProductPriceTxtBox.Text = Inventory.CurrentProduct.Price.ToString();
            ModifyProductMaxTextBox.Text = Inventory.CurrentProduct.Max.ToString();
            ModifyProductMinTxtBox.Text = Inventory.CurrentProduct.Min.ToString();

            dataGridView1.DataSource = Inventory.PartStockPile;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.DefaultCellStyle.SelectionBackColor = dataGridView1.DefaultCellStyle.BackColor;
            dataGridView1.DefaultCellStyle.SelectionBackColor = dataGridView1.DefaultCellStyle.ForeColor;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.DefaultCellStyle.SelectionBackColor = dataGridView2.DefaultCellStyle.BackColor;
            dataGridView2.DefaultCellStyle.SelectionForeColor = dataGridView2.DefaultCellStyle.ForeColor;

            dataGridView1.RowHeadersVisible = false;
            dataGridView2.RowHeadersVisible = false;

            //make grid readonly
            dataGridView1.ReadOnly = true;
            dataGridView2.ReadOnly = true;


        }

        private void ModifyProductCancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Inventory.CurrentIndexUpper = e.RowIndex;
                dataGridView1.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.AliceBlue;
                dataGridView2.DataSource = associatedParts;
            }
        }

        private void ModifyProductNameTxtBox_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (Int32.TryParse(ModifyProductNameTxtBox.Text, out number) || (string.IsNullOrWhiteSpace(ModifyProductNameTxtBox.Text)))
            {
                ModifyProductNameTxtBox.BackColor = System.Drawing.Color.Yellow;
            }
            else
            {
                ModifyProductNameTxtBox.BackColor = System.Drawing.Color.White;
            }
            ModifyProductSaveBtn.Enabled = allowSave();
        }

        private void ModifyProductInventoryTxtBox_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (string.IsNullOrWhiteSpace(ModifyProductInventoryTxtBox.Text) || (!Int32.TryParse(ModifyProductInventoryTxtBox.Text, out number)))
            {
                ModifyProductInventoryTxtBox.BackColor = System.Drawing.Color.Yellow;
            }
            else
            {
                ModifyProductInventoryTxtBox.BackColor = System.Drawing.Color.White;
            }

            ModifyProductSaveBtn.Enabled = allowSave();
        }

        private void ModifyProductPriceTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ModifyProductPriceTxtBox.Text) || (!Decimal.TryParse(ModifyProductPriceTxtBox.Text, out var outParse)))
            {
                ModifyProductPriceTxtBox.BackColor = System.Drawing.Color.Yellow;
            }
            else
            {
                ModifyProductPriceTxtBox.BackColor = System.Drawing.Color.White;
            }
            ModifyProductSaveBtn.Enabled = allowSave();
        }

        private void ModifyProductMaxTextBox_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (string.IsNullOrWhiteSpace(ModifyProductMaxTextBox.Text) || (!Int32.TryParse(ModifyProductMaxTextBox.Text, out number)))
            {
                ModifyProductMaxTextBox.BackColor = System.Drawing.Color.Yellow;
            }

            else
            {
                ModifyProductMaxTextBox.BackColor = System.Drawing.Color.White;
            }
            ModifyProductSaveBtn.Enabled = allowSave();
        }

        private void ModifyProductMinTxtBox_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (string.IsNullOrWhiteSpace(ModifyProductMinTxtBox.Text) || (!Int32.TryParse(ModifyProductMinTxtBox.Text, out number)))
            {
                ModifyProductMinTxtBox.BackColor = System.Drawing.Color.Yellow;
            }
            else
            {
                ModifyProductMinTxtBox.BackColor = System.Drawing.Color.White;
            }
            ModifyProductSaveBtn.Enabled = allowSave();
        }

        private void ModifyProductAddBtn_Click(object sender, EventArgs e)
        {
            {
                Part associatedParts = (Part)dataGridView1.CurrentRow.DataBoundItem;


                //get selected row(row that was highlighted when add was clicked)

                //lookup the part

                //call the add part method to add it to associated list

                if (dataGridView1.SelectedRows.Count > 0)

                {

                    int partId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    Part selectedPart = Inventory.lookupPart(partId);
                    associatedParts.Add(selectedPart);
                }
                else
                {
                    MessageBox.Show("Please select a part to add");
                }

                dataGridView2.Rows[0].Selected = false;
            }

            //private void ModifyProductSaveBtn_Click(object sender, EventArgs e)
            //{
            //    if (Convert.ToInt32(ModifyProductMaxTextBox.Text) < Convert.ToInt32(ModifyProductMinTxtBox.Text))
            //    {
            //        MessageBox.Show("Minimum cannot be more than maximum.");
            //        return;
            //    }

            //    if (Convert.ToInt32(ModifyProductInventoryTxtBox.Text) < Convert.ToInt32(ModifyProductMinTxtBox.Text) || Convert.ToInt32(ModifyProductInventoryTxtBox.Text) > Convert.ToInt32(ModifyProductMinTxtBox.Text))
            //    {
            //        MessageBox.Show("Inventory cannot be less than min or greater than the maximum");
            //        return;
            //    }

            //    Inventory.ProductStockPile = new Product(Convert.ToInt32(ModifyProductIdTxtBx.Text),
            //     ModifyProductNameTxtBox.Text,
            //     Convert.ToInt32(ModifyProductInventoryTxtBox.Text),
            //     Convert.ToDecimal(ModifyProductPriceTxtBox.Text),
            //     Convert.ToInt32(ModifyProductMaxTextBox.Text),
            //     Convert.ToInt32(ModifyProductMinTxtBox.Text)



            //    }
            //    this.Hide();
            //    ModifyProductForm f1 = new ModifyProductForm();
            //    f1.Show();
            //}





            //Inventory.ProductStockPile = new Product((Inventory.ProductStockPile.Count + 1),

        }

    }
}


    
