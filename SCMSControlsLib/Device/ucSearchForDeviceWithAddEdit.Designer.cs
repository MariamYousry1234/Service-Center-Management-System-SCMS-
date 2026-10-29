namespace SCMSControlsLib
{
    partial class ucSearchForDeviceWithAddEdit
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddEditDevice = new Guna.UI2.WinForms.Guna2Button();
            this.lblSep2 = new System.Windows.Forms.Label();
            this.lblOr = new System.Windows.Forms.Label();
            this.lblSep1 = new System.Windows.Forms.Label();
            this.ucSearchForADevice1 = new SCMSControlsLib.ucSearchForADevice();
            this.SuspendLayout();
            // 
            // btnAddEditDevice
            // 
            this.btnAddEditDevice.BackColor = System.Drawing.Color.Transparent;
            this.btnAddEditDevice.BorderColor = System.Drawing.Color.White;
            this.btnAddEditDevice.BorderRadius = 10;
            this.btnAddEditDevice.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddEditDevice.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddEditDevice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddEditDevice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddEditDevice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAddEditDevice.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEditDevice.ForeColor = System.Drawing.Color.Black;
            this.btnAddEditDevice.HoverState.CustomBorderColor = System.Drawing.Color.Red;
            this.btnAddEditDevice.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAddEditDevice.Location = new System.Drawing.Point(191, 549);
            this.btnAddEditDevice.Name = "btnAddEditDevice";
            this.btnAddEditDevice.Size = new System.Drawing.Size(268, 45);
            this.btnAddEditDevice.TabIndex = 16;
            this.btnAddEditDevice.Text = "Add New Device";
            this.btnAddEditDevice.Click += new System.EventHandler(this.btnAddEditDevice_Click);
            // 
            // lblSep2
            // 
            this.lblSep2.AutoSize = true;
            this.lblSep2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSep2.ForeColor = System.Drawing.Color.Blue;
            this.lblSep2.Location = new System.Drawing.Point(333, 519);
            this.lblSep2.Name = "lblSep2";
            this.lblSep2.Size = new System.Drawing.Size(76, 25);
            this.lblSep2.TabIndex = 19;
            this.lblSep2.Text = "--------";
            // 
            // lblOr
            // 
            this.lblOr.AutoSize = true;
            this.lblOr.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOr.ForeColor = System.Drawing.Color.Blue;
            this.lblOr.Location = new System.Drawing.Point(290, 509);
            this.lblOr.Name = "lblOr";
            this.lblOr.Size = new System.Drawing.Size(54, 37);
            this.lblOr.TabIndex = 18;
            this.lblOr.Text = "Or";
            // 
            // lblSep1
            // 
            this.lblSep1.AutoSize = true;
            this.lblSep1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSep1.ForeColor = System.Drawing.Color.Blue;
            this.lblSep1.Location = new System.Drawing.Point(219, 519);
            this.lblSep1.Name = "lblSep1";
            this.lblSep1.Size = new System.Drawing.Size(76, 25);
            this.lblSep1.TabIndex = 17;
            this.lblSep1.Text = "--------";
            // 
            // ucSearchForADevice1
            // 
            this.ucSearchForADevice1.gbEnabled = true;
            this.ucSearchForADevice1.Location = new System.Drawing.Point(0, -1);
            this.ucSearchForADevice1.Name = "ucSearchForADevice1";
            this.ucSearchForADevice1.Size = new System.Drawing.Size(671, 501);
            this.ucSearchForADevice1.TabIndex = 0;
            // 
            // ucSearchForDeviceWithAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.btnAddEditDevice);
            this.Controls.Add(this.lblSep2);
            this.Controls.Add(this.lblOr);
            this.Controls.Add(this.lblSep1);
            this.Controls.Add(this.ucSearchForADevice1);
            this.Name = "ucSearchForDeviceWithAddEdit";
            this.Size = new System.Drawing.Size(670, 605);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnAddEditDevice;
        private System.Windows.Forms.Label lblSep2;
        private System.Windows.Forms.Label lblOr;
        private System.Windows.Forms.Label lblSep1;
        private ucSearchForADevice ucSearchForADevice1;
    }
}
