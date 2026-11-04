namespace SCMSControlsLib
{
    partial class ucShowAllAcountsForAnEmployee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbAllAccounts = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvAllAcounts = new System.Windows.Forms.DataGridView();
            this.lblNumberOfAccounts = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbAllAccounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllAcounts)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAllAccounts
            // 
            this.gbAllAccounts.Controls.Add(this.dgvAllAcounts);
            this.gbAllAccounts.Controls.Add(this.lblNumberOfAccounts);
            this.gbAllAccounts.Controls.Add(this.label1);
            this.gbAllAccounts.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAllAccounts.ForeColor = System.Drawing.Color.Red;
            this.gbAllAccounts.Location = new System.Drawing.Point(1, 1);
            this.gbAllAccounts.Name = "gbAllAccounts";
            this.gbAllAccounts.Size = new System.Drawing.Size(896, 376);
            this.gbAllAccounts.TabIndex = 0;
            this.gbAllAccounts.Text = "All Acounts ";
            // 
            // dgvAllAcounts
            // 
            this.dgvAllAcounts.AllowUserToAddRows = false;
            this.dgvAllAcounts.AllowUserToDeleteRows = false;
            this.dgvAllAcounts.AllowUserToOrderColumns = true;
            this.dgvAllAcounts.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAllAcounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllAcounts.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllAcounts.GridColor = System.Drawing.Color.Black;
            this.dgvAllAcounts.Location = new System.Drawing.Point(-2, 61);
            this.dgvAllAcounts.Name = "dgvAllAcounts";
            this.dgvAllAcounts.ReadOnly = true;
            this.dgvAllAcounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllAcounts.Size = new System.Drawing.Size(893, 258);
            this.dgvAllAcounts.TabIndex = 3;
            // 
            // lblNumberOfAccounts
            // 
            this.lblNumberOfAccounts.AutoSize = true;
            this.lblNumberOfAccounts.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfAccounts.ForeColor = System.Drawing.Color.Blue;
            this.lblNumberOfAccounts.Location = new System.Drawing.Point(303, 333);
            this.lblNumberOfAccounts.Name = "lblNumberOfAccounts";
            this.lblNumberOfAccounts.Size = new System.Drawing.Size(65, 32);
            this.lblNumberOfAccounts.TabIndex = 2;
            this.lblNumberOfAccounts.Text = "[???]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number Of Accounts :";
            // 
            // ucShowAllAcountsForAnEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.gbAllAccounts);
            this.Name = "ucShowAllAcountsForAnEmployee";
            this.Size = new System.Drawing.Size(898, 377);
            this.gbAllAccounts.ResumeLayout(false);
            this.gbAllAccounts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllAcounts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gbAllAccounts;
        private System.Windows.Forms.Label lblNumberOfAccounts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAllAcounts;
    }
}
