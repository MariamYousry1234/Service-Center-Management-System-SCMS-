namespace Service_Center_Management_System__SCMS_
{
    partial class frmAddEditDelivery
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblDeviceTypeName = new System.Windows.Forms.Label();
            this.llShowRepairOrderDetails = new System.Windows.Forms.LinkLabel();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.lblDeliveryID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.llRemoveImage = new System.Windows.Forms.LinkLabel();
            this.llSetImage = new System.Windows.Forms.LinkLabel();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.lblCreatedUser = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chkWarrantyEndDate = new System.Windows.Forms.CheckBox();
            this.lblDeliveryDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNotes = new SCMSControlsLib.cusTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpWarrantyEndDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblRepairOrderID = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnConfirm = new Guna.UI2.WinForms.Guna2Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(194, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(440, 63);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add Edit Delivery";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Repair Order ID :";
            // 
            // lblDeviceTypeName
            // 
            this.lblDeviceTypeName.AutoSize = true;
            this.lblDeviceTypeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeviceTypeName.ForeColor = System.Drawing.Color.Black;
            this.lblDeviceTypeName.Location = new System.Drawing.Point(252, 152);
            this.lblDeviceTypeName.Name = "lblDeviceTypeName";
            this.lblDeviceTypeName.Size = new System.Drawing.Size(63, 29);
            this.lblDeviceTypeName.TabIndex = 4;
            this.lblDeviceTypeName.Text = "[???]";
            // 
            // llShowRepairOrderDetails
            // 
            this.llShowRepairOrderDetails.AutoSize = true;
            this.llShowRepairOrderDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llShowRepairOrderDetails.Location = new System.Drawing.Point(337, 99);
            this.llShowRepairOrderDetails.Name = "llShowRepairOrderDetails";
            this.llShowRepairOrderDetails.Size = new System.Drawing.Size(197, 20);
            this.llShowRepairOrderDetails.TabIndex = 5;
            this.llShowRepairOrderDetails.TabStop = true;
            this.llShowRepairOrderDetails.Text = "Show Repair Order Details";
            this.llShowRepairOrderDetails.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowRepairOrderDetails_LinkClicked);
            // 
            // gbInfo
            // 
            this.gbInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbInfo.Controls.Add(this.lblDeliveryID);
            this.gbInfo.Controls.Add(this.label1);
            this.gbInfo.Controls.Add(this.llRemoveImage);
            this.gbInfo.Controls.Add(this.llSetImage);
            this.gbInfo.Controls.Add(this.pbImage);
            this.gbInfo.Controls.Add(this.lblCreatedUser);
            this.gbInfo.Controls.Add(this.label8);
            this.gbInfo.Controls.Add(this.chkWarrantyEndDate);
            this.gbInfo.Controls.Add(this.lblDeliveryDate);
            this.gbInfo.Controls.Add(this.label3);
            this.gbInfo.Controls.Add(this.lblCustomerName);
            this.gbInfo.Controls.Add(this.label7);
            this.gbInfo.Controls.Add(this.label6);
            this.gbInfo.Controls.Add(this.txtNotes);
            this.gbInfo.Controls.Add(this.label5);
            this.gbInfo.Controls.Add(this.dtpWarrantyEndDate);
            this.gbInfo.Controls.Add(this.label2);
            this.gbInfo.Controls.Add(this.llShowRepairOrderDetails);
            this.gbInfo.Controls.Add(this.lblRepairOrderID);
            this.gbInfo.Controls.Add(this.lblDeviceTypeName);
            this.gbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfo.Location = new System.Drawing.Point(6, 63);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(838, 485);
            this.gbInfo.TabIndex = 6;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Delivery Information";
            // 
            // lblDeliveryID
            // 
            this.lblDeliveryID.AutoSize = true;
            this.lblDeliveryID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryID.ForeColor = System.Drawing.Color.Blue;
            this.lblDeliveryID.Location = new System.Drawing.Point(232, 27);
            this.lblDeliveryID.Name = "lblDeliveryID";
            this.lblDeliveryID.Size = new System.Drawing.Size(68, 29);
            this.lblDeliveryID.TabIndex = 21;
            this.lblDeliveryID.Text = "[???]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(65, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "Delivery ID :";
            // 
            // llRemoveImage
            // 
            this.llRemoveImage.AutoSize = true;
            this.llRemoveImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llRemoveImage.Location = new System.Drawing.Point(648, 320);
            this.llRemoveImage.Name = "llRemoveImage";
            this.llRemoveImage.Size = new System.Drawing.Size(117, 20);
            this.llRemoveImage.TabIndex = 19;
            this.llRemoveImage.TabStop = true;
            this.llRemoveImage.Text = "Remove Image";
            this.llRemoveImage.Visible = false;
            this.llRemoveImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llRemoveImage_LinkClicked);
            // 
            // llSetImage
            // 
            this.llSetImage.AutoSize = true;
            this.llSetImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llSetImage.Location = new System.Drawing.Point(590, 281);
            this.llSetImage.Name = "llSetImage";
            this.llSetImage.Size = new System.Drawing.Size(225, 20);
            this.llSetImage.TabIndex = 18;
            this.llSetImage.TabStop = true;
            this.llSetImage.Text = "Set Device Image After Repair";
            this.llSetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llSetImage_LinkClicked);
            // 
            // pbImage
            // 
            this.pbImage.Image = global::Service_Center_Management_System__SCMS_.Properties.Resources.select;
            this.pbImage.Location = new System.Drawing.Point(620, 61);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(195, 193);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 17;
            this.pbImage.TabStop = false;
            // 
            // lblCreatedUser
            // 
            this.lblCreatedUser.AutoSize = true;
            this.lblCreatedUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedUser.ForeColor = System.Drawing.Color.Black;
            this.lblCreatedUser.Location = new System.Drawing.Point(567, 443);
            this.lblCreatedUser.Name = "lblCreatedUser";
            this.lblCreatedUser.Size = new System.Drawing.Size(63, 29);
            this.lblCreatedUser.TabIndex = 16;
            this.lblCreatedUser.Text = "[???]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(399, 444);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 29);
            this.label8.TabIndex = 15;
            this.label8.Text = "Created User :";
            // 
            // chkWarrantyEndDate
            // 
            this.chkWarrantyEndDate.AutoSize = true;
            this.chkWarrantyEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkWarrantyEndDate.Location = new System.Drawing.Point(16, 269);
            this.chkWarrantyEndDate.Name = "chkWarrantyEndDate";
            this.chkWarrantyEndDate.Size = new System.Drawing.Size(237, 33);
            this.chkWarrantyEndDate.TabIndex = 14;
            this.chkWarrantyEndDate.Text = "Warranty End Date ";
            this.chkWarrantyEndDate.UseVisualStyleBackColor = true;
            this.chkWarrantyEndDate.CheckedChanged += new System.EventHandler(this.chkWarrantyEndDate_CheckedChanged);
            // 
            // lblDeliveryDate
            // 
            this.lblDeliveryDate.AutoSize = true;
            this.lblDeliveryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryDate.ForeColor = System.Drawing.Color.Black;
            this.lblDeliveryDate.Location = new System.Drawing.Point(182, 444);
            this.lblDeliveryDate.Name = "lblDeliveryDate";
            this.lblDeliveryDate.Size = new System.Drawing.Size(63, 29);
            this.lblDeliveryDate.TabIndex = 13;
            this.lblDeliveryDate.Text = "[???]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(10, 445);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Delivery Date :";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.ForeColor = System.Drawing.Color.Black;
            this.lblCustomerName.Location = new System.Drawing.Point(230, 210);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(63, 29);
            this.lblCustomerName.TabIndex = 11;
            this.lblCustomerName.Text = "[???]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(15, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 29);
            this.label7.TabIndex = 10;
            this.label7.Text = "Customer Name :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(15, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "Device Type Name :";
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.IsRequired = false;
            this.txtNotes.Length = null;
            this.txtNotes.Location = new System.Drawing.Point(212, 336);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(386, 92);
            this.txtNotes.TabIndex = 8;
            this.txtNotes.WritingType = SCMSControlsLib.cusTextBox.enWritingType.None;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(15, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Delivery Notes :";
            // 
            // dtpWarrantyEndDate
            // 
            this.dtpWarrantyEndDate.Checked = true;
            this.dtpWarrantyEndDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtpWarrantyEndDate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpWarrantyEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpWarrantyEndDate.Location = new System.Drawing.Point(267, 269);
            this.dtpWarrantyEndDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpWarrantyEndDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpWarrantyEndDate.Name = "dtpWarrantyEndDate";
            this.dtpWarrantyEndDate.Size = new System.Drawing.Size(229, 36);
            this.dtpWarrantyEndDate.TabIndex = 6;
            this.dtpWarrantyEndDate.Value = new System.DateTime(2026, 10, 7, 13, 43, 29, 641);
            // 
            // lblRepairOrderID
            // 
            this.lblRepairOrderID.AutoSize = true;
            this.lblRepairOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepairOrderID.ForeColor = System.Drawing.Color.Black;
            this.lblRepairOrderID.Location = new System.Drawing.Point(233, 93);
            this.lblRepairOrderID.Name = "lblRepairOrderID";
            this.lblRepairOrderID.Size = new System.Drawing.Size(68, 29);
            this.lblRepairOrderID.TabIndex = 2;
            this.lblRepairOrderID.Text = "[???]";
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
            this.btnClose.Location = new System.Drawing.Point(489, 554);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(165, 45);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirm.BorderColor = System.Drawing.Color.White;
            this.btnConfirm.BorderRadius = 10;
            this.btnConfirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConfirm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.Black;
            this.btnConfirm.Image = global::Service_Center_Management_System__SCMS_.Properties.Resources.touch_screen1;
            this.btnConfirm.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnConfirm.Location = new System.Drawing.Point(675, 554);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(166, 45);
            this.btnConfirm.TabIndex = 22;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmAddEditDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(853, 606);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.lblTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddEditDelivery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Edit Delivery";
            this.Load += new System.EventHandler(this.frmAddEditDelivery_Load);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDeviceTypeName;
        private System.Windows.Forms.LinkLabel llShowRepairOrderDetails;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private SCMSControlsLib.cusTextBox txtNotes;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpWarrantyEndDate;
        private System.Windows.Forms.Label lblCreatedUser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkWarrantyEndDate;
        private System.Windows.Forms.Label lblDeliveryDate;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnConfirm;
        private System.Windows.Forms.LinkLabel llRemoveImage;
        private System.Windows.Forms.LinkLabel llSetImage;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblDeliveryID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRepairOrderID;
    }
}