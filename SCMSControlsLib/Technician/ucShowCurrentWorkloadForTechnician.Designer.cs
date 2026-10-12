namespace SCMSControlsLib
{
    partial class ucShowCurrentWorkloadForTechnician
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
            this.gbAllRepairOrders = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvAllRepairs = new System.Windows.Forms.DataGridView();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTotalRepairs = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbAllRepairOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllRepairs)).BeginInit();
            this.guna2ContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAllRepairOrders
            // 
            this.gbAllRepairOrders.Controls.Add(this.dgvAllRepairs);
            this.gbAllRepairOrders.Controls.Add(this.lblTotalRepairs);
            this.gbAllRepairOrders.Controls.Add(this.label1);
            this.gbAllRepairOrders.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAllRepairOrders.ForeColor = System.Drawing.Color.Black;
            this.gbAllRepairOrders.Location = new System.Drawing.Point(-1, 0);
            this.gbAllRepairOrders.Name = "gbAllRepairOrders";
            this.gbAllRepairOrders.Size = new System.Drawing.Size(1178, 326);
            this.gbAllRepairOrders.TabIndex = 4;
            this.gbAllRepairOrders.Text = "All Current Workload Repairs For Technician ID = [???]";
            // 
            // dgvAllRepairs
            // 
            this.dgvAllRepairs.AllowUserToAddRows = false;
            this.dgvAllRepairs.AllowUserToDeleteRows = false;
            this.dgvAllRepairs.AllowUserToOrderColumns = true;
            this.dgvAllRepairs.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAllRepairs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllRepairs.ContextMenuStrip = this.guna2ContextMenuStrip1;
            this.dgvAllRepairs.Location = new System.Drawing.Point(1, 59);
            this.dgvAllRepairs.Name = "dgvAllRepairs";
            this.dgvAllRepairs.ReadOnly = true;
            this.dgvAllRepairs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllRepairs.Size = new System.Drawing.Size(1174, 205);
            this.dgvAllRepairs.TabIndex = 3;
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
            // lblTotalRepairs
            // 
            this.lblTotalRepairs.AutoSize = true;
            this.lblTotalRepairs.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalRepairs.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRepairs.ForeColor = System.Drawing.Color.Blue;
            this.lblTotalRepairs.Location = new System.Drawing.Point(186, 288);
            this.lblTotalRepairs.Name = "lblTotalRepairs";
            this.lblTotalRepairs.Size = new System.Drawing.Size(65, 32);
            this.lblTotalRepairs.TabIndex = 2;
            this.lblTotalRepairs.Text = "[???]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Repairs :";
            // 
            // ucShowCurrentWorkloadForTechnician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbAllRepairOrders);
            this.Name = "ucShowCurrentWorkloadForTechnician";
            this.Size = new System.Drawing.Size(1180, 325);
            this.gbAllRepairOrders.ResumeLayout(false);
            this.gbAllRepairOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllRepairs)).EndInit();
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gbAllRepairOrders;
        private System.Windows.Forms.DataGridView dgvAllRepairs;
        private System.Windows.Forms.Label lblTotalRepairs;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
    }
}
