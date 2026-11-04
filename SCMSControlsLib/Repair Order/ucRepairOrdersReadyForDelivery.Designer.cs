namespace SCMSControlsLib
{
    partial class ucRepairOrdersReadyForDelivery
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.recordDeliveryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showRepairOrderDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbAllPayments = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvAllRepairOrders = new System.Windows.Forms.DataGridView();
            this.lblNumberOfRepairOrders = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.gbAllPayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllRepairOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recordDeliveryToolStripMenuItem,
            this.showRepairOrderDetailsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // recordDeliveryToolStripMenuItem
            // 
            this.recordDeliveryToolStripMenuItem.Image = global::SCMSControlsLib.Properties.Resources.delivery;
            this.recordDeliveryToolStripMenuItem.Name = "recordDeliveryToolStripMenuItem";
            this.recordDeliveryToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.recordDeliveryToolStripMenuItem.Text = "Record Delivery";
            this.recordDeliveryToolStripMenuItem.Click += new System.EventHandler(this.recordDeliveryToolStripMenuItem_Click);
            // 
            // showRepairOrderDetailsToolStripMenuItem
            // 
            this.showRepairOrderDetailsToolStripMenuItem.Image = global::SCMSControlsLib.Properties.Resources.list;
            this.showRepairOrderDetailsToolStripMenuItem.Name = "showRepairOrderDetailsToolStripMenuItem";
            this.showRepairOrderDetailsToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.showRepairOrderDetailsToolStripMenuItem.Text = "Show Repair Order Details";
            this.showRepairOrderDetailsToolStripMenuItem.Click += new System.EventHandler(this.showRepairOrderDetailsToolStripMenuItem_Click);
            // 
            // gbAllPayments
            // 
            this.gbAllPayments.Controls.Add(this.dgvAllRepairOrders);
            this.gbAllPayments.Controls.Add(this.lblNumberOfRepairOrders);
            this.gbAllPayments.Controls.Add(this.label1);
            this.gbAllPayments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAllPayments.ForeColor = System.Drawing.Color.Red;
            this.gbAllPayments.Location = new System.Drawing.Point(0, -3);
            this.gbAllPayments.Name = "gbAllPayments";
            this.gbAllPayments.Size = new System.Drawing.Size(1162, 404);
            this.gbAllPayments.TabIndex = 4;
            this.gbAllPayments.Text = "All Repair Orders Ready For Delivery";
            // 
            // dgvAllRepairOrders
            // 
            this.dgvAllRepairOrders.AllowUserToAddRows = false;
            this.dgvAllRepairOrders.AllowUserToDeleteRows = false;
            this.dgvAllRepairOrders.AllowUserToOrderColumns = true;
            this.dgvAllRepairOrders.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAllRepairOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllRepairOrders.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllRepairOrders.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllRepairOrders.Location = new System.Drawing.Point(-1, 74);
            this.dgvAllRepairOrders.Name = "dgvAllRepairOrders";
            this.dgvAllRepairOrders.ReadOnly = true;
            this.dgvAllRepairOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllRepairOrders.Size = new System.Drawing.Size(1157, 261);
            this.dgvAllRepairOrders.TabIndex = 3;
            // 
            // lblNumberOfRepairOrders
            // 
            this.lblNumberOfRepairOrders.AutoSize = true;
            this.lblNumberOfRepairOrders.BackColor = System.Drawing.Color.Transparent;
            this.lblNumberOfRepairOrders.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfRepairOrders.ForeColor = System.Drawing.Color.Blue;
            this.lblNumberOfRepairOrders.Location = new System.Drawing.Point(295, 357);
            this.lblNumberOfRepairOrders.Name = "lblNumberOfRepairOrders";
            this.lblNumberOfRepairOrders.Size = new System.Drawing.Size(65, 32);
            this.lblNumberOfRepairOrders.TabIndex = 2;
            this.lblNumberOfRepairOrders.Text = "[???]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number Of Repair Orders  :";
            // 
            // ucRepairOrdersReadyForDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbAllPayments);
            this.Name = "ucRepairOrdersReadyForDelivery";
            this.Size = new System.Drawing.Size(1168, 401);
            this.contextMenuStrip1.ResumeLayout(false);
            this.gbAllPayments.ResumeLayout(false);
            this.gbAllPayments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllRepairOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem recordDeliveryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showRepairOrderDetailsToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2GroupBox gbAllPayments;
        private System.Windows.Forms.DataGridView dgvAllRepairOrders;
        private System.Windows.Forms.Label lblNumberOfRepairOrders;
        private System.Windows.Forms.Label label1;
    }
}
