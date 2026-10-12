namespace Service_Center_Management_System__SCMS_
{
    partial class frmCreateSparePartPurchase
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
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCreatedUser = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPurchaseID = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ucSearchForSparePart1 = new SCMSControlsLib.ucSearchForSparePart();
            this.ucSearchForSupplier1 = new SCMSControlsLib.ucSearchForSupplier();
            this.lblPurchaseDate = new System.Windows.Forms.Label();
            this.txtPurchasePrice = new SCMSControlsLib.cusTextBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(246, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(456, 45);
            this.lblTitle.TabIndex = 29;
            this.lblTitle.Text = "Create Spare Part Purchase";
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.guna2TabControl1.Controls.Add(this.tabPage1);
            this.guna2TabControl1.Controls.Add(this.tabPage2);
            this.guna2TabControl1.Controls.Add(this.tabPage3);
            this.guna2TabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(4, 61);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.ShowToolTips = true;
            this.guna2TabControl1.Size = new System.Drawing.Size(913, 637);
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.TabButtonTextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            this.guna2TabControl1.TabIndex = 35;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ucSearchForSparePart1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(184, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(725, 629);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Part ID";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.ucSearchForSupplier1);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.tabPage2.Location = new System.Drawing.Point(184, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(725, 629);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Supplier ID";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.BorderColor = System.Drawing.Color.White;
            this.btnClose.BorderRadius = 10;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.LightGray;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Image = global::Service_Center_Management_System__SCMS_.Properties.Resources.close;
            this.btnClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClose.Location = new System.Drawing.Point(567, 704);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(156, 45);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.btnSave.Location = new System.Drawing.Point(746, 704);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(157, 45);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblTotalPrice);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.nudQuantity);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.txtPurchasePrice);
            this.tabPage3.Controls.Add(this.lblPurchaseDate);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.lblCreatedUser);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.lblPurchaseID);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Location = new System.Drawing.Point(184, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(725, 629);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Additional Information";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(42, 515);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 38);
            this.label3.TabIndex = 46;
            this.label3.Text = "Purchase Date :";
            // 
            // lblCreatedUser
            // 
            this.lblCreatedUser.AutoSize = true;
            this.lblCreatedUser.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedUser.ForeColor = System.Drawing.Color.Black;
            this.lblCreatedUser.Location = new System.Drawing.Point(334, 426);
            this.lblCreatedUser.Name = "lblCreatedUser";
            this.lblCreatedUser.Size = new System.Drawing.Size(90, 38);
            this.lblCreatedUser.TabIndex = 45;
            this.lblCreatedUser.Text = "[???]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(19, 424);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(277, 38);
            this.label7.TabIndex = 44;
            this.label7.Text = "Created By User :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(19, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(260, 38);
            this.label9.TabIndex = 42;
            this.label9.Text = "Purchase Price :";
            // 
            // lblPurchaseID
            // 
            this.lblPurchaseID.AutoSize = true;
            this.lblPurchaseID.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchaseID.ForeColor = System.Drawing.Color.Blue;
            this.lblPurchaseID.Location = new System.Drawing.Point(306, 32);
            this.lblPurchaseID.Name = "lblPurchaseID";
            this.lblPurchaseID.Size = new System.Drawing.Size(90, 38);
            this.lblPurchaseID.TabIndex = 41;
            this.lblPurchaseID.Text = "[???]";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(63, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(215, 38);
            this.label11.TabIndex = 40;
            this.label11.Text = "Purchase ID :";
            // 
            // ucSearchForSparePart1
            // 
            this.ucSearchForSparePart1.Location = new System.Drawing.Point(-9, -4);
            this.ucSearchForSparePart1.Name = "ucSearchForSparePart1";
            this.ucSearchForSparePart1.Size = new System.Drawing.Size(735, 633);
            this.ucSearchForSparePart1.TabIndex = 0;
            // 
            // ucSearchForSupplier1
            // 
            this.ucSearchForSupplier1.BackColor = System.Drawing.Color.Snow;
            this.ucSearchForSupplier1.Location = new System.Drawing.Point(4, 103);
            this.ucSearchForSupplier1.Name = "ucSearchForSupplier1";
            this.ucSearchForSupplier1.Size = new System.Drawing.Size(716, 432);
            this.ucSearchForSupplier1.TabIndex = 0;
            // 
            // lblPurchaseDate
            // 
            this.lblPurchaseDate.AutoSize = true;
            this.lblPurchaseDate.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchaseDate.ForeColor = System.Drawing.Color.Black;
            this.lblPurchaseDate.Location = new System.Drawing.Point(334, 516);
            this.lblPurchaseDate.Name = "lblPurchaseDate";
            this.lblPurchaseDate.Size = new System.Drawing.Size(90, 38);
            this.lblPurchaseDate.TabIndex = 47;
            this.lblPurchaseDate.Text = "[???]";
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurchasePrice.IsRequired = true;
            this.txtPurchasePrice.Length = null;
            this.txtPurchasePrice.Location = new System.Drawing.Point(297, 157);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(279, 35);
            this.txtPurchasePrice.TabIndex = 48;
            this.txtPurchasePrice.WritingType = SCMSControlsLib.cusTextBox.enWritingType.Numbers;
            // 
            // nudQuantity
            // 
            this.nudQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantity.Location = new System.Drawing.Point(302, 240);
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
            this.nudQuantity.Size = new System.Drawing.Size(142, 44);
            this.nudQuantity.TabIndex = 50;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(114, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 37);
            this.label6.TabIndex = 49;
            this.label6.Text = "Quantity :";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.Black;
            this.lblTotalPrice.Location = new System.Drawing.Point(334, 336);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(90, 38);
            this.lblTotalPrice.TabIndex = 52;
            this.lblTotalPrice.Text = "[???]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(83, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 38);
            this.label2.TabIndex = 51;
            this.label2.Text = "Total Price :";
            // 
            // frmCreateSparePartPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(916, 755);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.guna2TabControl1);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmCreateSparePartPurchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Spare Part Purchase";
            this.Load += new System.EventHandler(this.frmCreateSparePartPurchase_Load);
            this.guna2TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCreatedUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPurchaseID;
        private System.Windows.Forms.Label label11;
        private SCMSControlsLib.ucSearchForSparePart ucSearchForSparePart1;
        private SCMSControlsLib.ucSearchForSupplier ucSearchForSupplier1;
        private System.Windows.Forms.Label lblPurchaseDate;
        private SCMSControlsLib.cusTextBox txtPurchasePrice;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label label6;
    }
}