
namespace InventoryProjectDLyn
{
    partial class ModifyPartForm
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
            this.ModifyPartLbl = new System.Windows.Forms.Label();
            this.InHouseRadioBtn = new System.Windows.Forms.RadioButton();
            this.OutsourcedRadioBtn = new System.Windows.Forms.RadioButton();
            this.PartIdLbl = new System.Windows.Forms.Label();
            this.ModifyNameLabel = new System.Windows.Forms.Label();
            this.InventoryLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.MaxLabel = new System.Windows.Forms.Label();
            this.MinLabel = new System.Windows.Forms.Label();
            this.MachineIdLabel = new System.Windows.Forms.Label();
            this.ModifyPartIdTxtBox = new System.Windows.Forms.TextBox();
            this.ModifyNameTxtBox = new System.Windows.Forms.TextBox();
            this.ModifyInventoryTxtBox = new System.Windows.Forms.TextBox();
            this.PriceCostTextBox = new System.Windows.Forms.TextBox();
            this.MaxTxtBox = new System.Windows.Forms.TextBox();
            this.MinTxtBox = new System.Windows.Forms.TextBox();
            this.MachineCoNameTxtBox = new System.Windows.Forms.TextBox();
            this.ModifySaveBtn = new System.Windows.Forms.Button();
            this.ModifyCancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ModifyPartLbl
            // 
            this.ModifyPartLbl.AutoSize = true;
            this.ModifyPartLbl.Location = new System.Drawing.Point(52, 38);
            this.ModifyPartLbl.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.ModifyPartLbl.Name = "ModifyPartLbl";
            this.ModifyPartLbl.Size = new System.Drawing.Size(60, 13);
            this.ModifyPartLbl.TabIndex = 0;
            this.ModifyPartLbl.Text = "Modify Part";
            // 
            // InHouseRadioBtn
            // 
            this.InHouseRadioBtn.AutoSize = true;
            this.InHouseRadioBtn.Location = new System.Drawing.Point(216, 38);
            this.InHouseRadioBtn.Name = "InHouseRadioBtn";
            this.InHouseRadioBtn.Size = new System.Drawing.Size(68, 17);
            this.InHouseRadioBtn.TabIndex = 1;
            this.InHouseRadioBtn.TabStop = true;
            this.InHouseRadioBtn.Text = "In-House";
            this.InHouseRadioBtn.UseVisualStyleBackColor = true;
            // 
            // OutsourcedRadioBtn
            // 
            this.OutsourcedRadioBtn.AutoSize = true;
            this.OutsourcedRadioBtn.Location = new System.Drawing.Point(431, 38);
            this.OutsourcedRadioBtn.Name = "OutsourcedRadioBtn";
            this.OutsourcedRadioBtn.Size = new System.Drawing.Size(80, 17);
            this.OutsourcedRadioBtn.TabIndex = 2;
            this.OutsourcedRadioBtn.TabStop = true;
            this.OutsourcedRadioBtn.Text = "Outsourced";
            this.OutsourcedRadioBtn.UseVisualStyleBackColor = true;
            this.OutsourcedRadioBtn.CheckedChanged += new System.EventHandler(this.OutsourcedRadioBtn_CheckedChanged);
            // 
            // PartIdLbl
            // 
            this.PartIdLbl.AutoSize = true;
            this.PartIdLbl.Location = new System.Drawing.Point(167, 83);
            this.PartIdLbl.Name = "PartIdLbl";
            this.PartIdLbl.Size = new System.Drawing.Size(38, 13);
            this.PartIdLbl.TabIndex = 3;
            this.PartIdLbl.Text = "Part Id";
            // 
            // ModifyNameLabel
            // 
            this.ModifyNameLabel.AutoSize = true;
            this.ModifyNameLabel.Location = new System.Drawing.Point(170, 126);
            this.ModifyNameLabel.Name = "ModifyNameLabel";
            this.ModifyNameLabel.Size = new System.Drawing.Size(35, 13);
            this.ModifyNameLabel.TabIndex = 4;
            this.ModifyNameLabel.Text = "Name";
            // 
            // InventoryLabel
            // 
            this.InventoryLabel.AutoSize = true;
            this.InventoryLabel.Location = new System.Drawing.Point(170, 163);
            this.InventoryLabel.Name = "InventoryLabel";
            this.InventoryLabel.Size = new System.Drawing.Size(51, 13);
            this.InventoryLabel.TabIndex = 5;
            this.InventoryLabel.Text = "Inventory";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(167, 205);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(57, 13);
            this.PriceLabel.TabIndex = 6;
            this.PriceLabel.Text = "Price/Cost";
            // 
            // MaxLabel
            // 
            this.MaxLabel.AutoSize = true;
            this.MaxLabel.Location = new System.Drawing.Point(170, 254);
            this.MaxLabel.Name = "MaxLabel";
            this.MaxLabel.Size = new System.Drawing.Size(27, 13);
            this.MaxLabel.TabIndex = 7;
            this.MaxLabel.Text = "Max";
            // 
            // MinLabel
            // 
            this.MinLabel.AutoSize = true;
            this.MinLabel.Location = new System.Drawing.Point(294, 254);
            this.MinLabel.Name = "MinLabel";
            this.MinLabel.Size = new System.Drawing.Size(24, 13);
            this.MinLabel.TabIndex = 8;
            this.MinLabel.Text = "Min";
            // 
            // MachineIdLabel
            // 
            this.MachineIdLabel.AutoSize = true;
            this.MachineIdLabel.Location = new System.Drawing.Point(170, 309);
            this.MachineIdLabel.Name = "MachineIdLabel";
            this.MachineIdLabel.Size = new System.Drawing.Size(62, 13);
            this.MachineIdLabel.TabIndex = 9;
            this.MachineIdLabel.Text = "Machine ID";
            // 
            // ModifyPartIdTxtBox
            // 
            this.ModifyPartIdTxtBox.Location = new System.Drawing.Point(278, 80);
            this.ModifyPartIdTxtBox.Name = "ModifyPartIdTxtBox";
            this.ModifyPartIdTxtBox.ReadOnly = true;
            this.ModifyPartIdTxtBox.Size = new System.Drawing.Size(100, 20);
            this.ModifyPartIdTxtBox.TabIndex = 10;
            // 
            // ModifyNameTxtBox
            // 
            this.ModifyNameTxtBox.Location = new System.Drawing.Point(278, 126);
            this.ModifyNameTxtBox.Name = "ModifyNameTxtBox";
            this.ModifyNameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.ModifyNameTxtBox.TabIndex = 11;
            // 
            // ModifyInventoryTxtBox
            // 
            this.ModifyInventoryTxtBox.Location = new System.Drawing.Point(278, 163);
            this.ModifyInventoryTxtBox.Name = "ModifyInventoryTxtBox";
            this.ModifyInventoryTxtBox.Size = new System.Drawing.Size(100, 20);
            this.ModifyInventoryTxtBox.TabIndex = 12;
            // 
            // PriceCostTextBox
            // 
            this.PriceCostTextBox.Location = new System.Drawing.Point(278, 205);
            this.PriceCostTextBox.Name = "PriceCostTextBox";
            this.PriceCostTextBox.Size = new System.Drawing.Size(100, 20);
            this.PriceCostTextBox.TabIndex = 13;
            // 
            // MaxTxtBox
            // 
            this.MaxTxtBox.Location = new System.Drawing.Point(203, 254);
            this.MaxTxtBox.Name = "MaxTxtBox";
            this.MaxTxtBox.Size = new System.Drawing.Size(51, 20);
            this.MaxTxtBox.TabIndex = 14;
            // 
            // MinTxtBox
            // 
            this.MinTxtBox.Location = new System.Drawing.Point(344, 254);
            this.MinTxtBox.Name = "MinTxtBox";
            this.MinTxtBox.Size = new System.Drawing.Size(52, 20);
            this.MinTxtBox.TabIndex = 15;
            // 
            // MachineCoNameTxtBox
            // 
            this.MachineCoNameTxtBox.Location = new System.Drawing.Point(248, 309);
            this.MachineCoNameTxtBox.Name = "MachineCoNameTxtBox";
            this.MachineCoNameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.MachineCoNameTxtBox.TabIndex = 16;
            // 
            // ModifySaveBtn
            // 
            this.ModifySaveBtn.Location = new System.Drawing.Point(331, 400);
            this.ModifySaveBtn.Name = "ModifySaveBtn";
            this.ModifySaveBtn.Size = new System.Drawing.Size(88, 40);
            this.ModifySaveBtn.TabIndex = 17;
            this.ModifySaveBtn.Text = "Save";
            this.ModifySaveBtn.UseVisualStyleBackColor = true;
            this.ModifySaveBtn.Click += new System.EventHandler(this.ModifySaveBtn_Click);
            // 
            // ModifyCancelBtn
            // 
            this.ModifyCancelBtn.Location = new System.Drawing.Point(473, 400);
            this.ModifyCancelBtn.Name = "ModifyCancelBtn";
            this.ModifyCancelBtn.Size = new System.Drawing.Size(91, 40);
            this.ModifyCancelBtn.TabIndex = 18;
            this.ModifyCancelBtn.Text = "Cancel";
            this.ModifyCancelBtn.UseVisualStyleBackColor = true;
            // 
            // ModifyPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 452);
            this.Controls.Add(this.ModifyCancelBtn);
            this.Controls.Add(this.ModifySaveBtn);
            this.Controls.Add(this.MachineCoNameTxtBox);
            this.Controls.Add(this.MinTxtBox);
            this.Controls.Add(this.MaxTxtBox);
            this.Controls.Add(this.PriceCostTextBox);
            this.Controls.Add(this.ModifyInventoryTxtBox);
            this.Controls.Add(this.ModifyNameTxtBox);
            this.Controls.Add(this.ModifyPartIdTxtBox);
            this.Controls.Add(this.MachineIdLabel);
            this.Controls.Add(this.MinLabel);
            this.Controls.Add(this.MaxLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.InventoryLabel);
            this.Controls.Add(this.ModifyNameLabel);
            this.Controls.Add(this.PartIdLbl);
            this.Controls.Add(this.OutsourcedRadioBtn);
            this.Controls.Add(this.InHouseRadioBtn);
            this.Controls.Add(this.ModifyPartLbl);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "ModifyPartForm";
            this.Text = "ModifyPartForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ModifyPartLbl;
        public System.Windows.Forms.RadioButton InHouseRadioBtn;
        public System.Windows.Forms.RadioButton OutsourcedRadioBtn;
        private System.Windows.Forms.Label PartIdLbl;
        private System.Windows.Forms.Label ModifyNameLabel;
        private System.Windows.Forms.Label InventoryLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label MaxLabel;
        private System.Windows.Forms.Label MinLabel;
        public System.Windows.Forms.Label MachineIdLabel;
        public System.Windows.Forms.TextBox ModifyPartIdTxtBox;
        public System.Windows.Forms.TextBox ModifyNameTxtBox;
        public System.Windows.Forms.TextBox ModifyInventoryTxtBox;
        public System.Windows.Forms.TextBox PriceCostTextBox;
        public System.Windows.Forms.TextBox MaxTxtBox;
        public System.Windows.Forms.TextBox MinTxtBox;
        public System.Windows.Forms.TextBox MachineCoNameTxtBox;
        private System.Windows.Forms.Button ModifySaveBtn;
        private System.Windows.Forms.Button ModifyCancelBtn;
    }
}