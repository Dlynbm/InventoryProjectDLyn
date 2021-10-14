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
        private BindingList<Part> bottomList = new BindingList<Part>();

        public ModifyProductForm()
        {
            InitializeComponent();
            ModifyProductSaveBtn.Enabled = allowSave();

            ModifyProductIdTxtBx.Text = Inventory.CurrentProduct.ProductID.ToString();
            ModifyProductNameTxtBox.Text = Inventory.CurrentProduct.Name;
            ModifyProductInventoryTxtBox.Text = Inventory.CurrentProduct.InStock.ToString();
            ModifyProductPriceTxtBox.Text = Inventory.CurrentProduct.Price.ToString();
            ModifyProductMaxTextBox.Text = Inventory.CurrentProduct.Max.ToString();
            ModifyProductMinTxtBox.Text = Inventory.CurrentProduct.Min.ToString();

           

            
            dataGridView1.DataSource = Inventory.PartStockPile;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;

            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.DataSource = bottomList;

            foreach (Part p in Inventory.CurrentProduct.associatedPart)
            {
                bottomList.Add(p);
            }
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.ReadOnly = true;
   
        }

        private void myBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
        }


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
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    bottomList.Add(associatedParts);
                }
                else
                {
                    MessageBox.Show("Please select a part to add");
                }
            }
        }

        private void ModifyProductSaveBtn_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(ModifyProductMaxTextBox.Text) < Convert.ToInt32(ModifyProductMinTxtBox.Text))
            {
                MessageBox.Show("Minimum cannot be more than maximum."); 
            }

            if (Convert.ToInt32(ModifyProductInventoryTxtBox.Text) < Convert.ToInt32(ModifyProductMinTxtBox.Text) || Convert.ToInt32(ModifyProductInventoryTxtBox.Text) > Convert.ToInt32(ModifyProductMaxTextBox.Text))
            {
                MessageBox.Show("Inventory cannot be less than min or greater than the maximum");
                return;
            }

             Product product = new Product(Convert.ToInt32(ModifyProductIdTxtBx.Text), ModifyProductNameTxtBox.Text,
             Convert.ToInt32(ModifyProductInventoryTxtBox.Text),
             Convert.ToDecimal(ModifyProductPriceTxtBox.Text),
             Convert.ToInt32(ModifyProductMaxTextBox.Text),
             Convert.ToInt32(ModifyProductMinTxtBox.Text));
            //not adding parts to a product
            foreach (Part p in bottomList)
            {
                product.associatedPart.Add(p);
            }
            Inventory.update(product);

            ModifyProductSaveBtn.Enabled = allowSave();
            this.Hide();
            Form1 f1 = new Form1();
             f1.Show();
        }
  

        private void ModifyProductSearchBtn_Click(object sender, EventArgs e)
        {
            {
                dataGridView1.ClearSelection();
                bool found = false;
                if(ModifyProductSearchTxtBox.Text !="")
                {
                    for (int i = 0; i < Inventory.PartStockPile.Count; i++)
                    {
                        if(Inventory.PartStockPile[i].Name.ToUpper().Contains(ModifyProductSearchTxtBox.Text.ToUpper()))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            found = true;
                        }
                    }
                }
                if(!found)
                {
                    MessageBox.Show("Nothing found");
                }
            }
        }

        private void ModifyProductDeleteBtn_Click(object sender, EventArgs e)
        {
            if(dataGridView2.CurrentRow == null || !dataGridView2.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing is selected.  Please make a selection");
                return;
            }
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                bottomList.RemoveAt(row.Index);
            }
        }
    }
}


    
