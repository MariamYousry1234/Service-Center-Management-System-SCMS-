namespace SCMSControlsLib
{
    partial class ucShowRepairOrderHistory
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
            this.gbAllHistory = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvAllChanges = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.gbAllHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllChanges)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAllHistory
            // 
            this.gbAllHistory.Controls.Add(this.dgvAllChanges);
            this.gbAllHistory.Controls.Add(this.label1);
            this.gbAllHistory.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAllHistory.ForeColor = System.Drawing.Color.Black;
            this.gbAllHistory.Location = new System.Drawing.Point(0, -1);
            this.gbAllHistory.Name = "gbAllHistory";
            this.gbAllHistory.Size = new System.Drawing.Size(1090, 267);
            this.gbAllHistory.TabIndex = 3;
            this.gbAllHistory.Text = "History For RepairOrderID = [???] ";
            // 
            // dgvAllChanges
            // 
            this.dgvAllChanges.AllowUserToAddRows = false;
            this.dgvAllChanges.AllowUserToDeleteRows = false;
            this.dgvAllChanges.AllowUserToOrderColumns = true;
            this.dgvAllChanges.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAllChanges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllChanges.Location = new System.Drawing.Point(1, 52);
            this.dgvAllChanges.Name = "dgvAllChanges";
            this.dgvAllChanges.ReadOnly = true;
            this.dgvAllChanges.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllChanges.Size = new System.Drawing.Size(1086, 205);
            this.dgvAllChanges.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 32);
            this.label1.TabIndex = 1;
            // 
            // ucShowRepairOrderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbAllHistory);
            this.Name = "ucShowRepairOrderHistory";
            this.Size = new System.Drawing.Size(1090, 267);
            this.gbAllHistory.ResumeLayout(false);
            this.gbAllHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllChanges)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gbAllHistory;
        private System.Windows.Forms.DataGridView dgvAllChanges;
        private System.Windows.Forms.Label label1;
    }
}
