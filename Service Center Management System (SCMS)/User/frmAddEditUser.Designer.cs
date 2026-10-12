namespace Service_Center_Management_System__SCMS_
{
    partial class frmAddEditUser
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
            this.components = new System.ComponentModel.Container();
            this.lblUserID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnSelectingEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtConfirmPassword = new ControlsLib.cusTextBox();
            this.txtPassword = new ControlsLib.cusTextBox();
            this.txtUsername = new ControlsLib.cusTextBox();
            this.lblCreatedDate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chbIsActive = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2GroupBox1.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.Color.Blue;
            this.lblUserID.Location = new System.Drawing.Point(366, 99);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(90, 38);
            this.lblUserID.TabIndex = 26;
            this.lblUserID.Text = "[???]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(309, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 30);
            this.label2.TabIndex = 25;
            this.label2.Text = "For";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(203, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 38);
            this.label1.TabIndex = 24;
            this.label1.Text = "User ID :";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(203, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(245, 45);
            this.lblTitle.TabIndex = 23;
            this.lblTitle.Text = "Add Edit User";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.btnSelectingEmployee);
            this.guna2GroupBox1.Controls.Add(this.lblEmployeeID);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(10, 171);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(646, 141);
            this.guna2GroupBox1.TabIndex = 27;
            this.guna2GroupBox1.Text = "Employee Assignment";
            // 
            // btnSelectingEmployee
            // 
            this.btnSelectingEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectingEmployee.BorderColor = System.Drawing.Color.White;
            this.btnSelectingEmployee.BorderRadius = 10;
            this.btnSelectingEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSelectingEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSelectingEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSelectingEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSelectingEmployee.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSelectingEmployee.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectingEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnSelectingEmployee.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSelectingEmployee.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSelectingEmployee.Location = new System.Drawing.Point(340, 66);
            this.btnSelectingEmployee.Name = "btnSelectingEmployee";
            this.btnSelectingEmployee.Size = new System.Drawing.Size(243, 45);
            this.btnSelectingEmployee.TabIndex = 30;
            this.btnSelectingEmployee.Text = "Select an Employee";
            this.btnSelectingEmployee.Click += new System.EventHandler(this.btnSelectingEmployee_Click);
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeID.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeID.ForeColor = System.Drawing.Color.Black;
            this.lblEmployeeID.Location = new System.Drawing.Point(191, 69);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(90, 38);
            this.lblEmployeeID.TabIndex = 29;
            this.lblEmployeeID.Text = "[???]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 24);
            this.label3.TabIndex = 28;
            this.label3.Text = "Employee ID :";
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Controls.Add(this.txtConfirmPassword);
            this.guna2GroupBox2.Controls.Add(this.txtPassword);
            this.guna2GroupBox2.Controls.Add(this.txtUsername);
            this.guna2GroupBox2.Controls.Add(this.lblCreatedDate);
            this.guna2GroupBox2.Controls.Add(this.label8);
            this.guna2GroupBox2.Controls.Add(this.chbIsActive);
            this.guna2GroupBox2.Controls.Add(this.label4);
            this.guna2GroupBox2.Controls.Add(this.label7);
            this.guna2GroupBox2.Controls.Add(this.label6);
            this.guna2GroupBox2.Controls.Add(this.label5);
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Location = new System.Drawing.Point(10, 314);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(646, 351);
            this.guna2GroupBox2.TabIndex = 28;
            this.guna2GroupBox2.Text = "User Information";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.IsRequired = true;
            this.txtConfirmPassword.Location = new System.Drawing.Point(242, 192);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '•';
            this.txtConfirmPassword.Size = new System.Drawing.Size(240, 33);
            this.txtConfirmPassword.TabIndex = 38;
            this.txtConfirmPassword.WritingType = ControlsLib.cusTextBox.enWritingType.None;
            // 
            // txtPassword
            // 
            this.txtPassword.IsRequired = true;
            this.txtPassword.Location = new System.Drawing.Point(241, 134);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(240, 33);
            this.txtPassword.TabIndex = 37;
            this.txtPassword.WritingType = ControlsLib.cusTextBox.enWritingType.None;
            // 
            // txtUsername
            // 
            this.txtUsername.IsRequired = true;
            this.txtUsername.Location = new System.Drawing.Point(241, 76);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(240, 33);
            this.txtUsername.TabIndex = 36;
            this.txtUsername.WritingType = ControlsLib.cusTextBox.enWritingType.None;
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.AutoSize = true;
            this.lblCreatedDate.BackColor = System.Drawing.Color.Transparent;
            this.lblCreatedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedDate.Location = new System.Drawing.Point(197, 308);
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.Size = new System.Drawing.Size(55, 24);
            this.lblCreatedDate.TabIndex = 35;
            this.lblCreatedDate.Text = "[???]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 24);
            this.label8.TabIndex = 34;
            this.label8.Text = "Created Date :";
            // 
            // chbIsActive
            // 
            this.chbIsActive.AutoSize = true;
            this.chbIsActive.BackColor = System.Drawing.Color.Transparent;
            this.chbIsActive.Checked = true;
            this.chbIsActive.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbIsActive.CheckedState.BorderRadius = 0;
            this.chbIsActive.CheckedState.BorderThickness = 0;
            this.chbIsActive.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbIsActive.Enabled = false;
            this.chbIsActive.Location = new System.Drawing.Point(181, 256);
            this.chbIsActive.Name = "chbIsActive";
            this.chbIsActive.Size = new System.Drawing.Size(85, 29);
            this.chbIsActive.TabIndex = 33;
            this.chbIsActive.Text = "Active";
            this.chbIsActive.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbIsActive.UncheckedState.BorderRadius = 0;
            this.chbIsActive.UncheckedState.BorderThickness = 0;
            this.chbIsActive.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbIsActive.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 24);
            this.label4.TabIndex = 32;
            this.label4.Text = "Is Active :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 24);
            this.label7.TabIndex = 31;
            this.label7.Text = "Confirm Password :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(94, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 24);
            this.label6.TabIndex = 30;
            this.label6.Text = "Password :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(88, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 24);
            this.label5.TabIndex = 28;
            this.label5.Text = "Username :";
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
            this.btnClose.Location = new System.Drawing.Point(314, 685);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(156, 45);
            this.btnClose.TabIndex = 30;
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
            this.btnSave.Location = new System.Drawing.Point(493, 685);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(157, 45);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(662, 742);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmAddEditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Edit User";
            this.Load += new System.EventHandler(this.frmAddEditUser_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnSelectingEmployee;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private ControlsLib.cusTextBox txtConfirmPassword;
        private ControlsLib.cusTextBox txtPassword;
        private ControlsLib.cusTextBox txtUsername;
        private System.Windows.Forms.Label lblCreatedDate;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2CheckBox chbIsActive;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}