namespace Service_Center_Management_System__SCMS_
{
    partial class frmSetRepairCost
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDiscount = new SCMSControlsLib.cusTextBox();
            this.lblCreatedUser = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblCreatedDate = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTotalRepairCost = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTaxAmount = new SCMSControlsLib.cusTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdditionalServices = new SCMSControlsLib.cusTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLaborCost = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalPartsCost = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ucShowUsedParts1 = new SCMSControlsLib.ucShowUsedParts();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(223, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(419, 64);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add Repair Cost";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.txtDiscount);
            this.groupBox1.Controls.Add(this.lblCreatedUser);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lblCreatedDate);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lblTotalRepairCost);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTaxAmount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtAdditionalServices);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblLaborCost);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblTotalPartsCost);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ucShowUsedParts1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(887, 633);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.IsRequired = false;
            this.txtDiscount.Length = null;
            this.txtDiscount.Location = new System.Drawing.Point(618, 381);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(238, 35);
            this.txtDiscount.TabIndex = 19;
            this.txtDiscount.WritingType = SCMSControlsLib.cusTextBox.enWritingType.Numbers;
            // 
            // lblCreatedUser
            // 
            this.lblCreatedUser.AutoSize = true;
            this.lblCreatedUser.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedUser.ForeColor = System.Drawing.Color.Blue;
            this.lblCreatedUser.Location = new System.Drawing.Point(269, 585);
            this.lblCreatedUser.Name = "lblCreatedUser";
            this.lblCreatedUser.Size = new System.Drawing.Size(54, 36);
            this.lblCreatedUser.TabIndex = 18;
            this.lblCreatedUser.Text = "???";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(48, 585);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(206, 36);
            this.label11.TabIndex = 17;
            this.label11.Text = "Created User :";
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.AutoSize = true;
            this.lblCreatedDate.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedDate.ForeColor = System.Drawing.Color.Blue;
            this.lblCreatedDate.Location = new System.Drawing.Point(703, 521);
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.Size = new System.Drawing.Size(54, 36);
            this.lblCreatedDate.TabIndex = 16;
            this.lblCreatedDate.Text = "???";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(482, 521);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(209, 36);
            this.label10.TabIndex = 15;
            this.label10.Text = "Created Date :";
            // 
            // lblTotalRepairCost
            // 
            this.lblTotalRepairCost.AutoSize = true;
            this.lblTotalRepairCost.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRepairCost.ForeColor = System.Drawing.Color.Blue;
            this.lblTotalRepairCost.Location = new System.Drawing.Point(293, 521);
            this.lblTotalRepairCost.Name = "lblTotalRepairCost";
            this.lblTotalRepairCost.Size = new System.Drawing.Size(54, 36);
            this.lblTotalRepairCost.TabIndex = 14;
            this.lblTotalRepairCost.Text = "???";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(12, 521);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(265, 36);
            this.label8.TabIndex = 13;
            this.label8.Text = "Total Repair Cost :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(344, 378);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(272, 36);
            this.label7.TabIndex = 11;
            this.label7.Text = "Discount Amount :";
            // 
            // txtTaxAmount
            // 
            this.txtTaxAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxAmount.IsRequired = false;
            this.txtTaxAmount.Length = null;
            this.txtTaxAmount.Location = new System.Drawing.Point(624, 307);
            this.txtTaxAmount.Name = "txtTaxAmount";
            this.txtTaxAmount.Size = new System.Drawing.Size(238, 35);
            this.txtTaxAmount.TabIndex = 10;
            this.txtTaxAmount.WritingType = SCMSControlsLib.cusTextBox.enWritingType.Numbers;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(423, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 36);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tax Amount :";
            // 
            // txtAdditionalServices
            // 
            this.txtAdditionalServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdditionalServices.IsRequired = false;
            this.txtAdditionalServices.Length = null;
            this.txtAdditionalServices.Location = new System.Drawing.Point(322, 451);
            this.txtAdditionalServices.Name = "txtAdditionalServices";
            this.txtAdditionalServices.Size = new System.Drawing.Size(228, 35);
            this.txtAdditionalServices.TabIndex = 8;
            this.txtAdditionalServices.WritingType = SCMSControlsLib.cusTextBox.enWritingType.Numbers;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(15, 450);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(292, 36);
            this.label6.TabIndex = 7;
            this.label6.Text = "Additional Services :";
            // 
            // lblLaborCost
            // 
            this.lblLaborCost.AutoSize = true;
            this.lblLaborCost.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaborCost.ForeColor = System.Drawing.Color.Blue;
            this.lblLaborCost.Location = new System.Drawing.Point(219, 378);
            this.lblLaborCost.Name = "lblLaborCost";
            this.lblLaborCost.Size = new System.Drawing.Size(54, 36);
            this.lblLaborCost.TabIndex = 6;
            this.lblLaborCost.Text = "???";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(24, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 36);
            this.label5.TabIndex = 5;
            this.label5.Text = "Labor Cost :";
            // 
            // lblTotalPartsCost
            // 
            this.lblTotalPartsCost.AutoSize = true;
            this.lblTotalPartsCost.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPartsCost.ForeColor = System.Drawing.Color.Blue;
            this.lblTotalPartsCost.Location = new System.Drawing.Point(262, 308);
            this.lblTotalPartsCost.Name = "lblTotalPartsCost";
            this.lblTotalPartsCost.Size = new System.Drawing.Size(54, 36);
            this.lblTotalPartsCost.TabIndex = 4;
            this.lblTotalPartsCost.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(6, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total Parts Cost :";
            // 
            // ucShowUsedParts1
            // 
            this.ucShowUsedParts1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ucShowUsedParts1.Location = new System.Drawing.Point(-1, 2);
            this.ucShowUsedParts1.Name = "ucShowUsedParts1";
            this.ucShowUsedParts1.Size = new System.Drawing.Size(890, 262);
            this.ucShowUsedParts1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(25, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 64);
            this.label2.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.BorderColor = System.Drawing.Color.Gainsboro;
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
            this.btnClose.Location = new System.Drawing.Point(535, 720);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(156, 45);
            this.btnClose.TabIndex = 32;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderColor = System.Drawing.Color.WhiteSmoke;
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
            this.btnSave.Location = new System.Drawing.Point(714, 720);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(157, 45);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmSetRepairCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(891, 772);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSetRepairCost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set Repair Cost";
            this.Load += new System.EventHandler(this.frmSetRepairCost_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblLaborCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalPartsCost;
        private System.Windows.Forms.Label label3;
        private SCMSControlsLib.ucShowUsedParts ucShowUsedParts1;
        private System.Windows.Forms.Label label2;
        private SCMSControlsLib.cusTextBox txtTaxAmount;
        private System.Windows.Forms.Label label4;
        private SCMSControlsLib.cusTextBox txtAdditionalServices;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCreatedUser;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblCreatedDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTotalRepairCost;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private SCMSControlsLib.cusTextBox txtDiscount;
    }
}