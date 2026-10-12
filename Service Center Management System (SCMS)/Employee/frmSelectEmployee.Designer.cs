namespace Service_Center_Management_System__SCMS_
{
    partial class frmSelectEmployee
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
            this.ucSearchForAnEmployee1 = new SCMSControlsLib.ucSearchForAnEmployee();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnSelect = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // ucSearchForAnEmployee1
            // 
            this.ucSearchForAnEmployee1.gbEnabled = true;
            this.ucSearchForAnEmployee1.Location = new System.Drawing.Point(-3, 0);
            this.ucSearchForAnEmployee1.Name = "ucSearchForAnEmployee1";
            this.ucSearchForAnEmployee1.Size = new System.Drawing.Size(599, 574);
            this.ucSearchForAnEmployee1.TabIndex = 0;
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
            this.btnClose.FillColor = System.Drawing.Color.Gainsboro;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Image = global::Service_Center_Management_System__SCMS_.Properties.Resources.close;
            this.btnClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClose.Location = new System.Drawing.Point(246, 580);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(156, 45);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "Cancel";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.Transparent;
            this.btnSelect.BorderColor = System.Drawing.Color.White;
            this.btnSelect.BorderRadius = 10;
            this.btnSelect.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSelect.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSelect.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSelect.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSelect.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.Color.Black;
            this.btnSelect.Image = global::Service_Center_Management_System__SCMS_.Properties.Resources.check;
            this.btnSelect.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSelect.Location = new System.Drawing.Point(425, 580);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(157, 45);
            this.btnSelect.TabIndex = 22;
            this.btnSelect.Text = "Select";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // frmSelectEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(591, 635);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.ucSearchForAnEmployee1);
            this.Name = "frmSelectEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Employee";
            this.ResumeLayout(false);

        }

        #endregion

        private SCMSControlsLib.ucSearchForAnEmployee ucSearchForAnEmployee1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnSelect;
    }
}