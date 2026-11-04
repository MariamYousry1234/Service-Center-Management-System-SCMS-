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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbAllModels = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvAllModels = new System.Windows.Forms.DataGridView();
            this.lblNumberOfModels = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbAllModels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllModels)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAllModels
            // 
            this.gbAllModels.Controls.Add(this.dgvAllModels);
            this.gbAllModels.Controls.Add(this.lblNumberOfModels);
            this.gbAllModels.Controls.Add(this.label1);
            this.gbAllModels.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAllModels.ForeColor = System.Drawing.Color.Red;
            this.gbAllModels.Location = new System.Drawing.Point(0, 0);
            this.gbAllModels.Name = "gbAllModels";
            this.gbAllModels.Size = new System.Drawing.Size(673, 440);
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
            this.dgvAllModels.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllModels.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllModels.Location = new System.Drawing.Point(4, 58);
            this.dgvAllModels.Name = "dgvAllModels";
            this.dgvAllModels.ReadOnly = true;
            this.dgvAllModels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllModels.Size = new System.Drawing.Size(665, 336);
            this.dgvAllModels.TabIndex = 3;
            // 
            // lblNumberOfModels
            // 
            this.lblNumberOfModels.AutoSize = true;
            this.lblNumberOfModels.BackColor = System.Drawing.Color.Transparent;
            this.lblNumberOfModels.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfModels.ForeColor = System.Drawing.Color.Blue;
            this.lblNumberOfModels.Location = new System.Drawing.Point(256, 401);
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
            this.label1.Location = new System.Drawing.Point(3, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number Of Models :";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteModelToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // deleteModelToolStripMenuItem
            // 
            this.deleteModelToolStripMenuItem.Image = global::SCMSControlsLib.Properties.Resources.delete;
            this.deleteModelToolStripMenuItem.Name = "deleteModelToolStripMenuItem";
            this.deleteModelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteModelToolStripMenuItem.Text = "Delete Model";
            this.deleteModelToolStripMenuItem.Click += new System.EventHandler(this.deleteModelToolStripMenuItem_Click);
            // 
            // ucShowAllModelsForBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbAllModels);
            this.Name = "ucShowAllModelsForBrand";
            this.Size = new System.Drawing.Size(675, 443);
            this.gbAllModels.ResumeLayout(false);
            this.gbAllModels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllModels)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gbAllModels;
        private System.Windows.Forms.DataGridView dgvAllModels;
        private System.Windows.Forms.Label lblNumberOfModels;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteModelToolStripMenuItem;
    }
}
