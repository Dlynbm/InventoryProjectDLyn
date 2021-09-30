
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
            ((System.ComponentModel.ISupportInitialize)(this.DataGridParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridParts
            // 
            this.DataGridParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridParts.Location = new System.Drawing.Point(5, 80);
            this.DataGridParts.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.DataGridParts.MultiSelect = false;
            this.DataGridParts.Name = "DataGridParts";
            this.DataGridParts.RowHeadersWidth = 102;
            this.DataGridParts.RowTemplate.Height = 40;
            this.DataGridParts.Size = new System.Drawing.Size(557, 315);
            this.DataGridParts.TabIndex = 0;
            this.DataGridParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridParts_CellClick);
            this.DataGridParts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.myBindingComplete);
            // 
            // DataGridProducts
            // 
            this.DataGridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridProducts.Location = new System.Drawing.Point(589, 76);
            this.DataGridProducts.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.DataGridProducts.MultiSelect = false;
            this.DataGridProducts.Name = "DataGridProducts";
            this.DataGridProducts.RowHeadersWidth = 102;
            this.DataGridProducts.RowTemplate.Height = 40;
            this.DataGridProducts.Size = new System.Drawing.Size(592, 319);
            this.DataGridProducts.TabIndex = 1;
            // 
            // AddPartBtn
            // 
            this.AddPartBtn.Location = new System.Drawing.Point(36, 423);
            this.AddPartBtn.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.AddPartBtn.Name = "AddPartBtn";
            this.AddPartBtn.Size = new System.Drawing.Size(109, 48);
            this.AddPartBtn.TabIndex = 3;
            this.AddPartBtn.Text = "Add Part";
            this.AddPartBtn.UseVisualStyleBackColor = true;
            this.AddPartBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ModifyPartBtn
            // 
            this.ModifyPartBtn.Location = new System.Drawing.Point(168, 423);
            this.ModifyPartBtn.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ModifyPartBtn.Name = "ModifyPartBtn";
            this.ModifyPartBtn.Size = new System.Drawing.Size(129, 49);
            this.ModifyPartBtn.TabIndex = 4;
            this.ModifyPartBtn.Text = "Modify Part";
            this.ModifyPartBtn.UseVisualStyleBackColor = true;
            this.ModifyPartBtn.Click += new System.EventHandler(this.ModifyPartBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(320, 423);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(121, 49);
            this.DeleteBtn.TabIndex = 5;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(1044, 423);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(112, 44);
            this.ExitBtn.TabIndex = 6;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Inventory Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Parts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(651, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Products";
            // 
            // SearchPartBtn
            // 
            this.SearchPartBtn.Location = new System.Drawing.Point(295, 42);
            this.SearchPartBtn.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.SearchPartBtn.Name = "SearchPartBtn";
            this.SearchPartBtn.Size = new System.Drawing.Size(91, 30);
            this.SearchPartBtn.TabIndex = 10;
            this.SearchPartBtn.Text = "Search";
            this.SearchPartBtn.UseVisualStyleBackColor = true;
            this.SearchPartBtn.Click += new System.EventHandler(this.SearchPartBtn_Click);
            // 
            // ProductSearchBtn
            // 
            this.ProductSearchBtn.Location = new System.Drawing.Point(911, 42);
            this.ProductSearchBtn.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ProductSearchBtn.Name = "ProductSearchBtn";
            this.ProductSearchBtn.Size = new System.Drawing.Size(104, 28);
            this.ProductSearchBtn.TabIndex = 11;
            this.ProductSearchBtn.Text = "Search";
            this.ProductSearchBtn.UseVisualStyleBackColor = true;
            // 
            // PartSearchTxtBox
            // 
            this.PartSearchTxtBox.Location = new System.Drawing.Point(400, 48);
            this.PartSearchTxtBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.PartSearchTxtBox.Name = "PartSearchTxtBox";
            this.PartSearchTxtBox.Size = new System.Drawing.Size(123, 22);
            this.PartSearchTxtBox.TabIndex = 12;
            // 
            // ProductSearchTxtBx
            // 
            this.ProductSearchTxtBx.Location = new System.Drawing.Point(1027, 49);
            this.ProductSearchTxtBx.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ProductSearchTxtBx.Name = "ProductSearchTxtBx";
            this.ProductSearchTxtBx.Size = new System.Drawing.Size(131, 22);
            this.ProductSearchTxtBx.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 588);
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
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
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
    }
}

