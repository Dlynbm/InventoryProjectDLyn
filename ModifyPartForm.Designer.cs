
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
            this.ModifyPartLbl.Location = new System.Drawing.Point(138, 91);
            this.ModifyPartLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ModifyPartLbl.Name = "ModifyPartLbl";
            this.ModifyPartLbl.Size = new System.Drawing.Size(158, 32);
            this.ModifyPartLbl.TabIndex = 0;
            this.ModifyPartLbl.Text = "Modify Part";
            // 
            // InHouseRadioBtn
            // 
            this.InHouseRadioBtn.AutoSize = true;
            this.InHouseRadioBtn.Location = new System.Drawing.Point(576, 91);
            this.InHouseRadioBtn.Margin = new System.Windows.Forms.Padding(8);
            this.InHouseRadioBtn.Name = "InHouseRadioBtn";
            this.InHouseRadioBtn.Size = new System.Drawing.Size(166, 36);
            this.InHouseRadioBtn.TabIndex = 1;
            this.InHouseRadioBtn.TabStop = true;
            this.InHouseRadioBtn.Text = "In-House";
            this.InHouseRadioBtn.UseVisualStyleBackColor = true;
            this.InHouseRadioBtn.CheckedChanged += new System.EventHandler(this.InHouseRadioBtn_CheckedChanged);
            // 
            // OutsourcedRadioBtn
            // 
            this.OutsourcedRadioBtn.AutoSize = true;
            this.OutsourcedRadioBtn.Location = new System.Drawing.Point(1150, 91);
            this.OutsourcedRadioBtn.Margin = new System.Windows.Forms.Padding(8);
            this.OutsourcedRadioBtn.Name = "OutsourcedRadioBtn";
            this.OutsourcedRadioBtn.Size = new System.Drawing.Size(199, 36);
            this.OutsourcedRadioBtn.TabIndex = 2;
            this.OutsourcedRadioBtn.TabStop = true;
            this.OutsourcedRadioBtn.Text = "Outsourced";
            this.OutsourcedRadioBtn.UseVisualStyleBackColor = true;
            this.OutsourcedRadioBtn.CheckedChanged += new System.EventHandler(this.OutsourcedRadioBtn_CheckedChanged);
            // 
            // PartIdLbl
            // 
            this.PartIdLbl.AutoSize = true;
            this.PartIdLbl.Location = new System.Drawing.Point(446, 198);
            this.PartIdLbl.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.PartIdLbl.Name = "PartIdLbl";
            this.PartIdLbl.Size = new System.Drawing.Size(97, 32);
            this.PartIdLbl.TabIndex = 3;
            this.PartIdLbl.Text = "Part Id";
            // 
            // ModifyNameLabel
            // 
            this.ModifyNameLabel.AutoSize = true;
            this.ModifyNameLabel.Location = new System.Drawing.Point(454, 300);
            this.ModifyNameLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.ModifyNameLabel.Name = "ModifyNameLabel";
            this.ModifyNameLabel.Size = new System.Drawing.Size(90, 32);
            this.ModifyNameLabel.TabIndex = 4;
            this.ModifyNameLabel.Text = "Name";
            // 
            // InventoryLabel
            // 
            this.InventoryLabel.AutoSize = true;
            this.InventoryLabel.Location = new System.Drawing.Point(454, 389);
            this.InventoryLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.InventoryLabel.Name = "InventoryLabel";
            this.InventoryLabel.Size = new System.Drawing.Size(131, 32);
            this.InventoryLabel.TabIndex = 5;
            this.InventoryLabel.Text = "Inventory";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(446, 488);
            this.PriceLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(146, 32);
            this.PriceLabel.TabIndex = 6;
            this.PriceLabel.Text = "Price/Cost";
            // 
            // MaxLabel
            // 
            this.MaxLabel.AutoSize = true;
            this.MaxLabel.Location = new System.Drawing.Point(454, 606);
            this.MaxLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.MaxLabel.Name = "MaxLabel";
            this.MaxLabel.Size = new System.Drawing.Size(68, 32);
            this.MaxLabel.TabIndex = 7;
            this.MaxLabel.Text = "Max";
            // 
            // MinLabel
            // 
            this.MinLabel.AutoSize = true;
            this.MinLabel.Location = new System.Drawing.Point(784, 606);
            this.MinLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.MinLabel.Name = "MinLabel";
            this.MinLabel.Size = new System.Drawing.Size(61, 32);
            this.MinLabel.TabIndex = 8;
            this.MinLabel.Text = "Min";
            // 
            // MachineIdLabel
            // 
            this.MachineIdLabel.AutoSize = true;
            this.MachineIdLabel.Location = new System.Drawing.Point(454, 736);
            this.MachineIdLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.MachineIdLabel.Name = "MachineIdLabel";
            this.MachineIdLabel.Size = new System.Drawing.Size(157, 32);
            this.MachineIdLabel.TabIndex = 9;
            this.MachineIdLabel.Text = "Machine ID";
            // 
            // ModifyPartIdTxtBox
            // 
            this.ModifyPartIdTxtBox.Location = new System.Drawing.Point(742, 190);
            this.ModifyPartIdTxtBox.Margin = new System.Windows.Forms.Padding(8);
            this.ModifyPartIdTxtBox.Name = "ModifyPartIdTxtBox";
            this.ModifyPartIdTxtBox.ReadOnly = true;
            this.ModifyPartIdTxtBox.Size = new System.Drawing.Size(260, 38);
            this.ModifyPartIdTxtBox.TabIndex = 10;
            // 
            // ModifyNameTxtBox
            // 
            this.ModifyNameTxtBox.Location = new System.Drawing.Point(742, 300);
            this.ModifyNameTxtBox.Margin = new System.Windows.Forms.Padding(8);
            this.ModifyNameTxtBox.Name = "ModifyNameTxtBox";
            this.ModifyNameTxtBox.Size = new System.Drawing.Size(260, 38);
            this.ModifyNameTxtBox.TabIndex = 11;
            this.ModifyNameTxtBox.TextChanged += new System.EventHandler(this.ModifyNameTxtBox_TextChanged_1);
            // 
            // ModifyInventoryTxtBox
            // 
            this.ModifyInventoryTxtBox.Location = new System.Drawing.Point(742, 389);
            this.ModifyInventoryTxtBox.Margin = new System.Windows.Forms.Padding(8);
            this.ModifyInventoryTxtBox.Name = "ModifyInventoryTxtBox";
            this.ModifyInventoryTxtBox.Size = new System.Drawing.Size(260, 38);
            this.ModifyInventoryTxtBox.TabIndex = 12;
            this.ModifyInventoryTxtBox.TextChanged += new System.EventHandler(this.ModifyInventoryTxtBox_TextChanged);
            // 
            // PriceCostTextBox
            // 
            this.PriceCostTextBox.Location = new System.Drawing.Point(742, 488);
            this.PriceCostTextBox.Margin = new System.Windows.Forms.Padding(8);
            this.PriceCostTextBox.Name = "PriceCostTextBox";
            this.PriceCostTextBox.Size = new System.Drawing.Size(260, 38);
            this.PriceCostTextBox.TabIndex = 13;
            this.PriceCostTextBox.TextChanged += new System.EventHandler(this.PriceCostTextBox_TextChanged);
            // 
            // MaxTxtBox
            // 
            this.MaxTxtBox.Location = new System.Drawing.Point(542, 606);
            this.MaxTxtBox.Margin = new System.Windows.Forms.Padding(8);
            this.MaxTxtBox.Name = "MaxTxtBox";
            this.MaxTxtBox.Size = new System.Drawing.Size(130, 38);
            this.MaxTxtBox.TabIndex = 14;
            this.MaxTxtBox.TextChanged += new System.EventHandler(this.MaxTxtBox_TextChanged);
            // 
            // MinTxtBox
            // 
            this.MinTxtBox.Location = new System.Drawing.Point(918, 606);
            this.MinTxtBox.Margin = new System.Windows.Forms.Padding(8);
            this.MinTxtBox.Name = "MinTxtBox";
            this.MinTxtBox.Size = new System.Drawing.Size(132, 38);
            this.MinTxtBox.TabIndex = 15;
            this.MinTxtBox.TextChanged += new System.EventHandler(this.MinTxtBox_TextChanged);
            // 
            // MachineCoNameTxtBox
            // 
            this.MachineCoNameTxtBox.Location = new System.Drawing.Point(662, 736);
            this.MachineCoNameTxtBox.Margin = new System.Windows.Forms.Padding(8);
            this.MachineCoNameTxtBox.Name = "MachineCoNameTxtBox";
            this.MachineCoNameTxtBox.Size = new System.Drawing.Size(260, 38);
            this.MachineCoNameTxtBox.TabIndex = 16;
            this.MachineCoNameTxtBox.TextChanged += new System.EventHandler(this.MachineCoNameTxtBox_TextChanged);
            // 
            // ModifySaveBtn
            // 
            this.ModifySaveBtn.Location = new System.Drawing.Point(882, 953);
            this.ModifySaveBtn.Margin = new System.Windows.Forms.Padding(8);
            this.ModifySaveBtn.Name = "ModifySaveBtn";
            this.ModifySaveBtn.Size = new System.Drawing.Size(234, 95);
            this.ModifySaveBtn.TabIndex = 17;
            this.ModifySaveBtn.Text = "Save";
            this.ModifySaveBtn.UseVisualStyleBackColor = true;
            this.ModifySaveBtn.Click += new System.EventHandler(this.ModifySaveBtn_Click);
            // 
            // ModifyCancelBtn
            // 
            this.ModifyCancelBtn.Location = new System.Drawing.Point(1262, 953);
            this.ModifyCancelBtn.Margin = new System.Windows.Forms.Padding(8);
            this.ModifyCancelBtn.Name = "ModifyCancelBtn";
            this.ModifyCancelBtn.Size = new System.Drawing.Size(242, 95);
            this.ModifyCancelBtn.TabIndex = 18;
            this.ModifyCancelBtn.Text = "Cancel";
            this.ModifyCancelBtn.UseVisualStyleBackColor = true;
            this.ModifyCancelBtn.Click += new System.EventHandler(this.ModifyCancelBtn_Click_1);
            // 
            // ModifyPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1558, 1077);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ModifyPartForm";
            this.Text = "ModifyPartForm";
            this.Load += new System.EventHandler(this.ModifyPartForm_Load);
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