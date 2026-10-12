namespace Service_Center_Management_System__SCMS_
{
    partial class frmShowAllDevicesForACustomer
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
            this.ucShowAllDevicesForACustomer1 = new SCMSControlsLib.ucShowAllDevicesForACustomer();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // ucShowAllDevicesForACustomer1
            // 
            this.ucShowAllDevicesForACustomer1.Location = new System.Drawing.Point(-2, -2);
            this.ucShowAllDevicesForACustomer1.Name = "ucShowAllDevicesForACustomer1";
            this.ucShowAllDevicesForACustomer1.Size = new System.Drawing.Size(1031, 286);
            this.ucShowAllDevicesForACustomer1.TabIndex = 1;
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
            this.btnClose.Location = new System.Drawing.Point(432, 293);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(156, 45);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmShowAllDevicesForACustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1019, 350);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ucShowAllDevicesForACustomer1);
            this.Name = "frmShowAllDevicesForACustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show All Devices For A Customer";
            this.Load += new System.EventHandler(this.frmShowAllDevicesForACustomer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private SCMSControlsLib.ucShowAllDevicesForACustomer ucShowAllDevicesForACustomer1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}