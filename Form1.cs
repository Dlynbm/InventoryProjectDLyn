﻿using System;
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

        public Form1()
        {
            InitializeComponent();
            idxSelectedPart = -1;

            DataGridParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridParts.RowHeadersVisible = false;        

            //make grid readonly
            DataGridParts.ReadOnly = true;

            DataGridParts.AllowUserToAddRows = true;
            //sets the data source
            DataGridParts.DataSource = Inventory.PartStockPile;

        }

        private void ModifyPartBtn_Click(object sender, EventArgs e)
        {
            if (idxSelectedPart >= 0)
            {
                this.Hide();
                ModifyPartForm f2 = new ModifyPartForm();
                f2.Show();
            }
            else
            {
                MessageBox.Show("Please make a selection");
            }
        }


        private void myBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //clears the top row from not being highlighted
            DataGridParts.ClearSelection();
        }

        private void DataGridParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //idxSelectedPart = e.RowIndex;
                idxSelectedPart = DataGridParts.CurrentCell.RowIndex;
                Inventory.CurrentPartID = (int)DataGridParts.Rows[idxSelectedPart].Cells[0].Value;
                Inventory.CurrentPart = Inventory.lookupPart(Inventory.CurrentPartID);
                DataGridParts.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Blue;
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

    }
}


//    private void DeleteBtn_Click(object sender, EventArgs e)
//    {
//        //if (DataGridParts.CurrentRow == null || !DataGridParts.CurrentRow.Selected)
//        //{
//        //    MessageBox.Show("Nothing is selected.  Please make a selection");
//        //    return;
//        //}
//        //Part P = DataGridParts.CurrentRow.DataBoundItem as Part;
//        //var chosenPart = DataGridParts.CurrentCell.Value;

//        //DialogResult result = MessageBox.Show(" Are you sure you want to delete PartId " + chosenPart, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

//        //if (result == DialogResult.Yes)
//        //{
//        Inventory.PartStockPile.Remove(P);
//    }

//    }
//}


    

        
    

