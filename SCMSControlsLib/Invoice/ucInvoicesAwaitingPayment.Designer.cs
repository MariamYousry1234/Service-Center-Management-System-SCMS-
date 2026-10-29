namespace SCMSControlsLib
{
    partial class ucInvoicesAwaitingPayment
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
            this.gbAllPayments = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvAllRepairOrders = new System.Windows.Forms.DataGridView();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.recordPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPaymentsHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNumberOfRepairOrders = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.showInvoiceDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showRepairOrderDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbAllPayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllRepairOrders)).BeginInit();
            this.guna2ContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAllPayments
            // 
            this.gbAllPayments.Controls.Add(this.dgvAllRepairOrders);
            this.gbAllPayments.Controls.Add(this.lblNumberOfRepairOrders);
            this.gbAllPayments.Controls.Add(this.label1);
            this.gbAllPayments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAllPayments.ForeColor = System.Drawing.Color.Red;
            this.gbAllPayments.Location = new System.Drawing.Point(-1, -2);
            this.gbAllPayments.Name = "gbAllPayments";
            this.gbAllPayments.Size = new System.Drawing.Size(998, 399);
            this.gbAllPayments.TabIndex = 4;
            this.gbAllPayments.Text = "All Invoices Awaiting Payment";
            // 
            // dgvAllRepairOrders
            // 
            this.dgvAllRepairOrders.AllowUserToAddRows = false;
            this.dgvAllRepairOrders.AllowUserToDeleteRows = false;
            this.dgvAllRepairOrders.AllowUserToOrderColumns = true;
            this.dgvAllRepairOrders.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAllRepairOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllRepairOrders.ContextMenuStrip = this.guna2ContextMenuStrip1;
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
            this.dgvAllRepairOrders.Size = new System.Drawing.Size(998, 261);
            this.dgvAllRepairOrders.TabIndex = 3;
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recordPaymentToolStripMenuItem,
            this.showPaymentsHistoryToolStripMenuItem,
            this.toolStripMenuItem1,
            this.showInvoiceDetailsToolStripMenuItem,
            this.showRepairOrderDetailsToolStripMenuItem});
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
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(211, 120);
            this.guna2ContextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.guna2ContextMenuStrip1_Opening);
            // 
            // recordPaymentToolStripMenuItem
            // 
            this.recordPaymentToolStripMenuItem.Image = global::SCMSControlsLib.Properties.Resources.cash_payment;
            this.recordPaymentToolStripMenuItem.Name = "recordPaymentToolStripMenuItem";
            this.recordPaymentToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.recordPaymentToolStripMenuItem.Text = "Record Payment";
            this.recordPaymentToolStripMenuItem.Click += new System.EventHandler(this.recordPaymentToolStripMenuItem_Click);
            // 
            // showPaymentsHistoryToolStripMenuItem
            // 
            this.showPaymentsHistoryToolStripMenuItem.Image = global::SCMSControlsLib.Properties.Resources.transaction_history;
            this.showPaymentsHistoryToolStripMenuItem.Name = "showPaymentsHistoryToolStripMenuItem";
            this.showPaymentsHistoryToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.showPaymentsHistoryToolStripMenuItem.Text = "Show Payments History";
            this.showPaymentsHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPaymentsHistoryToolStripMenuItem_Click);
            // 
            // lblNumberOfRepairOrders
            // 
            this.lblNumberOfRepairOrders.AutoSize = true;
            this.lblNumberOfRepairOrders.BackColor = System.Drawing.Color.Transparent;
            this.lblNumberOfRepairOrders.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfRepairOrders.ForeColor = System.Drawing.Color.Blue;
            this.lblNumberOfRepairOrders.Location = new System.Drawing.Point(234, 357);
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
            this.label1.Size = new System.Drawing.Size(228, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number Of Invoices  :";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(207, 6);
            // 
            // showInvoiceDetailsToolStripMenuItem
            // 
            this.showInvoiceDetailsToolStripMenuItem.Image = global::SCMSControlsLib.Properties.Resources.invoice__1_;
            this.showInvoiceDetailsToolStripMenuItem.Name = "showInvoiceDetailsToolStripMenuItem";
            this.showInvoiceDetailsToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.showInvoiceDetailsToolStripMenuItem.Text = "Show Invoice Details";
            this.showInvoiceDetailsToolStripMenuItem.Click += new System.EventHandler(this.showInvoiceDetailsToolStripMenuItem_Click);
            // 
            // showRepairOrderDetailsToolStripMenuItem
            // 
            this.showRepairOrderDetailsToolStripMenuItem.Image = global::SCMSControlsLib.Properties.Resources.list1;
            this.showRepairOrderDetailsToolStripMenuItem.Name = "showRepairOrderDetailsToolStripMenuItem";
            this.showRepairOrderDetailsToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.showRepairOrderDetailsToolStripMenuItem.Text = "Show Repair Order Details";
            this.showRepairOrderDetailsToolStripMenuItem.Click += new System.EventHandler(this.showRepairOrderDetailsToolStripMenuItem_Click);
            // 
            // ucInvoicesAwaitingPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbAllPayments);
            this.Name = "ucInvoicesAwaitingPayment";
            this.Size = new System.Drawing.Size(997, 400);
            this.gbAllPayments.ResumeLayout(false);
            this.gbAllPayments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllRepairOrders)).EndInit();
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gbAllPayments;
        private System.Windows.Forms.DataGridView dgvAllRepairOrders;
        private System.Windows.Forms.Label lblNumberOfRepairOrders;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem recordPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPaymentsHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showInvoiceDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showRepairOrderDetailsToolStripMenuItem;
    }
}
