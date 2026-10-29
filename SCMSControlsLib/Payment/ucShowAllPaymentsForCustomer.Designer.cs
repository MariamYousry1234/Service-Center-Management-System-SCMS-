namespace SCMSControlsLib
{
    partial class ucShowAllPaymentsForCustomer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbAllPayments = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFiltering = new SCMSControlsLib.cusTextBox();
            this.cbFiltering = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvAllPayments = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showRepairOrderDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showInvoiceDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showCreatedUserInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNumberOfRepairOrders = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbAllPayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllPayments)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAllPayments
            // 
            this.gbAllPayments.Controls.Add(this.label2);
            this.gbAllPayments.Controls.Add(this.txtFiltering);
            this.gbAllPayments.Controls.Add(this.cbFiltering);
            this.gbAllPayments.Controls.Add(this.dgvAllPayments);
            this.gbAllPayments.Controls.Add(this.lblNumberOfRepairOrders);
            this.gbAllPayments.Controls.Add(this.label1);
            this.gbAllPayments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAllPayments.ForeColor = System.Drawing.Color.Red;
            this.gbAllPayments.Location = new System.Drawing.Point(0, 2);
            this.gbAllPayments.Name = "gbAllPayments";
            this.gbAllPayments.Size = new System.Drawing.Size(907, 385);
            this.gbAllPayments.TabIndex = 4;
            this.gbAllPayments.Text = "All Payments For Customer ID = [???]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(19, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 32);
            this.label2.TabIndex = 59;
            this.label2.Text = "Filter By :";
            // 
            // txtFiltering
            // 
            this.txtFiltering.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltering.IsRequired = false;
            this.txtFiltering.Length = null;
            this.txtFiltering.Location = new System.Drawing.Point(358, 57);
            this.txtFiltering.Name = "txtFiltering";
            this.txtFiltering.Size = new System.Drawing.Size(235, 35);
            this.txtFiltering.TabIndex = 58;
            this.txtFiltering.WritingType = SCMSControlsLib.cusTextBox.enWritingType.Numbers;
            this.txtFiltering.TextChanged += new System.EventHandler(this.txtFiltering_TextChanged);
            // 
            // cbFiltering
            // 
            this.cbFiltering.BackColor = System.Drawing.Color.Transparent;
            this.cbFiltering.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFiltering.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltering.FillColor = System.Drawing.Color.Gainsboro;
            this.cbFiltering.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFiltering.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFiltering.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFiltering.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFiltering.ItemHeight = 30;
            this.cbFiltering.Items.AddRange(new object[] {
            "None",
            "RepairOrderID",
            "InvoiceID"});
            this.cbFiltering.Location = new System.Drawing.Point(146, 57);
            this.cbFiltering.Name = "cbFiltering";
            this.cbFiltering.Size = new System.Drawing.Size(202, 36);
            this.cbFiltering.TabIndex = 57;
            this.cbFiltering.SelectedIndexChanged += new System.EventHandler(this.cbFiltering_SelectedIndexChanged);
            // 
            // dgvAllPayments
            // 
            this.dgvAllPayments.AllowUserToAddRows = false;
            this.dgvAllPayments.AllowUserToDeleteRows = false;
            this.dgvAllPayments.AllowUserToOrderColumns = true;
            this.dgvAllPayments.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAllPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllPayments.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllPayments.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllPayments.Location = new System.Drawing.Point(-1, 99);
            this.dgvAllPayments.Name = "dgvAllPayments";
            this.dgvAllPayments.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgvAllPayments.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAllPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllPayments.Size = new System.Drawing.Size(905, 236);
            this.dgvAllPayments.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showRepairOrderDetailsToolStripMenuItem,
            this.showInvoiceDetailsToolStripMenuItem,
            this.showCreatedUserInfoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 70);
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
            // showInvoiceDetailsToolStripMenuItem
            // 
            this.showInvoiceDetailsToolStripMenuItem.Image = global::SCMSControlsLib.Properties.Resources.invoice__1_1;
            this.showInvoiceDetailsToolStripMenuItem.Name = "showInvoiceDetailsToolStripMenuItem";
            this.showInvoiceDetailsToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.showInvoiceDetailsToolStripMenuItem.Text = "Show Invoice Details";
            this.showInvoiceDetailsToolStripMenuItem.Click += new System.EventHandler(this.showInvoiceDetailsToolStripMenuItem_Click);
            // 
            // showCreatedUserInfoToolStripMenuItem
            // 
            this.showCreatedUserInfoToolStripMenuItem.Image = global::SCMSControlsLib.Properties.Resources.user__1_1;
            this.showCreatedUserInfoToolStripMenuItem.Name = "showCreatedUserInfoToolStripMenuItem";
            this.showCreatedUserInfoToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.showCreatedUserInfoToolStripMenuItem.Text = "Show Created User Info";
            this.showCreatedUserInfoToolStripMenuItem.Click += new System.EventHandler(this.showCreatedUserInfoToolStripMenuItem_Click);
            // 
            // lblNumberOfRepairOrders
            // 
            this.lblNumberOfRepairOrders.AutoSize = true;
            this.lblNumberOfRepairOrders.BackColor = System.Drawing.Color.Transparent;
            this.lblNumberOfRepairOrders.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfRepairOrders.ForeColor = System.Drawing.Color.Blue;
            this.lblNumberOfRepairOrders.Location = new System.Drawing.Point(255, 344);
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
            this.label1.Location = new System.Drawing.Point(4, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number Of Payments :";
            // 
            // ucShowAllPaymentsForCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbAllPayments);
            this.Name = "ucShowAllPaymentsForCustomer";
            this.Size = new System.Drawing.Size(909, 385);
            this.gbAllPayments.ResumeLayout(false);
            this.gbAllPayments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllPayments)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gbAllPayments;
        private System.Windows.Forms.DataGridView dgvAllPayments;
        private System.Windows.Forms.Label lblNumberOfRepairOrders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private cusTextBox txtFiltering;
        private Guna.UI2.WinForms.Guna2ComboBox cbFiltering;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showRepairOrderDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showInvoiceDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showCreatedUserInfoToolStripMenuItem;
    }
}
