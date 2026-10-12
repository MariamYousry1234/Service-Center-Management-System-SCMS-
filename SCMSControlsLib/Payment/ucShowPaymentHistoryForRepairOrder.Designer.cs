namespace SCMSControlsLib
{
    partial class ucShowPaymentHistoryForRepairOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumberOfPayments = new System.Windows.Forms.Label();
            this.gbAllPayments = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvAllPayments = new System.Windows.Forms.DataGridView();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbAllPayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllPayments)).BeginInit();
            this.guna2ContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number Of Payments :";
            // 
            // lblNumberOfPayments
            // 
            this.lblNumberOfPayments.AutoSize = true;
            this.lblNumberOfPayments.BackColor = System.Drawing.Color.Transparent;
            this.lblNumberOfPayments.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfPayments.ForeColor = System.Drawing.Color.Blue;
            this.lblNumberOfPayments.Location = new System.Drawing.Point(284, 250);
            this.lblNumberOfPayments.Name = "lblNumberOfPayments";
            this.lblNumberOfPayments.Size = new System.Drawing.Size(65, 32);
            this.lblNumberOfPayments.TabIndex = 2;
            this.lblNumberOfPayments.Text = "[???]";
            // 
            // gbAllPayments
            // 
            this.gbAllPayments.Controls.Add(this.dgvAllPayments);
            this.gbAllPayments.Controls.Add(this.lblNumberOfPayments);
            this.gbAllPayments.Controls.Add(this.label1);
            this.gbAllPayments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAllPayments.ForeColor = System.Drawing.Color.Black;
            this.gbAllPayments.Location = new System.Drawing.Point(0, 1);
            this.gbAllPayments.Name = "gbAllPayments";
            this.gbAllPayments.Size = new System.Drawing.Size(907, 289);
            this.gbAllPayments.TabIndex = 2;
            this.gbAllPayments.Text = "All Payments ";
            // 
            // dgvAllPayments
            // 
            this.dgvAllPayments.AllowUserToAddRows = false;
            this.dgvAllPayments.AllowUserToDeleteRows = false;
            this.dgvAllPayments.AllowUserToOrderColumns = true;
            this.dgvAllPayments.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAllPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllPayments.ContextMenuStrip = this.guna2ContextMenuStrip1;
            this.dgvAllPayments.Location = new System.Drawing.Point(-1, 59);
            this.dgvAllPayments.Name = "dgvAllPayments";
            this.dgvAllPayments.ReadOnly = true;
            this.dgvAllPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllPayments.Size = new System.Drawing.Size(905, 175);
            this.dgvAllPayments.TabIndex = 3;
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(113, 48);
            this.guna2ContextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.guna2ContextMenuStrip1_Opening);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Image = global::SCMSControlsLib.Properties.Resources.system_update__1_;
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::SCMSControlsLib.Properties.Resources.delete;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // ucShowPaymentHistoryForRepairOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbAllPayments);
            this.Name = "ucShowPaymentHistoryForRepairOrder";
            this.Size = new System.Drawing.Size(910, 290);
            this.gbAllPayments.ResumeLayout(false);
            this.gbAllPayments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllPayments)).EndInit();
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumberOfPayments;
        private Guna.UI2.WinForms.Guna2GroupBox gbAllPayments;
        private System.Windows.Forms.DataGridView dgvAllPayments;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}
