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
    public partial class Form1 : Form
    {
        private int idxSelectedPart;
        private int idxSelectedProduct;

        public Form1()
        {
            InitializeComponent();
            idxSelectedPart = -1;
            idxSelectedProduct = -1;

            //Part Info
            DataGridParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridParts.RowHeadersVisible = false;
            //make grid readonly
            DataGridParts.ReadOnly = true;
            DataGridParts.AllowUserToAddRows = true;
            //sets the data source and sets the PartStockPile list
            DataGridParts.DataSource = Inventory.PartStockPile;


            //Product Info
            //sets the data source and sets the ProductStockPile list
            DataGridProducts.DataSource = Inventory.ProductStockPile;
            //see a full row selection
            DataGridProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //make rows readonly
            DataGridProducts.ReadOnly = true;
            //makes it allow only one row to be selected
            DataGridProducts.MultiSelect = false;
            DataGridProducts.RowHeadersVisible = false;
            DataGridProducts.AllowUserToAddRows = false;
        }


        private void myBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //clears the top row from not being highlighted
            DataGridParts.ClearSelection();
            DataGridProducts.ClearSelection();
        }

        private void DataGridProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                idxSelectedProduct = DataGridProducts.CurrentCell.RowIndex;
                Inventory.CurrentProductID = (int)DataGridProducts.Rows[idxSelectedProduct].Cells[0].Value;
                Inventory.CurrentProduct = Inventory.LookupProduct(Inventory.CurrentProductID);

                DataGridParts.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.CornflowerBlue;

            }
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            AddProductForm f2 = new AddProductForm();
            f2.Show();
        }





        private void ModifyProductBtn_Click(object sender, EventArgs e)
        {
            //checks to see if anything was selected
            if (idxSelectedProduct >= 0)
            {
                ModifyProductForm f2 = new ModifyProductForm();
                f2.Show();
            }
            else
            {
                MessageBox.Show("Nothing selected");
            }
        }

        //Parts Functionality
        //anytime I select a cell this code executes
        private void DataGridParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                idxSelectedPart = DataGridParts.CurrentCell.RowIndex;
                Inventory.CurrentPartID = (int)DataGridParts.Rows[idxSelectedPart].Cells[0].Value;
                Inventory.CurrentPart = Inventory.lookupPart(Inventory.CurrentPartID);
                DataGridParts.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            }
        }

        //shows the current part on the modify form page
        private void ModifyPartBtn_Click(object sender, EventArgs e)
        {
            if (idxSelectedPart >= 0)
            {
                ModifyPartForm f2 = new ModifyPartForm();
                f2.Show();
            }
            else
            {
                MessageBox.Show("Please make a selection");
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            var add = new AddPartForm();
            add.Show();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SearchPartBtn_Click(object sender, EventArgs e)
        {
            DataGridParts.ClearSelection();
            bool found = false;
            if (PartSearchTxtBox.Text != "")
            {
                for (int i = 0; i < Inventory.PartStockPile.Count; i++)
                {
                    if (Inventory.PartStockPile[i].Name.ToUpper().Contains(PartSearchTxtBox.Text.ToUpper()))

                    {
                        DataGridParts.Rows[i].Selected = true;
                        found = true;
                    }
                }
            }
            if (!found)
            {
                MessageBox.Show("Not found");
            }
        }

        private void ProductSearchBtn_Click(object sender, EventArgs e)
        {
            {
                DataGridProducts.ClearSelection();
                bool found = false;
                if (ProductSearchTxtBx.Text != "")
                {
                    for (int i = 0; i < Inventory.ProductStockPile.Count; i++)
                    {
                        if (Inventory.ProductStockPile[i].Name.ToUpper().Contains(ProductSearchTxtBx.Text.ToUpper()))

                        {
                            DataGridProducts.Rows[i].Selected = true;
                            found = true;
                        }
                    }
                }
                if (!found)
                {
                    MessageBox.Show("Not found");
                }
            }

        }


        private void DeleteBtn_Click_1(object sender, EventArgs e)
        {
            {
                if (DataGridParts.CurrentRow == null || !DataGridParts.CurrentRow.Selected)
                {
                    MessageBox.Show("Nothing is selected.  Please make a selection");
                    return;
                }
                Part P = DataGridParts.CurrentRow.DataBoundItem as Part;
                var chosenPart = DataGridParts.CurrentCell.Value;

                DialogResult result = MessageBox.Show(" Are you sure you want to delete PartId " + chosenPart, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    Inventory.PartStockPile.Remove(P);
                }
            }
        }

        private void DeleteProductBtn_Click(object sender, EventArgs e)
        {

            DialogResult productDelete = MessageBox.Show("Are you sure you want to delete this product?", "Confirm", MessageBoxButtons.YesNo);

            if(productDelete == DialogResult.Yes)
            {
                if(Inventory.ProductStockPile.Count > 0)
                {
                    foreach (DataGridViewRow row in DataGridProducts.SelectedRows)
                    {
                        int productId = int.Parse(DataGridProducts.Rows[DataGridProducts.CurrentCell.RowIndex].Cells[0].Value.ToString());
                        Product invalidProduct = Inventory.LookupProduct(productId);
                        if(invalidProduct.associatedPart.Count > 0)
                        {
                            DialogResult message = MessageBox.Show("Sorry, you cannot delete this product because it has one or more associated parts");
                        }
                        else
                        {
                            Inventory.ProductStockPile.Remove(invalidProduct);
                        }
                    }
                }
            }
            
        }

        
    }
}









