namespace Service_Center_Management_System__SCMS_
{
    partial class frmAddEditRepairOrder
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
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ucSearchForDeviceWithAddEdit1 = new SCMSControlsLib.ucSearchForDeviceWithAddEdit();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ucSearchForATechnician1 = new SCMSControlsLib.ucSearchForATechnician();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lblCreatedDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUserCreated = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRepairOrderID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.llRemoveImage = new System.Windows.Forms.LinkLabel();
            this.llAddDeviceImage = new System.Windows.Forms.LinkLabel();
            this.cbPriority = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pbDeviceImage = new System.Windows.Forms.PictureBox();
            this.txtNotes = new SCMSControlsLib.cusTextBox();
            this.txtProblemDescription = new SCMSControlsLib.cusTextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeviceImage)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.guna2TabControl1.Controls.Add(this.tabPage2);
            this.guna2TabControl1.Controls.Add(this.tabPage3);
            this.guna2TabControl1.Controls.Add(this.tabPage4);
            this.guna2TabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(0, 52);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.ShowToolTips = true;
            this.guna2TabControl1.Size = new System.Drawing.Size(833, 709);
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ucSearchForDeviceWithAddEdit1);
            this.tabPage2.Location = new System.Drawing.Point(184, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(645, 701);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Device ID";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ucSearchForDeviceWithAddEdit1
            // 
            this.ucSearchForDeviceWithAddEdit1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ucSearchForDeviceWithAddEdit1.Location = new System.Drawing.Point(2, 48);
            this.ucSearchForDeviceWithAddEdit1.Name = "ucSearchForDeviceWithAddEdit1";
            this.ucSearchForDeviceWithAddEdit1.Size = new System.Drawing.Size(640, 607);
            this.ucSearchForDeviceWithAddEdit1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.ucSearchForATechnician1);
            this.tabPage3.Location = new System.Drawing.Point(184, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(645, 701);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Assigned Technician ID";
            // 
            // ucSearchForATechnician1
            // 
            this.ucSearchForATechnician1.gbEnabeld = true;
            this.ucSearchForATechnician1.Location = new System.Drawing.Point(81, -4);
            this.ucSearchForATechnician1.Name = "ucSearchForATechnician1";
            this.ucSearchForATechnician1.Size = new System.Drawing.Size(489, 700);
            this.ucSearchForATechnician1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage4.Controls.Add(this.lblCreatedDate);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.lblUserCreated);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.lblRepairOrderID);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.llRemoveImage);
            this.tabPage4.Controls.Add(this.llAddDeviceImage);
            this.tabPage4.Controls.Add(this.cbPriority);
            this.tabPage4.Controls.Add(this.pbDeviceImage);
            this.tabPage4.Controls.Add(this.txtNotes);
            this.tabPage4.Controls.Add(this.txtProblemDescription);
            this.tabPage4.Location = new System.Drawing.Point(184, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(645, 701);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Additional Information";
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.AutoSize = true;
            this.lblCreatedDate.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedDate.ForeColor = System.Drawing.Color.Black;
            this.lblCreatedDate.Location = new System.Drawing.Point(210, 577);
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.Size = new System.Drawing.Size(59, 27);
            this.lblCreatedDate.TabIndex = 63;
            this.lblCreatedDate.Text = "[???]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(46, 577);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 27);
            this.label2.TabIndex = 62;
            this.label2.Text = "Created Date :";
            // 
            // lblUserCreated
            // 
            this.lblUserCreated.AutoSize = true;
            this.lblUserCreated.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserCreated.ForeColor = System.Drawing.Color.Black;
            this.lblUserCreated.Location = new System.Drawing.Point(208, 526);
            this.lblUserCreated.Name = "lblUserCreated";
            this.lblUserCreated.Size = new System.Drawing.Size(59, 27);
            this.lblUserCreated.TabIndex = 61;
            this.lblUserCreated.Text = "[???]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(20, 526);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 27);
            this.label6.TabIndex = 60;
            this.label6.Text = "Created By User :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(9, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 27);
            this.label3.TabIndex = 59;
            this.label3.Text = "Notes :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(10, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 27);
            this.label1.TabIndex = 58;
            this.label1.Text = "Problem Description :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(88, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 27);
            this.label4.TabIndex = 57;
            this.label4.Text = "Priority :";
            // 
            // lblRepairOrderID
            // 
            this.lblRepairOrderID.AutoSize = true;
            this.lblRepairOrderID.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepairOrderID.ForeColor = System.Drawing.Color.Blue;
            this.lblRepairOrderID.Location = new System.Drawing.Point(251, 32);
            this.lblRepairOrderID.Name = "lblRepairOrderID";
            this.lblRepairOrderID.Size = new System.Drawing.Size(59, 27);
            this.lblRepairOrderID.TabIndex = 56;
            this.lblRepairOrderID.Text = "[???]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(22, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 27);
            this.label7.TabIndex = 55;
            this.label7.Text = "Repair Order ID :";
            // 
            // llRemoveImage
            // 
            this.llRemoveImage.AutoSize = true;
            this.llRemoveImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llRemoveImage.Location = new System.Drawing.Point(462, 265);
            this.llRemoveImage.Name = "llRemoveImage";
            this.llRemoveImage.Size = new System.Drawing.Size(112, 16);
            this.llRemoveImage.TabIndex = 54;
            this.llRemoveImage.TabStop = true;
            this.llRemoveImage.Text = "Remove Image";
            this.llRemoveImage.Visible = false;
            this.llRemoveImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llRemoveImage_LinkClicked);
            // 
            // llAddDeviceImage
            // 
            this.llAddDeviceImage.AutoSize = true;
            this.llAddDeviceImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llAddDeviceImage.Location = new System.Drawing.Point(415, 233);
            this.llAddDeviceImage.Name = "llAddDeviceImage";
            this.llAddDeviceImage.Size = new System.Drawing.Size(231, 16);
            this.llAddDeviceImage.TabIndex = 53;
            this.llAddDeviceImage.TabStop = true;
            this.llAddDeviceImage.Text = "Set Device Image Before Repair";
            this.llAddDeviceImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llAddDeviceImage_LinkClicked);
            // 
            // cbPriority
            // 
            this.cbPriority.BackColor = System.Drawing.Color.Transparent;
            this.cbPriority.BorderColor = System.Drawing.Color.White;
            this.cbPriority.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPriority.FillColor = System.Drawing.Color.Gainsboro;
            this.cbPriority.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPriority.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPriority.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPriority.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbPriority.ItemHeight = 30;
            this.cbPriority.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "Urgent"});
            this.cbPriority.Location = new System.Drawing.Point(187, 94);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(195, 36);
            this.cbPriority.TabIndex = 47;
            // 
            // pbDeviceImage
            // 
            this.pbDeviceImage.BackColor = System.Drawing.Color.White;
            this.pbDeviceImage.Image = global::Service_Center_Management_System__SCMS_.Properties.Resources.select;
            this.pbDeviceImage.Location = new System.Drawing.Point(438, 23);
            this.pbDeviceImage.Name = "pbDeviceImage";
            this.pbDeviceImage.Size = new System.Drawing.Size(177, 189);
            this.pbDeviceImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDeviceImage.TabIndex = 52;
            this.pbDeviceImage.TabStop = false;
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.IsRequired = false;
            this.txtNotes.Length = null;
            this.txtNotes.Location = new System.Drawing.Point(41, 392);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(341, 86);
            this.txtNotes.TabIndex = 51;
            this.txtNotes.WritingType = SCMSControlsLib.cusTextBox.enWritingType.None;
            // 
            // txtProblemDescription
            // 
            this.txtProblemDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProblemDescription.IsRequired = false;
            this.txtProblemDescription.Length = null;
            this.txtProblemDescription.Location = new System.Drawing.Point(32, 212);
            this.txtProblemDescription.Multiline = true;
            this.txtProblemDescription.Name = "txtProblemDescription";
            this.txtProblemDescription.Size = new System.Drawing.Size(350, 113);
            this.txtProblemDescription.TabIndex = 49;
            this.txtProblemDescription.WritingType = SCMSControlsLib.cusTextBox.enWritingType.None;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(206, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(376, 45);
            this.lblTitle.TabIndex = 29;
            this.lblTitle.Text = "Add Edit Repair Order";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            this.btnClose.Location = new System.Drawing.Point(485, 767);
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
            this.btnSave.Location = new System.Drawing.Point(664, 767);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(157, 45);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddEditRepairOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(833, 819);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.guna2TabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddEditRepairOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Edit Repair Order";
            this.Activated += new System.EventHandler(this.frmAddEditRepairOrder_Activated);
            this.Load += new System.EventHandler(this.frmAddEditRepairOrder_Load);
            this.guna2TabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeviceImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2ComboBox cbPriority;
        private SCMSControlsLib.ucSearchForDeviceWithAddEdit ucSearchForDeviceWithAddEdit1;
        private SCMSControlsLib.ucSearchForATechnician ucSearchForATechnician1;
        private SCMSControlsLib.cusTextBox txtNotes;
        private SCMSControlsLib.cusTextBox txtProblemDescription;
        private System.Windows.Forms.PictureBox pbDeviceImage;
        private System.Windows.Forms.LinkLabel llAddDeviceImage;
        private System.Windows.Forms.LinkLabel llRemoveImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRepairOrderID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCreatedDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUserCreated;
    }
}