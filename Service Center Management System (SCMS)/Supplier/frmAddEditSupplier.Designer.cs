namespace Service_Center_Management_System__SCMS_
{
    partial class frmAddEditSupplier
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
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.gbInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtAddress = new SCMSControlsLib.cusTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new SCMSControlsLib.cusTextBox();
            this.chkIsActive = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSupplierName = new SCMSControlsLib.cusTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSupplierID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbInfo.SuspendLayout();
            this.SuspendLayout();
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
            this.btnCancel.Location = new System.Drawing.Point(408, 474);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(156, 45);
            this.btnCancel.TabIndex = 44;
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
            this.btnSave.Location = new System.Drawing.Point(587, 475);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(157, 45);
            this.btnSave.TabIndex = 43;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.txtAddress);
            this.gbInfo.Controls.Add(this.label3);
            this.gbInfo.Controls.Add(this.txtPhoneNumber);
            this.gbInfo.Controls.Add(this.chkIsActive);
            this.gbInfo.Controls.Add(this.label9);
            this.gbInfo.Controls.Add(this.label5);
            this.gbInfo.Controls.Add(this.txtSupplierName);
            this.gbInfo.Controls.Add(this.label2);
            this.gbInfo.Controls.Add(this.lblSupplierID);
            this.gbInfo.Controls.Add(this.label1);
            this.gbInfo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfo.ForeColor = System.Drawing.Color.Black;
            this.gbInfo.Location = new System.Drawing.Point(11, 84);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(736, 360);
            this.gbInfo.TabIndex = 42;
            this.gbInfo.Text = "Add Edit Supplier";
            // 
            // txtAddress
            // 
            this.txtAddress.IsRequired = false;
            this.txtAddress.Length = null;
            this.txtAddress.Location = new System.Drawing.Point(291, 291);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(341, 39);
            this.txtAddress.TabIndex = 20;
            this.txtAddress.WritingType = SCMSControlsLib.cusTextBox.enWritingType.None;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 32);
            this.label3.TabIndex = 19;
            this.label3.Text = "Address :";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.IsRequired = true;
            this.txtPhoneNumber.Length = 11;
            this.txtPhoneNumber.Location = new System.Drawing.Point(288, 206);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(267, 39);
            this.txtPhoneNumber.TabIndex = 18;
            this.txtPhoneNumber.WritingType = SCMSControlsLib.cusTextBox.enWritingType.Numbers;
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkIsActive.CheckedState.BorderRadius = 0;
            this.chkIsActive.CheckedState.BorderThickness = 0;
            this.chkIsActive.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkIsActive.Enabled = false;
            this.chkIsActive.Location = new System.Drawing.Point(567, 56);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(130, 36);
            this.chkIsActive.TabIndex = 17;
            this.chkIsActive.Text = "Is Active";
            this.chkIsActive.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkIsActive.UncheckedState.BorderRadius = 0;
            this.chkIsActive.UncheckedState.BorderThickness = 0;
            this.chkIsActive.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(409, 561);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 32);
            this.label9.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phone Number :";
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.IsRequired = true;
            this.txtSupplierName.Length = null;
            this.txtSupplierName.Location = new System.Drawing.Point(286, 122);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(267, 39);
            this.txtSupplierName.TabIndex = 3;
            this.txtSupplierName.WritingType = SCMSControlsLib.cusTextBox.enWritingType.None;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Supplier Name : ";
            // 
            // lblSupplierID
            // 
            this.lblSupplierID.AutoSize = true;
            this.lblSupplierID.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierID.ForeColor = System.Drawing.Color.Red;
            this.lblSupplierID.Location = new System.Drawing.Point(297, 54);
            this.lblSupplierID.Name = "lblSupplierID";
            this.lblSupplierID.Size = new System.Drawing.Size(64, 32);
            this.lblSupplierID.TabIndex = 1;
            this.lblSupplierID.Text = "[???]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supplier ID : ";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(150, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(422, 56);
            this.lblTitle.TabIndex = 41;
            this.lblTitle.Text = "Add Edit Supplier";
            // 
            // frmAddEditSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(757, 537);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmAddEditSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Edit Supplier";
            this.Load += new System.EventHandler(this.frmAddEditSupplier_Load);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2GroupBox gbInfo;
        private SCMSControlsLib.cusTextBox txtPhoneNumber;
        private Guna.UI2.WinForms.Guna2CheckBox chkIsActive;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private SCMSControlsLib.cusTextBox txtSupplierName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSupplierID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private SCMSControlsLib.cusTextBox txtAddress;
        private System.Windows.Forms.Label label3;
    }
}