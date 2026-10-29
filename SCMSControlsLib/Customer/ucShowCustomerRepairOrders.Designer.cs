namespace SCMSControlsLib
{
    partial class ucShowCustomerRepairOrders
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
            this.gbAllRepairOrders = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvAllRepairOrders = new System.Windows.Forms.DataGridView();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTotalRepairOrders = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbAllRepairOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllRepairOrders)).BeginInit();
            this.guna2ContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAllRepairOrders
            // 
            this.gbAllRepairOrders.Controls.Add(this.dgvAllRepairOrders);
            this.gbAllRepairOrders.Controls.Add(this.lblTotalRepairOrders);
            this.gbAllRepairOrders.Controls.Add(this.label1);
            this.gbAllRepairOrders.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAllRepairOrders.ForeColor = System.Drawing.Color.Red;
            this.gbAllRepairOrders.Location = new System.Drawing.Point(1, 2);
            this.gbAllRepairOrders.Name = "gbAllRepairOrders";
            this.gbAllRepairOrders.Size = new System.Drawing.Size(1169, 422);
            this.gbAllRepairOrders.TabIndex = 1;
            this.gbAllRepairOrders.Text = "All Repair Orders For Customer ID = [???]";
            // 
            // dgvAllRepairOrders
            // 
            this.dgvAllRepairOrders.AllowUserToAddRows = false;
            this.dgvAllRepairOrders.AllowUserToDeleteRows = false;
            this.dgvAllRepairOrders.AllowUserToOrderColumns = true;
            this.dgvAllRepairOrders.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAllRepairOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllRepairOrders.ContextMenuStrip = this.guna2ContextMenuStrip1;
            this.dgvAllRepairOrders.Location = new System.Drawing.Point(1, 59);
            this.dgvAllRepairOrders.Name = "dgvAllRepairOrders";
            this.dgvAllRepairOrders.ReadOnly = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvAllRepairOrders.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllRepairOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllRepairOrders.Size = new System.Drawing.Size(1165, 312);
            this.dgvAllRepairOrders.TabIndex = 3;
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem});
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
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(142, 26);
            this.guna2ContextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.guna2ContextMenuStrip1_Opening);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Image = global::SCMSControlsLib.Properties.Resources.list;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // lblTotalRepairOrders
            // 
            this.lblTotalRepairOrders.AutoSize = true;
            this.lblTotalRepairOrders.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalRepairOrders.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRepairOrders.ForeColor = System.Drawing.Color.Blue;
            this.lblTotalRepairOrders.Location = new System.Drawing.Point(260, 378);
            this.lblTotalRepairOrders.Name = "lblTotalRepairOrders";
            this.lblTotalRepairOrders.Size = new System.Drawing.Size(65, 32);
            this.lblTotalRepairOrders.TabIndex = 2;
            this.lblTotalRepairOrders.Text = "[???]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Repair Orders:";
            // 
            // ucShowCustomerRepairOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbAllRepairOrders);
            this.Name = "ucShowCustomerRepairOrders";
            this.Size = new System.Drawing.Size(1173, 427);
            this.gbAllRepairOrders.ResumeLayout(false);
            this.gbAllRepairOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllRepairOrders)).EndInit();
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gbAllRepairOrders;
        private System.Windows.Forms.DataGridView dgvAllRepairOrders;
        private System.Windows.Forms.Label lblTotalRepairOrders;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
    }
}
