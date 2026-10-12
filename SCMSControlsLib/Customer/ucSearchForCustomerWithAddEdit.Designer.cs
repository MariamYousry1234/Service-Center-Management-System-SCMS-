namespace SCMSControlsLib
{
    partial class ucSearchForCustomerWithAddEdit
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
            this.ucSearchForCustomer1 = new SCMSControlsLib.ucSearchForCustomer();
            this.btnAddEditCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.lblSep2 = new System.Windows.Forms.Label();
            this.lblOr = new System.Windows.Forms.Label();
            this.lblSep1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ucSearchForCustomer1
            // 
            this.ucSearchForCustomer1.Location = new System.Drawing.Point(-4, 0);
            this.ucSearchForCustomer1.Name = "ucSearchForCustomer1";
            this.ucSearchForCustomer1.Size = new System.Drawing.Size(597, 686);
            this.ucSearchForCustomer1.TabIndex = 0;
            // 
            // btnAddEditCustomer
            // 
            this.btnAddEditCustomer.BackColor = System.Drawing.Color.Transparent;
            this.btnAddEditCustomer.BorderColor = System.Drawing.Color.White;
            this.btnAddEditCustomer.BorderRadius = 10;
            this.btnAddEditCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddEditCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddEditCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddEditCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddEditCustomer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAddEditCustomer.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEditCustomer.ForeColor = System.Drawing.Color.Black;
            this.btnAddEditCustomer.HoverState.CustomBorderColor = System.Drawing.Color.Red;
            this.btnAddEditCustomer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAddEditCustomer.Location = new System.Drawing.Point(161, 729);
            this.btnAddEditCustomer.Name = "btnAddEditCustomer";
            this.btnAddEditCustomer.Size = new System.Drawing.Size(268, 45);
            this.btnAddEditCustomer.TabIndex = 16;
            this.btnAddEditCustomer.Text = "Add New Customer";
            this.btnAddEditCustomer.Click += new System.EventHandler(this.btnAddEditCustomer_Click);
            // 
            // lblSep2
            // 
            this.lblSep2.AutoSize = true;
            this.lblSep2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSep2.ForeColor = System.Drawing.Color.Blue;
            this.lblSep2.Location = new System.Drawing.Point(311, 699);
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
            this.lblOr.Location = new System.Drawing.Point(268, 689);
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
            this.lblSep1.Location = new System.Drawing.Point(197, 699);
            this.lblSep1.Name = "lblSep1";
            this.lblSep1.Size = new System.Drawing.Size(76, 25);
            this.lblSep1.TabIndex = 17;
            this.lblSep1.Text = "--------";
            // 
            // ucSearchForCustomerWithAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.btnAddEditCustomer);
            this.Controls.Add(this.lblSep2);
            this.Controls.Add(this.lblOr);
            this.Controls.Add(this.lblSep1);
            this.Controls.Add(this.ucSearchForCustomer1);
            this.Name = "ucSearchForCustomerWithAddEdit";
            this.Size = new System.Drawing.Size(594, 784);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ucSearchForCustomer ucSearchForCustomer1;
        private Guna.UI2.WinForms.Guna2Button btnAddEditCustomer;
        private System.Windows.Forms.Label lblSep2;
        private System.Windows.Forms.Label lblOr;
        private System.Windows.Forms.Label lblSep1;
    }
}
