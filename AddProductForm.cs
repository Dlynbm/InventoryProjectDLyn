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
        public AddProductForm()
        {
            InitializeComponent();
            AddProductSaveBtn.Enabled = false;
            AddProductIDTextBx.Text = Inventory.ProductStockPile.Count.ToString();
            dataGridView1.DataSource = Inventory.PartStockPile;
        }

        public static object CurrentRow { get; set; }
        public object DataGridProducts { get; set; }
        public object DataGridParts { get; private set; }

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

        private void AddProductCancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
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

            Inventory.ProductStockPile.Add(new Product(AddProductNameTextBox.Text,
                Convert.ToInt32(AddProductInventoryTextBox.Text),
                Convert.ToDecimal(AddProductPriceTextBox.Text),
                Convert.ToInt32(AddProductMaxTextBox.Text),
                Convert.ToInt32(AddProductMinTextBox.Text)));
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
            if(string.IsNullOrWhiteSpace(AddProductInventoryTextBox.Text) || (!Int32.TryParse(AddProductInventoryTextBox.Text, out number)))
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
            
            if(string.IsNullOrWhiteSpace(AddProductPriceTextBox.Text) || (!Decimal.TryParse(AddProductPriceTextBox.Text, out var outParse)))
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
            if(string.IsNullOrWhiteSpace(AddProductMaxTextBox.Text)|| (!Int32.TryParse(AddProductMaxTextBox.Text, out number)))
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
            if(string.IsNullOrWhiteSpace(AddProductMinTextBox.Text) || (!Int32.TryParse(AddProductMinTextBox.Text, out number)))
            {
                AddProductMinTextBox.BackColor = System.Drawing.Color.Yellow;
            }
            else
            {
                AddProductMinTextBox.BackColor = System.Drawing.Color.White;
            }
            AddProductSaveBtn.Enabled = allowSave();
        }
    }
}
