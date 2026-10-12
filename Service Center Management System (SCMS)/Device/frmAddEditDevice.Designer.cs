namespace Service_Center_Management_System__SCMS_
{
    partial class frmAddEditDevice
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ucSearchForCustomerWithAddEdit1 = new SCMSControlsLib.ucSearchForCustomerWithAddEdit();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbColor = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSerialNumber = new ControlsLib.cusTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbModelName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbBrandName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDeviceType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCreatedDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblUserCreated = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDeviceID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.guna2TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.guna2TabControl1.Controls.Add(this.tabPage1);
            this.guna2TabControl1.Controls.Add(this.tabPage2);
            this.guna2TabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(0, 56);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.ShowToolTips = true;
            this.guna2TabControl1.Size = new System.Drawing.Size(775, 799);
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
            this.tabPage1.Controls.Add(this.ucSearchForCustomerWithAddEdit1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(184, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(587, 791);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customer ID";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ucSearchForCustomerWithAddEdit1
            // 
            this.ucSearchForCustomerWithAddEdit1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ucSearchForCustomerWithAddEdit1.Location = new System.Drawing.Point(-7, 1);
            this.ucSearchForCustomerWithAddEdit1.Name = "ucSearchForCustomerWithAddEdit1";
            this.ucSearchForCustomerWithAddEdit1.Size = new System.Drawing.Size(594, 784);
            this.ucSearchForCustomerWithAddEdit1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbColor);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtSerialNumber);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.cbModelName);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.cbBrandName);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.cbDeviceType);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.lblCreatedDate);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.lblUserCreated);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.lblDeviceID);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(184, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(587, 791);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Additional Information";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbColor
            // 
            this.cbColor.BackColor = System.Drawing.Color.Transparent;
            this.cbColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColor.FillColor = System.Drawing.Color.LightGray;
            this.cbColor.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbColor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbColor.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbColor.ItemHeight = 30;
            this.cbColor.Items.AddRange(new object[] {
            "Black ",
            "White ",
            "Silver",
            "Gray",
            "Blue",
            "Red",
            "Green ",
            "Yellow",
            "Orange",
            "Purple ",
            "Pink",
            "Gold ",
            "Brown ",
            "Beige ",
            "Bronze",
            "NavyBlue ",
            "DarkGray ",
            "LightGray ",
            "Other"});
            this.cbColor.Location = new System.Drawing.Point(280, 534);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(274, 36);
            this.cbColor.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(131, 533);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 38);
            this.label8.TabIndex = 46;
            this.label8.Text = "Color :";
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerialNumber.IsRequired = true;
            this.txtSerialNumber.Location = new System.Drawing.Point(280, 447);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(274, 35);
            this.txtSerialNumber.TabIndex = 45;
            this.txtSerialNumber.WritingType = ControlsLib.cusTextBox.enWritingType.None;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(4, 445);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(245, 38);
            this.label7.TabIndex = 44;
            this.label7.Text = "Serial Number :";
            // 
            // cbModelName
            // 
            this.cbModelName.BackColor = System.Drawing.Color.Transparent;
            this.cbModelName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbModelName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbModelName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModelName.FillColor = System.Drawing.Color.LightGray;
            this.cbModelName.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbModelName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbModelName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbModelName.ItemHeight = 30;
            this.cbModelName.Location = new System.Drawing.Point(280, 359);
            this.cbModelName.Name = "cbModelName";
            this.cbModelName.Size = new System.Drawing.Size(274, 36);
            this.cbModelName.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(31, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 38);
            this.label6.TabIndex = 42;
            this.label6.Text = "Model Name :";
            // 
            // cbBrandName
            // 
            this.cbBrandName.BackColor = System.Drawing.Color.Transparent;
            this.cbBrandName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbBrandName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbBrandName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBrandName.FillColor = System.Drawing.Color.LightGray;
            this.cbBrandName.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbBrandName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbBrandName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBrandName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbBrandName.ItemHeight = 30;
            this.cbBrandName.Location = new System.Drawing.Point(280, 271);
            this.cbBrandName.Name = "cbBrandName";
            this.cbBrandName.Size = new System.Drawing.Size(274, 36);
            this.cbBrandName.TabIndex = 41;
            this.cbBrandName.SelectedIndexChanged += new System.EventHandler(this.cbBrandName_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(28, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 38);
            this.label3.TabIndex = 40;
            this.label3.Text = "Brand Name :";
            // 
            // cbDeviceType
            // 
            this.cbDeviceType.BackColor = System.Drawing.Color.Transparent;
            this.cbDeviceType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbDeviceType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDeviceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDeviceType.FillColor = System.Drawing.Color.LightGray;
            this.cbDeviceType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDeviceType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDeviceType.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDeviceType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbDeviceType.ItemHeight = 30;
            this.cbDeviceType.Location = new System.Drawing.Point(280, 183);
            this.cbDeviceType.Name = "cbDeviceType";
            this.cbDeviceType.Size = new System.Drawing.Size(274, 36);
            this.cbDeviceType.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(27, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 38);
            this.label1.TabIndex = 38;
            this.label1.Text = "Device Type :";
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.AutoSize = true;
            this.lblCreatedDate.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedDate.ForeColor = System.Drawing.Color.Black;
            this.lblCreatedDate.Location = new System.Drawing.Point(320, 712);
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.Size = new System.Drawing.Size(90, 38);
            this.lblCreatedDate.TabIndex = 37;
            this.lblCreatedDate.Text = "[???]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(43, 709);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 38);
            this.label5.TabIndex = 36;
            this.label5.Text = "Created Date :";
            // 
            // lblUserCreated
            // 
            this.lblUserCreated.AutoSize = true;
            this.lblUserCreated.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserCreated.ForeColor = System.Drawing.Color.Black;
            this.lblUserCreated.Location = new System.Drawing.Point(320, 622);
            this.lblUserCreated.Name = "lblUserCreated";
            this.lblUserCreated.Size = new System.Drawing.Size(90, 38);
            this.lblUserCreated.TabIndex = 35;
            this.lblUserCreated.Text = "[???]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 621);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 38);
            this.label2.TabIndex = 34;
            this.label2.Text = "Created By User :";
            // 
            // lblDeviceID
            // 
            this.lblDeviceID.AutoSize = true;
            this.lblDeviceID.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeviceID.ForeColor = System.Drawing.Color.Blue;
            this.lblDeviceID.Location = new System.Drawing.Point(312, 39);
            this.lblDeviceID.Name = "lblDeviceID";
            this.lblDeviceID.Size = new System.Drawing.Size(90, 38);
            this.lblDeviceID.TabIndex = 33;
            this.lblDeviceID.Text = "[???]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(71, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 38);
            this.label4.TabIndex = 32;
            this.label4.Text = "Device ID :";
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
            this.btnClose.Location = new System.Drawing.Point(433, 861);
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
            this.btnSave.Location = new System.Drawing.Point(605, 861);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(157, 45);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(242, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(272, 45);
            this.lblTitle.TabIndex = 29;
            this.lblTitle.Text = "Add Edit Device";
            // 
            // frmAddEditDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(769, 911);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.guna2TabControl1);
            this.Name = "frmAddEditDevice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Edit Device";
            this.Load += new System.EventHandler(this.frmAddEditDevice_Load);
            this.guna2TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Guna.UI2.WinForms.Guna2ComboBox cbDeviceType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCreatedDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblUserCreated;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDeviceID;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Label lblTitle;
        private SCMSControlsLib.ucSearchForCustomerWithAddEdit ucSearchForCustomerWithAddEdit1;
        private ControlsLib.cusTextBox txtSerialNumber;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox cbModelName;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox cbBrandName;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cbColor;
        private System.Windows.Forms.Label label8;
    }
}