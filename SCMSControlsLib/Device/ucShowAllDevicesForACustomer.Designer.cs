namespace SCMSControlsLib
{
    partial class ucShowAllDevicesForACustomer
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
            this.gbAllDevices = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvAllDevices = new System.Windows.Forms.DataGridView();
            this.lblNumberOfDevices = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbAllDevices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllDevices)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAllDevices
            // 
            this.gbAllDevices.Controls.Add(this.dgvAllDevices);
            this.gbAllDevices.Controls.Add(this.lblNumberOfDevices);
            this.gbAllDevices.Controls.Add(this.label1);
            this.gbAllDevices.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAllDevices.ForeColor = System.Drawing.Color.Black;
            this.gbAllDevices.Location = new System.Drawing.Point(1, 1);
            this.gbAllDevices.Name = "gbAllDevices";
            this.gbAllDevices.Size = new System.Drawing.Size(1022, 289);
            this.gbAllDevices.TabIndex = 1;
            this.gbAllDevices.Text = "All Devices For Customer ID =[???]";
            // 
            // dgvAllDevices
            // 
            this.dgvAllDevices.AllowUserToAddRows = false;
            this.dgvAllDevices.AllowUserToDeleteRows = false;
            this.dgvAllDevices.AllowUserToOrderColumns = true;
            this.dgvAllDevices.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAllDevices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllDevices.Location = new System.Drawing.Point(0, 60);
            this.dgvAllDevices.Name = "dgvAllDevices";
            this.dgvAllDevices.ReadOnly = true;
            this.dgvAllDevices.Size = new System.Drawing.Size(1019, 175);
            this.dgvAllDevices.TabIndex = 3;
            // 
            // lblNumberOfDevices
            // 
            this.lblNumberOfDevices.AutoSize = true;
            this.lblNumberOfDevices.BackColor = System.Drawing.Color.Transparent;
            this.lblNumberOfDevices.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfDevices.ForeColor = System.Drawing.Color.Blue;
            this.lblNumberOfDevices.Location = new System.Drawing.Point(277, 253);
            this.lblNumberOfDevices.Name = "lblNumberOfDevices";
            this.lblNumberOfDevices.Size = new System.Drawing.Size(65, 32);
            this.lblNumberOfDevices.TabIndex = 2;
            this.lblNumberOfDevices.Text = "[???]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number Of Devices :";
            // 
            // ucShowAllDevicesForACustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbAllDevices);
            this.Name = "ucShowAllDevicesForACustomer";
            this.Size = new System.Drawing.Size(1026, 286);
            this.gbAllDevices.ResumeLayout(false);
            this.gbAllDevices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllDevices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gbAllDevices;
        private System.Windows.Forms.DataGridView dgvAllDevices;
        private System.Windows.Forms.Label lblNumberOfDevices;
        private System.Windows.Forms.Label label1;
    }
}
