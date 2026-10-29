namespace Service_Center_Management_System__SCMS_
{
    partial class frmAddEditSparePart
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPartID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPartCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbPartBrand = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nudMSLevel = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCreatedUser = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gbInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtSellingPrice = new SCMSControlsLib.cusTextBox();
            this.chkIsActive = new Guna.UI2.WinForms.Guna2CheckBox();
            this.txtPartName = new SCMSControlsLib.cusTextBox();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMSLevel)).BeginInit();
            this.gbInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(135, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(472, 56);
            this.lblTitle.TabIndex = 37;
            this.lblTitle.Text = "Add Edit Spare Part";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Part ID : ";
            // 
            // lblPartID
            // 
            this.lblPartID.AutoSize = true;
            this.lblPartID.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartID.ForeColor = System.Drawing.Color.Red;
            this.lblPartID.Location = new System.Drawing.Point(280, 54);
            this.lblPartID.Name = "lblPartID";
            this.lblPartID.Size = new System.Drawing.Size(64, 32);
            this.lblPartID.TabIndex = 1;
            this.lblPartID.Text = "[???]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Part Name : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Part Category : ";
            // 
            // cbPartCategory
            // 
            this.cbPartCategory.BackColor = System.Drawing.Color.Transparent;
            this.cbPartCategory.BorderColor = System.Drawing.Color.Gainsboro;
            this.cbPartCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPartCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPartCategory.FillColor = System.Drawing.Color.Gainsboro;
            this.cbPartCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPartCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPartCategory.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPartCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbPartCategory.ItemHeight = 30;
            this.cbPartCategory.Location = new System.Drawing.Point(240, 197);
            this.cbPartCategory.Name = "cbPartCategory";
            this.cbPartCategory.Size = new System.Drawing.Size(269, 36);
            this.cbPartCategory.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Part Brand : ";
            // 
            // cbPartBrand
            // 
            this.cbPartBrand.BackColor = System.Drawing.Color.Transparent;
            this.cbPartBrand.BorderColor = System.Drawing.Color.Gainsboro;
            this.cbPartBrand.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPartBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPartBrand.FillColor = System.Drawing.Color.Gainsboro;
            this.cbPartBrand.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPartBrand.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPartBrand.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPartBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbPartBrand.ItemHeight = 30;
            this.cbPartBrand.Location = new System.Drawing.Point(240, 275);
            this.cbPartBrand.Name = "cbPartBrand";
            this.cbPartBrand.Size = new System.Drawing.Size(269, 36);
            this.cbPartBrand.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Selling Price :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "Quantity :";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(239, 424);
            this.nudQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(142, 39);
            this.nudQuantity.TabIndex = 11;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 494);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(272, 32);
            this.label7.TabIndex = 12;
            this.label7.Text = "Minimum Stock Level :";
            // 
            // nudMSLevel
            // 
            this.nudMSLevel.Location = new System.Drawing.Point(294, 492);
            this.nudMSLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMSLevel.Name = "nudMSLevel";
            this.nudMSLevel.Size = new System.Drawing.Size(137, 39);
            this.nudMSLevel.TabIndex = 13;
            this.nudMSLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 561);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 32);
            this.label8.TabIndex = 14;
            this.label8.Text = "Created By :";
            // 
            // lblCreatedUser
            // 
            this.lblCreatedUser.AutoSize = true;
            this.lblCreatedUser.ForeColor = System.Drawing.Color.Red;
            this.lblCreatedUser.Location = new System.Drawing.Point(191, 563);
            this.lblCreatedUser.Name = "lblCreatedUser";
            this.lblCreatedUser.Size = new System.Drawing.Size(65, 32);
            this.lblCreatedUser.TabIndex = 15;
            this.lblCreatedUser.Text = "[???]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(409, 561);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 32);
            this.label9.TabIndex = 16;
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.txtSellingPrice);
            this.gbInfo.Controls.Add(this.chkIsActive);
            this.gbInfo.Controls.Add(this.label9);
            this.gbInfo.Controls.Add(this.lblCreatedUser);
            this.gbInfo.Controls.Add(this.label8);
            this.gbInfo.Controls.Add(this.nudMSLevel);
            this.gbInfo.Controls.Add(this.label7);
            this.gbInfo.Controls.Add(this.nudQuantity);
            this.gbInfo.Controls.Add(this.label6);
            this.gbInfo.Controls.Add(this.label5);
            this.gbInfo.Controls.Add(this.cbPartBrand);
            this.gbInfo.Controls.Add(this.label4);
            this.gbInfo.Controls.Add(this.cbPartCategory);
            this.gbInfo.Controls.Add(this.label3);
            this.gbInfo.Controls.Add(this.txtPartName);
            this.gbInfo.Controls.Add(this.label2);
            this.gbInfo.Controls.Add(this.lblPartID);
            this.gbInfo.Controls.Add(this.label1);
            this.gbInfo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfo.ForeColor = System.Drawing.Color.Black;
            this.gbInfo.Location = new System.Drawing.Point(12, 97);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(736, 598);
            this.gbInfo.TabIndex = 38;
            this.gbInfo.Text = "Add Edit Spare Part";
            // 
            // txtSellingPrice
            // 
            this.txtSellingPrice.IsRequired = true;
            this.txtSellingPrice.Length = null;
            this.txtSellingPrice.Location = new System.Drawing.Point(241, 350);
            this.txtSellingPrice.Name = "txtSellingPrice";
            this.txtSellingPrice.Size = new System.Drawing.Size(267, 39);
            this.txtSellingPrice.TabIndex = 18;
            this.txtSellingPrice.WritingType = SCMSControlsLib.cusTextBox.enWritingType.Numbers;
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkIsActive.CheckedState.BorderRadius = 0;
            this.chkIsActive.CheckedState.BorderThickness = 0;
            this.chkIsActive.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkIsActive.Enabled = false;
            this.chkIsActive.Location = new System.Drawing.Point(502, 557);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(130, 36);
            this.chkIsActive.TabIndex = 17;
            this.chkIsActive.Text = "Is Active";
            this.chkIsActive.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkIsActive.UncheckedState.BorderRadius = 0;
            this.chkIsActive.UncheckedState.BorderThickness = 0;
            this.chkIsActive.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // txtPartName
            // 
            this.txtPartName.IsRequired = true;
            this.txtPartName.Length = null;
            this.txtPartName.Location = new System.Drawing.Point(241, 125);
            this.txtPartName.Name = "txtPartName";
            this.txtPartName.Size = new System.Drawing.Size(267, 39);
            this.txtPartName.TabIndex = 3;
            this.txtPartName.WritingType = SCMSControlsLib.cusTextBox.enWritingType.None;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.BorderColor = System.Drawing.Color.White;
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.LightGray;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Image = global::Service_Center_Management_System__SCMS_.Properties.Resources.close;
            this.btnCancel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCancel.Location = new System.Drawing.Point(404, 703);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(156, 45);
            this.btnCancel.TabIndex = 40;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderColor = System.Drawing.Color.White;
            this.btnSave.BorderRadius = 10;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Image = global::Service_Center_Management_System__SCMS_.Properties.Resources.people;
            this.btnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSave.Location = new System.Drawing.Point(583, 704);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(157, 45);
            this.btnSave.TabIndex = 39;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddEditSparePart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(760, 760);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmAddEditSparePart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Edit Spare Part";
            this.Activated += new System.EventHandler(this.frmAddEditSparePart_Activated);
            this.Load += new System.EventHandler(this.frmAddEditSparePart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMSLevel)).EndInit();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPartID;
        private System.Windows.Forms.Label label2;
        private SCMSControlsLib.cusTextBox txtPartName;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cbPartCategory;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cbPartBrand;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudMSLevel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCreatedUser;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2GroupBox gbInfo;
        private Guna.UI2.WinForms.Guna2CheckBox chkIsActive;
        private SCMSControlsLib.cusTextBox txtSellingPrice;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSave;
    }
}