
namespace InventoryProjectDLyn
{
    partial class AddProductForm
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
            this.AddProductLbl = new System.Windows.Forms.Label();
            this.AddProductIdLabel = new System.Windows.Forms.Label();
            this.AddProductNameLabel = new System.Windows.Forms.Label();
            this.AddProductInventoryLabel = new System.Windows.Forms.Label();
            this.AddProductPriceLabel = new System.Windows.Forms.Label();
            this.AddProductMaxLabel = new System.Windows.Forms.Label();
            this.AddProductIDTextBx = new System.Windows.Forms.TextBox();
            this.AddProductNameTextBox = new System.Windows.Forms.TextBox();
            this.AddProductInventoryTextBox = new System.Windows.Forms.TextBox();
            this.AddProductPriceTextBox = new System.Windows.Forms.TextBox();
            this.AddProductMaxTextBox = new System.Windows.Forms.TextBox();
            this.AddProductMinLabel = new System.Windows.Forms.Label();
            this.AddProductMinTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AddProductSearchBtn = new System.Windows.Forms.Button();
            this.AddProductAddBtn = new System.Windows.Forms.Button();
            this.AddProductSaveBtn = new System.Windows.Forms.Button();
            this.AddProductDeleteBtn = new System.Windows.Forms.Button();
            this.AddProductCancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // AddProductLbl
            // 
            this.AddProductLbl.AutoSize = true;
            this.AddProductLbl.Location = new System.Drawing.Point(41, 47);
            this.AddProductLbl.Name = "AddProductLbl";
            this.AddProductLbl.Size = new System.Drawing.Size(163, 31);
            this.AddProductLbl.TabIndex = 0;
            this.AddProductLbl.Text = "Add Product";
            // 
            // AddProductIdLabel
            // 
            this.AddProductIdLabel.AutoSize = true;
            this.AddProductIdLabel.Location = new System.Drawing.Point(149, 449);
            this.AddProductIdLabel.Name = "AddProductIdLabel";
            this.AddProductIdLabel.Size = new System.Drawing.Size(42, 31);
            this.AddProductIdLabel.TabIndex = 1;
            this.AddProductIdLabel.Text = "ID";
            // 
            // AddProductNameLabel
            // 
            this.AddProductNameLabel.AutoSize = true;
            this.AddProductNameLabel.Location = new System.Drawing.Point(149, 531);
            this.AddProductNameLabel.Name = "AddProductNameLabel";
            this.AddProductNameLabel.Size = new System.Drawing.Size(86, 31);
            this.AddProductNameLabel.TabIndex = 5;
            this.AddProductNameLabel.Text = "Name";
            // 
            // AddProductInventoryLabel
            // 
            this.AddProductInventoryLabel.AutoSize = true;
            this.AddProductInventoryLabel.Location = new System.Drawing.Point(149, 620);
            this.AddProductInventoryLabel.Name = "AddProductInventoryLabel";
            this.AddProductInventoryLabel.Size = new System.Drawing.Size(127, 31);
            this.AddProductInventoryLabel.TabIndex = 6;
            this.AddProductInventoryLabel.Text = "Inventory";
            // 
            // AddProductPriceLabel
            // 
            this.AddProductPriceLabel.AutoSize = true;
            this.AddProductPriceLabel.Location = new System.Drawing.Point(149, 713);
            this.AddProductPriceLabel.Name = "AddProductPriceLabel";
            this.AddProductPriceLabel.Size = new System.Drawing.Size(76, 31);
            this.AddProductPriceLabel.TabIndex = 7;
            this.AddProductPriceLabel.Text = "Price";
            // 
            // AddProductMaxLabel
            // 
            this.AddProductMaxLabel.AutoSize = true;
            this.AddProductMaxLabel.Location = new System.Drawing.Point(149, 805);
            this.AddProductMaxLabel.Name = "AddProductMaxLabel";
            this.AddProductMaxLabel.Size = new System.Drawing.Size(64, 31);
            this.AddProductMaxLabel.TabIndex = 8;
            this.AddProductMaxLabel.Text = "Max";
            // 
            // AddProductIDTextBx
            // 
            this.AddProductIDTextBx.Location = new System.Drawing.Point(380, 446);
            this.AddProductIDTextBx.Name = "AddProductIDTextBx";
            this.AddProductIDTextBx.ReadOnly = true;
            this.AddProductIDTextBx.Size = new System.Drawing.Size(243, 38);
            this.AddProductIDTextBx.TabIndex = 9;
            // 
            // AddProductNameTextBox
            // 
            this.AddProductNameTextBox.Location = new System.Drawing.Point(380, 541);
            this.AddProductNameTextBox.Name = "AddProductNameTextBox";
            this.AddProductNameTextBox.Size = new System.Drawing.Size(243, 38);
            this.AddProductNameTextBox.TabIndex = 10;
            this.AddProductNameTextBox.TextChanged += new System.EventHandler(this.AddProductNameTextBox_TextChanged);
            // 
            // AddProductInventoryTextBox
            // 
            this.AddProductInventoryTextBox.Location = new System.Drawing.Point(380, 620);
            this.AddProductInventoryTextBox.Name = "AddProductInventoryTextBox";
            this.AddProductInventoryTextBox.Size = new System.Drawing.Size(243, 38);
            this.AddProductInventoryTextBox.TabIndex = 11;
            this.AddProductInventoryTextBox.TextChanged += new System.EventHandler(this.AddProductInventoryTextBox_TextChanged);
            // 
            // AddProductPriceTextBox
            // 
            this.AddProductPriceTextBox.Location = new System.Drawing.Point(380, 710);
            this.AddProductPriceTextBox.Name = "AddProductPriceTextBox";
            this.AddProductPriceTextBox.Size = new System.Drawing.Size(243, 38);
            this.AddProductPriceTextBox.TabIndex = 12;
            this.AddProductPriceTextBox.TextChanged += new System.EventHandler(this.AddProductPriceTextBox_TextChanged);
            // 
            // AddProductMaxTextBox
            // 
            this.AddProductMaxTextBox.Location = new System.Drawing.Point(269, 802);
            this.AddProductMaxTextBox.Name = "AddProductMaxTextBox";
            this.AddProductMaxTextBox.Size = new System.Drawing.Size(139, 38);
            this.AddProductMaxTextBox.TabIndex = 13;
            this.AddProductMaxTextBox.TextChanged += new System.EventHandler(this.AddProductMaxTextBox_TextChanged);
            // 
            // AddProductMinLabel
            // 
            this.AddProductMinLabel.AutoSize = true;
            this.AddProductMinLabel.Location = new System.Drawing.Point(503, 808);
            this.AddProductMinLabel.Name = "AddProductMinLabel";
            this.AddProductMinLabel.Size = new System.Drawing.Size(57, 31);
            this.AddProductMinLabel.TabIndex = 14;
            this.AddProductMinLabel.Text = "Min";
            // 
            // AddProductMinTextBox
            // 
            this.AddProductMinTextBox.Location = new System.Drawing.Point(595, 808);
            this.AddProductMinTextBox.Name = "AddProductMinTextBox";
            this.AddProductMinTextBox.Size = new System.Drawing.Size(142, 38);
            this.AddProductMinTextBox.TabIndex = 15;
            this.AddProductMinTextBox.TextChanged += new System.EventHandler(this.AddProductMinTextBox_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1165, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1068, 323);
            this.dataGridView1.TabIndex = 16;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(1165, 764);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 102;
            this.dataGridView2.RowTemplate.Height = 40;
            this.dataGridView2.Size = new System.Drawing.Size(1068, 320);
            this.dataGridView2.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1176, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "All Parts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1176, 681);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(426, 31);
            this.label2.TabIndex = 19;
            this.label2.Text = "Parts Associated with this Product";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1955, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(304, 38);
            this.textBox1.TabIndex = 20;
            // 
            // AddProductSearchBtn
            // 
            this.AddProductSearchBtn.Location = new System.Drawing.Point(1692, 113);
            this.AddProductSearchBtn.Name = "AddProductSearchBtn";
            this.AddProductSearchBtn.Size = new System.Drawing.Size(176, 47);
            this.AddProductSearchBtn.TabIndex = 21;
            this.AddProductSearchBtn.Text = "Search";
            this.AddProductSearchBtn.UseVisualStyleBackColor = true;
            // 
            // AddProductAddBtn
            // 
            this.AddProductAddBtn.Location = new System.Drawing.Point(2041, 578);
            this.AddProductAddBtn.Name = "AddProductAddBtn";
            this.AddProductAddBtn.Size = new System.Drawing.Size(218, 93);
            this.AddProductAddBtn.TabIndex = 22;
            this.AddProductAddBtn.Text = "Add";
            this.AddProductAddBtn.UseVisualStyleBackColor = true;
            // 
            // AddProductSaveBtn
            // 
            this.AddProductSaveBtn.Location = new System.Drawing.Point(1381, 1173);
            this.AddProductSaveBtn.Name = "AddProductSaveBtn";
            this.AddProductSaveBtn.Size = new System.Drawing.Size(238, 99);
            this.AddProductSaveBtn.TabIndex = 23;
            this.AddProductSaveBtn.Text = "Save";
            this.AddProductSaveBtn.UseVisualStyleBackColor = true;
            this.AddProductSaveBtn.Click += new System.EventHandler(this.AddProductSaveBtn_Click);
            // 
            // AddProductDeleteBtn
            // 
            this.AddProductDeleteBtn.Location = new System.Drawing.Point(1729, 1173);
            this.AddProductDeleteBtn.Name = "AddProductDeleteBtn";
            this.AddProductDeleteBtn.Size = new System.Drawing.Size(208, 99);
            this.AddProductDeleteBtn.TabIndex = 25;
            this.AddProductDeleteBtn.Text = "Delete";
            this.AddProductDeleteBtn.UseVisualStyleBackColor = true;
            // 
            // AddProductCancelBtn
            // 
            this.AddProductCancelBtn.Location = new System.Drawing.Point(2032, 1170);
            this.AddProductCancelBtn.Name = "AddProductCancelBtn";
            this.AddProductCancelBtn.Size = new System.Drawing.Size(227, 104);
            this.AddProductCancelBtn.TabIndex = 26;
            this.AddProductCancelBtn.Text = "Cancel";
            this.AddProductCancelBtn.UseVisualStyleBackColor = true;
            this.AddProductCancelBtn.Click += new System.EventHandler(this.AddProductCancelBtn_Click);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.AddProductCancelBtn);
            this.Controls.Add(this.AddProductDeleteBtn);
            this.Controls.Add(this.AddProductSaveBtn);
            this.Controls.Add(this.AddProductAddBtn);
            this.Controls.Add(this.AddProductSearchBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AddProductMinTextBox);
            this.Controls.Add(this.AddProductMinLabel);
            this.Controls.Add(this.AddProductMaxTextBox);
            this.Controls.Add(this.AddProductPriceTextBox);
            this.Controls.Add(this.AddProductInventoryTextBox);
            this.Controls.Add(this.AddProductNameTextBox);
            this.Controls.Add(this.AddProductIDTextBx);
            this.Controls.Add(this.AddProductMaxLabel);
            this.Controls.Add(this.AddProductPriceLabel);
            this.Controls.Add(this.AddProductInventoryLabel);
            this.Controls.Add(this.AddProductNameLabel);
            this.Controls.Add(this.AddProductIdLabel);
            this.Controls.Add(this.AddProductLbl);
            this.Name = "AddProductForm";
            this.Text = "AddProduct";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddProductLbl;
        private System.Windows.Forms.Label AddProductIdLabel;
        private System.Windows.Forms.Label AddProductNameLabel;
        private System.Windows.Forms.Label AddProductInventoryLabel;
        private System.Windows.Forms.Label AddProductPriceLabel;
        private System.Windows.Forms.Label AddProductMaxLabel;
        private System.Windows.Forms.TextBox AddProductIDTextBx;
        private System.Windows.Forms.TextBox AddProductNameTextBox;
        private System.Windows.Forms.TextBox AddProductInventoryTextBox;
        private System.Windows.Forms.TextBox AddProductPriceTextBox;
        private System.Windows.Forms.TextBox AddProductMaxTextBox;
        private System.Windows.Forms.Label AddProductMinLabel;
        private System.Windows.Forms.TextBox AddProductMinTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button AddProductSearchBtn;
        private System.Windows.Forms.Button AddProductAddBtn;
        private System.Windows.Forms.Button AddProductSaveBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AddProductDeleteBtn;
        private System.Windows.Forms.Button AddProductCancelBtn;
    }
}