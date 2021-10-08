
namespace InventoryProjectDLyn
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DataGridParts = new System.Windows.Forms.DataGridView();
            this.DataGridProducts = new System.Windows.Forms.DataGridView();
            this.AddPartBtn = new System.Windows.Forms.Button();
            this.ModifyPartBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchPartBtn = new System.Windows.Forms.Button();
            this.ProductSearchBtn = new System.Windows.Forms.Button();
            this.PartSearchTxtBox = new System.Windows.Forms.TextBox();
            this.ProductSearchTxtBx = new System.Windows.Forms.TextBox();
            this.ModifyProductBtn = new System.Windows.Forms.Button();
            this.DeleteProductBtn = new System.Windows.Forms.Button();
            this.AddProductBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridParts
            // 
            this.DataGridParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridParts.Location = new System.Drawing.Point(10, 155);
            this.DataGridParts.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridParts.MultiSelect = false;
            this.DataGridParts.Name = "DataGridParts";
            this.DataGridParts.RowHeadersWidth = 102;
            this.DataGridParts.RowTemplate.Height = 40;
            this.DataGridParts.Size = new System.Drawing.Size(1114, 610);
            this.DataGridParts.TabIndex = 0;
            this.DataGridParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridParts_CellClick);
            this.DataGridParts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.myBindingComplete);
            // 
            // DataGridProducts
            // 
            this.DataGridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridProducts.Location = new System.Drawing.Point(1178, 147);
            this.DataGridProducts.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridProducts.MultiSelect = false;
            this.DataGridProducts.Name = "DataGridProducts";
            this.DataGridProducts.RowHeadersWidth = 102;
            this.DataGridProducts.RowTemplate.Height = 40;
            this.DataGridProducts.Size = new System.Drawing.Size(1184, 618);
            this.DataGridProducts.TabIndex = 1;
            this.DataGridProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridProducts_CellClick);
            // 
            // AddPartBtn
            // 
            this.AddPartBtn.Location = new System.Drawing.Point(11, 822);
            this.AddPartBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddPartBtn.Name = "AddPartBtn";
            this.AddPartBtn.Size = new System.Drawing.Size(218, 93);
            this.AddPartBtn.TabIndex = 3;
            this.AddPartBtn.Text = "Add Part";
            this.AddPartBtn.UseVisualStyleBackColor = true;
            this.AddPartBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ModifyPartBtn
            // 
            this.ModifyPartBtn.Location = new System.Drawing.Point(278, 822);
            this.ModifyPartBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ModifyPartBtn.Name = "ModifyPartBtn";
            this.ModifyPartBtn.Size = new System.Drawing.Size(258, 95);
            this.ModifyPartBtn.TabIndex = 4;
            this.ModifyPartBtn.Text = "Modify Part";
            this.ModifyPartBtn.UseVisualStyleBackColor = true;
            this.ModifyPartBtn.Click += new System.EventHandler(this.ModifyPartBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(590, 822);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(242, 95);
            this.DeleteBtn.TabIndex = 5;
            this.DeleteBtn.Text = "Delete Part";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click_1);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(2261, 1025);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(224, 85);
            this.ExitBtn.TabIndex = 6;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Inventory Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Parts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1302, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "Products";
            // 
            // SearchPartBtn
            // 
            this.SearchPartBtn.Location = new System.Drawing.Point(590, 81);
            this.SearchPartBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SearchPartBtn.Name = "SearchPartBtn";
            this.SearchPartBtn.Size = new System.Drawing.Size(182, 58);
            this.SearchPartBtn.TabIndex = 10;
            this.SearchPartBtn.Text = "Search";
            this.SearchPartBtn.UseVisualStyleBackColor = true;
            this.SearchPartBtn.Click += new System.EventHandler(this.SearchPartBtn_Click);
            // 
            // ProductSearchBtn
            // 
            this.ProductSearchBtn.Location = new System.Drawing.Point(1822, 81);
            this.ProductSearchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ProductSearchBtn.Name = "ProductSearchBtn";
            this.ProductSearchBtn.Size = new System.Drawing.Size(208, 54);
            this.ProductSearchBtn.TabIndex = 11;
            this.ProductSearchBtn.Text = "Search";
            this.ProductSearchBtn.UseVisualStyleBackColor = true;
            // 
            // PartSearchTxtBox
            // 
            this.PartSearchTxtBox.Location = new System.Drawing.Point(800, 93);
            this.PartSearchTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.PartSearchTxtBox.Name = "PartSearchTxtBox";
            this.PartSearchTxtBox.Size = new System.Drawing.Size(242, 38);
            this.PartSearchTxtBox.TabIndex = 12;
            // 
            // ProductSearchTxtBx
            // 
            this.ProductSearchTxtBx.Location = new System.Drawing.Point(2054, 95);
            this.ProductSearchTxtBx.Margin = new System.Windows.Forms.Padding(2);
            this.ProductSearchTxtBx.Name = "ProductSearchTxtBx";
            this.ProductSearchTxtBx.Size = new System.Drawing.Size(258, 38);
            this.ProductSearchTxtBx.TabIndex = 13;
            // 
            // ModifyProductBtn
            // 
            this.ModifyProductBtn.Location = new System.Drawing.Point(1849, 821);
            this.ModifyProductBtn.Name = "ModifyProductBtn";
            this.ModifyProductBtn.Size = new System.Drawing.Size(237, 93);
            this.ModifyProductBtn.TabIndex = 15;
            this.ModifyProductBtn.Text = "Modify Product";
            this.ModifyProductBtn.UseVisualStyleBackColor = true;
            this.ModifyProductBtn.Click += new System.EventHandler(this.ModifyProductBtn_Click);
            // 
            // DeleteProductBtn
            // 
            this.DeleteProductBtn.Location = new System.Drawing.Point(2140, 818);
            this.DeleteProductBtn.Name = "DeleteProductBtn";
            this.DeleteProductBtn.Size = new System.Drawing.Size(222, 97);
            this.DeleteProductBtn.TabIndex = 16;
            this.DeleteProductBtn.Text = "Delete Product";
            this.DeleteProductBtn.UseVisualStyleBackColor = true;
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.Location = new System.Drawing.Point(1531, 822);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(239, 95);
            this.AddProductBtn.TabIndex = 17;
            this.AddProductBtn.Text = "Add Product";
            this.AddProductBtn.UseVisualStyleBackColor = true;
            this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2512, 1139);
            this.Controls.Add(this.AddProductBtn);
            this.Controls.Add(this.DeleteProductBtn);
            this.Controls.Add(this.ModifyProductBtn);
            this.Controls.Add(this.ProductSearchTxtBx);
            this.Controls.Add(this.PartSearchTxtBox);
            this.Controls.Add(this.ProductSearchBtn);
            this.Controls.Add(this.SearchPartBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.ModifyPartBtn);
            this.Controls.Add(this.AddPartBtn);
            this.Controls.Add(this.DataGridProducts);
            this.Controls.Add(this.DataGridParts);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridParts;
        private System.Windows.Forms.DataGridView DataGridProducts;
        private System.Windows.Forms.Button AddPartBtn;
        private System.Windows.Forms.Button ModifyPartBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SearchPartBtn;
        private System.Windows.Forms.Button ProductSearchBtn;
        private System.Windows.Forms.TextBox PartSearchTxtBox;
        private System.Windows.Forms.TextBox ProductSearchTxtBx;
        private System.Windows.Forms.Button ModifyProductBtn;
        private System.Windows.Forms.Button DeleteProductBtn;
        private System.Windows.Forms.Button AddProductBtn;
    }
}

