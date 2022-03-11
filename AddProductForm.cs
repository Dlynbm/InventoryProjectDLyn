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
    public partial class AddProductForm : Form
    {
        private BindingList<Part> bottomList = new BindingList<Part>();

        public AddProductForm()
        {
            InitializeComponent();
            AddProductSaveBtn.Enabled = allowSave();

            AddProductIDTextBx.Text = Inventory.ProductStockPile.Count.ToString();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = Inventory.PartStockPile;

            dataGridView2.DataSource = bottomList;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.RowHeadersVisible = false;

            //make grid readonly
            dataGridView2.ReadOnly = true;
        }

        public static object CurrentRow { get; set; }
        public object DataGridProducts { get; set; }
        public object DataGridParts { get; private set; }

        private void myBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //clears the top row from not being highlighted
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
        }





        private bool allowSave()
        {
            int number;
            double d;
            if (string.IsNullOrWhiteSpace(AddProductNameTextBox.Text)) return false;

            if (string.IsNullOrWhiteSpace(AddProductInventoryTextBox.Text)) return false;
            if (!Int32.TryParse(AddProductInventoryTextBox.Text, out number)) return false;

            if (string.IsNullOrWhiteSpace(AddProductPriceTextBox.Text)) return false;
            if (!Double.TryParse(AddProductPriceTextBox.Text, out d)) return false;

            if (string.IsNullOrWhiteSpace(AddProductMaxTextBox.Text)) return false;
            if (!Int32.TryParse(AddProductMaxTextBox.Text, out number)) return false;

            if (string.IsNullOrWhiteSpace(AddProductMinTextBox.Text)) return false;
            if (!Int32.TryParse(AddProductMinTextBox.Text, out number)) return false;

            return true;
        }



        

        private void AddProductSaveBtn_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(AddProductMaxTextBox.Text) < Convert.ToInt32(AddProductMinTextBox.Text))
            {
                MessageBox.Show("Minimum cannot be more than the maximum");
            }
            if (Convert.ToInt32(AddProductInventoryTextBox.Text) < Convert.ToInt32(AddProductMinTextBox.Text) || Convert.ToInt32(AddProductInventoryTextBox.Text) > Convert.ToInt32(AddProductMaxTextBox.Text))

            {
                MessageBox.Show("Inventory cannot be less than the minimum or more than the maximum allowed");
                return;
            }

            if (dataGridView2.Rows.Count == 0)
            {
                MessageBox.Show("Must have atleast one associated part");
                return;
            }
            else
            {
                Product product = new Product(AddProductNameTextBox.Text,
                    Convert.ToInt32(AddProductInventoryTextBox.Text),
                    Convert.ToDecimal(AddProductPriceTextBox.Text),
                    Convert.ToInt32(AddProductMaxTextBox.Text),
                    Convert.ToInt32(AddProductMinTextBox.Text));
                foreach (Part p in bottomList)
                {
                    product.associatedPart.Add(p);
                }
                Inventory.ProductStockPile.Add(product);
            }

            AddProductSaveBtn.Enabled = allowSave();

            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();

        }



        private void AddProductNameTextBox_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (Int32.TryParse(AddProductNameTextBox.Text, out number) || (string.IsNullOrWhiteSpace(AddProductNameTextBox.Text)))
            {
                AddProductNameTextBox.BackColor = System.Drawing.Color.Yellow;
            }
            else
            {
                AddProductNameTextBox.BackColor = System.Drawing.Color.White;
            }
            AddProductSaveBtn.Enabled = allowSave();
        }

        private void AddProductInventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (string.IsNullOrWhiteSpace(AddProductInventoryTextBox.Text) || (!Int32.TryParse(AddProductInventoryTextBox.Text, out number)))
            {
                AddProductInventoryTextBox.BackColor = System.Drawing.Color.Yellow;
            }
            else
            {
                AddProductInventoryTextBox.BackColor = System.Drawing.Color.White;
            }
            AddProductSaveBtn.Enabled = allowSave();
        }

        private void AddProductPriceTextBox_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(AddProductPriceTextBox.Text) || (!Decimal.TryParse(AddProductPriceTextBox.Text, out var outParse)))
            {
                AddProductPriceTextBox.BackColor = System.Drawing.Color.Yellow;
            }
            else
            {
                AddProductPriceTextBox.BackColor = System.Drawing.Color.White;
            }
            AddProductSaveBtn.Enabled = allowSave();
        }

        private void AddProductMaxTextBox_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (string.IsNullOrWhiteSpace(AddProductMaxTextBox.Text) || (!Int32.TryParse(AddProductMaxTextBox.Text, out number)))
            {
                AddProductMaxTextBox.BackColor = System.Drawing.Color.Yellow;
            }
            else
            {
                AddProductMaxTextBox.BackColor = System.Drawing.Color.White;
            }
            AddProductSaveBtn.Enabled = allowSave();
        }

        private void AddProductMinTextBox_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (string.IsNullOrWhiteSpace(AddProductMinTextBox.Text) || (!Int32.TryParse(AddProductMinTextBox.Text, out number)))
            {
                AddProductMinTextBox.BackColor = System.Drawing.Color.Yellow;
            }
            else
            {
                AddProductMinTextBox.BackColor = System.Drawing.Color.White;
            }
            AddProductSaveBtn.Enabled = allowSave();
        }

        private void AddProductSearchBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            bool found = false;
            if (ProductSearchTxtBox.Text != "")
            {
                for (int i = 0; i < Inventory.PartStockPile.Count; i++)
                {
                    if (Inventory.PartStockPile[i].Name.ToUpper().Contains(ProductSearchTxtBox.Text.ToUpper()))
                    {
                        dataGridView1.Rows[i].Selected = true;
                        found = true;
                    }
                }
            }
            if (!found)
            {
                MessageBox.Show("Nothing found");
            }
        }

        private void AddProductAddBtn_Click(object sender, EventArgs e)
        {
            Part associatedParts = (Part)dataGridView1.CurrentRow.DataBoundItem;
            bottomList.Add(associatedParts);

        }

        private void AddProductDeleteBtn_Click(object sender, EventArgs e)
        {
            if(bottomList.Count == 0)
            {
                return;
            }
            DialogResult associatedPartDelete = MessageBox.Show("Are you sure you want to delete this part?", "Confirm", MessageBoxButtons.YesNo);

            if (associatedPartDelete == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                {
                    bottomList.RemoveAt(row.Index);
                }
            }
        }

        private void AddProductCancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
        

        
    }
