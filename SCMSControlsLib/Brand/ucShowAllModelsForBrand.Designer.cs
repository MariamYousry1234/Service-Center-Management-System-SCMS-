namespace SCMSControlsLib
{
    partial class ucShowAllModelsForBrand
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
            this.gbAllModels = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvAllModels = new System.Windows.Forms.DataGridView();
            this.lblNumberOfModels = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbAllModels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllModels)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAllModels
            // 
            this.gbAllModels.Controls.Add(this.dgvAllModels);
            this.gbAllModels.Controls.Add(this.lblNumberOfModels);
            this.gbAllModels.Controls.Add(this.label1);
            this.gbAllModels.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAllModels.ForeColor = System.Drawing.Color.Black;
            this.gbAllModels.Location = new System.Drawing.Point(0, 0);
            this.gbAllModels.Name = "gbAllModels";
            this.gbAllModels.Size = new System.Drawing.Size(605, 289);
            this.gbAllModels.TabIndex = 1;
            this.gbAllModels.Text = "All Models For Brand =";
            // 
            // dgvAllModels
            // 
            this.dgvAllModels.AllowUserToAddRows = false;
            this.dgvAllModels.AllowUserToDeleteRows = false;
            this.dgvAllModels.AllowUserToOrderColumns = true;
            this.dgvAllModels.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAllModels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllModels.Location = new System.Drawing.Point(4, 60);
            this.dgvAllModels.Name = "dgvAllModels";
            this.dgvAllModels.ReadOnly = true;
            this.dgvAllModels.Size = new System.Drawing.Size(598, 175);
            this.dgvAllModels.TabIndex = 3;
            // 
            // lblNumberOfModels
            // 
            this.lblNumberOfModels.AutoSize = true;
            this.lblNumberOfModels.BackColor = System.Drawing.Color.Transparent;
            this.lblNumberOfModels.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfModels.ForeColor = System.Drawing.Color.Blue;
            this.lblNumberOfModels.Location = new System.Drawing.Point(271, 253);
            this.lblNumberOfModels.Name = "lblNumberOfModels";
            this.lblNumberOfModels.Size = new System.Drawing.Size(65, 32);
            this.lblNumberOfModels.TabIndex = 2;
            this.lblNumberOfModels.Text = "[???]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number Of Models :";
            // 
            // ucShowAllModelsForBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbAllModels);
            this.Name = "ucShowAllModelsForBrand";
            this.Size = new System.Drawing.Size(608, 293);
            this.gbAllModels.ResumeLayout(false);
            this.gbAllModels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllModels)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gbAllModels;
        private System.Windows.Forms.DataGridView dgvAllModels;
        private System.Windows.Forms.Label lblNumberOfModels;
        private System.Windows.Forms.Label label1;
    }
}
