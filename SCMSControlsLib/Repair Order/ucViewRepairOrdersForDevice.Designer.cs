namespace SCMSControlsLib
{
    partial class ucViewRepairOrdersForDevice
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
            this.gbAllRepairOrders = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvAllRepairs = new System.Windows.Forms.DataGridView();
            this.lblTotalRepairOrders = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showRepairOrderDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbAllRepairOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllRepairs)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAllRepairOrders
            // 
            this.gbAllRepairOrders.Controls.Add(this.dgvAllRepairs);
            this.gbAllRepairOrders.Controls.Add(this.lblTotalRepairOrders);
            this.gbAllRepairOrders.Controls.Add(this.label1);
            this.gbAllRepairOrders.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAllRepairOrders.ForeColor = System.Drawing.Color.Black;
            this.gbAllRepairOrders.Location = new System.Drawing.Point(-2, 0);
            this.gbAllRepairOrders.Name = "gbAllRepairOrders";
            this.gbAllRepairOrders.Size = new System.Drawing.Size(1178, 330);
            this.gbAllRepairOrders.TabIndex = 5;
            this.gbAllRepairOrders.Text = "All Repair Orders For Device ID = [???]";
            // 
            // dgvAllRepairs
            // 
            this.dgvAllRepairs.AllowUserToAddRows = false;
            this.dgvAllRepairs.AllowUserToDeleteRows = false;
            this.dgvAllRepairs.AllowUserToOrderColumns = true;
            this.dgvAllRepairs.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAllRepairs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllRepairs.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAllRepairs.Location = new System.Drawing.Point(1, 59);
            this.dgvAllRepairs.Name = "dgvAllRepairs";
            this.dgvAllRepairs.ReadOnly = true;
            this.dgvAllRepairs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllRepairs.Size = new System.Drawing.Size(1174, 205);
            this.dgvAllRepairs.TabIndex = 3;
            // 
            // lblTotalRepairOrders
            // 
            this.lblTotalRepairOrders.AutoSize = true;
            this.lblTotalRepairOrders.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalRepairOrders.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRepairOrders.ForeColor = System.Drawing.Color.Blue;
            this.lblTotalRepairOrders.Location = new System.Drawing.Point(263, 287);
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
            this.label1.Location = new System.Drawing.Point(5, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Repair Orders:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showRepairOrderDetailsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // showRepairOrderDetailsToolStripMenuItem
            // 
            this.showRepairOrderDetailsToolStripMenuItem.Image = global::SCMSControlsLib.Properties.Resources.list;
            this.showRepairOrderDetailsToolStripMenuItem.Name = "showRepairOrderDetailsToolStripMenuItem";
            this.showRepairOrderDetailsToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.showRepairOrderDetailsToolStripMenuItem.Text = "Show Repair Order Details";
            this.showRepairOrderDetailsToolStripMenuItem.Click += new System.EventHandler(this.showRepairOrderDetailsToolStripMenuItem_Click);
            // 
            // ucViewRepairOrdersForDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbAllRepairOrders);
            this.Name = "ucViewRepairOrdersForDevice";
            this.Size = new System.Drawing.Size(1175, 329);
            this.gbAllRepairOrders.ResumeLayout(false);
            this.gbAllRepairOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllRepairs)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gbAllRepairOrders;
        private System.Windows.Forms.DataGridView dgvAllRepairs;
        private System.Windows.Forms.Label lblTotalRepairOrders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showRepairOrderDetailsToolStripMenuItem;
    }
}
