namespace Service_Center_Management_System__SCMS_
{
    partial class frmManageRepairOrders
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.updateInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelRepairOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showRepairOrderDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showRepairOrderHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.diagnosisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.performDiagnosisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerApprovalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordUsedPartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setRepairCostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalPages = new System.Windows.Forms.Label();
            this.lblPageNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAllPersons = new System.Windows.Forms.Label();
            this.btnPrevious = new Guna.UI2.WinForms.Guna2Button();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.cbFiltering = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbfiltering2 = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.guna2ContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.BorderColor = System.Drawing.Color.White;
            this.btnAdd.BorderRadius = 10;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Image = global::Service_Center_Management_System__SCMS_.Properties.Resources.plus;
            this.btnAdd.Location = new System.Drawing.Point(923, 122);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(58, 45);
            this.btnAdd.TabIndex = 52;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToOrderColumns = true;
            this.dgvData.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.ContextMenuStrip = this.guna2ContextMenuStrip1;
            this.dgvData.Location = new System.Drawing.Point(11, 172);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(970, 264);
            this.dgvData.TabIndex = 51;
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateInfoToolStripMenuItem,
            this.cancelRepairOrderToolStripMenuItem,
            this.showRepairOrderDetailsToolStripMenuItem,
            this.showRepairOrderHistoryToolStripMenuItem,
            this.toolStripMenuItem1,
            this.diagnosisToolStripMenuItem,
            this.recordUsedPartToolStripMenuItem,
            this.setRepairCostToolStripMenuItem,
            this.toolStripMenuItem3});
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
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(214, 192);
            this.guna2ContextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.guna2ContextMenuStrip1_Opening);
            // 
            // updateInfoToolStripMenuItem
            // 
            this.updateInfoToolStripMenuItem.Image = global::Service_Center_Management_System__SCMS_.Properties.Resources.system_update;
            this.updateInfoToolStripMenuItem.Name = "updateInfoToolStripMenuItem";
            this.updateInfoToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.updateInfoToolStripMenuItem.Text = "Update Info";
            this.updateInfoToolStripMenuItem.Click += new System.EventHandler(this.updateInfoToolStripMenuItem_Click);
            // 
            // cancelRepairOrderToolStripMenuItem
            // 
            this.cancelRepairOrderToolStripMenuItem.Image = global::Service_Center_Management_System__SCMS_.Properties.Resources.close;
            this.cancelRepairOrderToolStripMenuItem.Name = "cancelRepairOrderToolStripMenuItem";
            this.cancelRepairOrderToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.cancelRepairOrderToolStripMenuItem.Text = "Cancel Repair Order";
            this.cancelRepairOrderToolStripMenuItem.Click += new System.EventHandler(this.cancelRepairOrderToolStripMenuItem_Click);
            // 
            // showRepairOrderDetailsToolStripMenuItem
            // 
            this.showRepairOrderDetailsToolStripMenuItem.Image = global::Service_Center_Management_System__SCMS_.Properties.Resources.list;
            this.showRepairOrderDetailsToolStripMenuItem.Name = "showRepairOrderDetailsToolStripMenuItem";
            this.showRepairOrderDetailsToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.showRepairOrderDetailsToolStripMenuItem.Text = "Show Repair Order Details";
            this.showRepairOrderDetailsToolStripMenuItem.Click += new System.EventHandler(this.showRepairOrderDetailsToolStripMenuItem_Click);
            // 
            // showRepairOrderHistoryToolStripMenuItem
            // 
            this.showRepairOrderHistoryToolStripMenuItem.Image = global::Service_Center_Management_System__SCMS_.Properties.Resources.history;
            this.showRepairOrderHistoryToolStripMenuItem.Name = "showRepairOrderHistoryToolStripMenuItem";
            this.showRepairOrderHistoryToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.showRepairOrderHistoryToolStripMenuItem.Text = "Show Repair Order History";
            this.showRepairOrderHistoryToolStripMenuItem.Click += new System.EventHandler(this.showRepairOrderHistoryToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(210, 6);
            // 
            // diagnosisToolStripMenuItem
            // 
            this.diagnosisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.performDiagnosisToolStripMenuItem,
            this.customerApprovalToolStripMenuItem});
            this.diagnosisToolStripMenuItem.Image = global::Service_Center_Management_System__SCMS_.Properties.Resources.identify;
            this.diagnosisToolStripMenuItem.Name = "diagnosisToolStripMenuItem";
            this.diagnosisToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.diagnosisToolStripMenuItem.Text = "Diagnosis...";
            // 
            // performDiagnosisToolStripMenuItem
            // 
            this.performDiagnosisToolStripMenuItem.Image = global::Service_Center_Management_System__SCMS_.Properties.Resources.healthcare;
            this.performDiagnosisToolStripMenuItem.Name = "performDiagnosisToolStripMenuItem";
            this.performDiagnosisToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.performDiagnosisToolStripMenuItem.Text = "Perform Diagnosis";
            this.performDiagnosisToolStripMenuItem.Click += new System.EventHandler(this.performDiagnosisToolStripMenuItem_Click);
            // 
            // customerApprovalToolStripMenuItem
            // 
            this.customerApprovalToolStripMenuItem.Image = global::Service_Center_Management_System__SCMS_.Properties.Resources.like;
            this.customerApprovalToolStripMenuItem.Name = "customerApprovalToolStripMenuItem";
            this.customerApprovalToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.customerApprovalToolStripMenuItem.Text = "Customer Approval";
            this.customerApprovalToolStripMenuItem.Click += new System.EventHandler(this.customerApprovalToolStripMenuItem_Click);
            // 
            // recordUsedPartToolStripMenuItem
            // 
            this.recordUsedPartToolStripMenuItem.Image = global::Service_Center_Management_System__SCMS_.Properties.Resources.ram_memory;
            this.recordUsedPartToolStripMenuItem.Name = "recordUsedPartToolStripMenuItem";
            this.recordUsedPartToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.recordUsedPartToolStripMenuItem.Text = "Record Used Part";
            this.recordUsedPartToolStripMenuItem.Click += new System.EventHandler(this.recordUsedPartToolStripMenuItem_Click);
            // 
            // setRepairCostToolStripMenuItem
            // 
            this.setRepairCostToolStripMenuItem.Image = global::Service_Center_Management_System__SCMS_.Properties.Resources.invoice;
            this.setRepairCostToolStripMenuItem.Name = "setRepairCostToolStripMenuItem";
            this.setRepairCostToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.setRepairCostToolStripMenuItem.Text = "Set Repair Cost";
            this.setRepairCostToolStripMenuItem.Click += new System.EventHandler(this.setRepairCostToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(210, 6);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Fuchsia;
            this.label3.Location = new System.Drawing.Point(315, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 39);
            this.label3.TabIndex = 50;
            this.label3.Text = "/";
            // 
            // lblTotalPages
            // 
            this.lblTotalPages.AutoSize = true;
            this.lblTotalPages.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPages.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPages.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblTotalPages.Location = new System.Drawing.Point(352, 113);
            this.lblTotalPages.Name = "lblTotalPages";
            this.lblTotalPages.Size = new System.Drawing.Size(35, 39);
            this.lblTotalPages.TabIndex = 49;
            this.lblTotalPages.Text = "0";
            // 
            // lblPageNumber
            // 
            this.lblPageNumber.AutoSize = true;
            this.lblPageNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblPageNumber.Font = new System.Drawing.Font("Microsoft New Tai Lue", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageNumber.ForeColor = System.Drawing.Color.Lime;
            this.lblPageNumber.Location = new System.Drawing.Point(275, 117);
            this.lblPageNumber.Name = "lblPageNumber";
            this.lblPageNumber.Size = new System.Drawing.Size(34, 38);
            this.lblPageNumber.TabIndex = 48;
            this.lblPageNumber.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(18, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 32);
            this.label1.TabIndex = 47;
            this.label1.Text = "Number Of Page :";
            // 
            // lblAllPersons
            // 
            this.lblAllPersons.AutoSize = true;
            this.lblAllPersons.BackColor = System.Drawing.Color.Transparent;
            this.lblAllPersons.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllPersons.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAllPersons.Location = new System.Drawing.Point(234, 9);
            this.lblAllPersons.Name = "lblAllPersons";
            this.lblAllPersons.Size = new System.Drawing.Size(538, 56);
            this.lblAllPersons.TabIndex = 46;
            this.lblAllPersons.Text = "Manage Repair Orders";
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.BorderColor = System.Drawing.Color.White;
            this.btnPrevious.BorderRadius = 10;
            this.btnPrevious.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrevious.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrevious.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrevious.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrevious.Enabled = false;
            this.btnPrevious.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPrevious.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.Black;
            this.btnPrevious.Image = global::Service_Center_Management_System__SCMS_.Properties.Resources.rewind_button;
            this.btnPrevious.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPrevious.Location = new System.Drawing.Point(296, 482);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(168, 45);
            this.btnPrevious.TabIndex = 45;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BorderColor = System.Drawing.Color.White;
            this.btnNext.BorderRadius = 10;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Image = global::Service_Center_Management_System__SCMS_.Properties.Resources.next__1_;
            this.btnNext.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnNext.Location = new System.Drawing.Point(530, 483);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(156, 45);
            this.btnNext.TabIndex = 44;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
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
            "Status",
            "Priority"});
            this.cbFiltering.Location = new System.Drawing.Point(423, 126);
            this.cbFiltering.Name = "cbFiltering";
            this.cbFiltering.Size = new System.Drawing.Size(156, 36);
            this.cbFiltering.TabIndex = 54;
            this.cbFiltering.SelectedIndexChanged += new System.EventHandler(this.cbFiltering_SelectedIndexChanged);
            // 
            // cbfiltering2
            // 
            this.cbfiltering2.BackColor = System.Drawing.Color.Transparent;
            this.cbfiltering2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbfiltering2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbfiltering2.FillColor = System.Drawing.Color.Gainsboro;
            this.cbfiltering2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbfiltering2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbfiltering2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbfiltering2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbfiltering2.ItemHeight = 30;
            this.cbfiltering2.Location = new System.Drawing.Point(585, 127);
            this.cbfiltering2.Name = "cbfiltering2";
            this.cbfiltering2.Size = new System.Drawing.Size(255, 36);
            this.cbfiltering2.TabIndex = 55;
            this.cbfiltering2.SelectedIndexChanged += new System.EventHandler(this.cbfiltering2_SelectedIndexChanged);
            // 
            // frmManageRepairOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Service_Center_Management_System__SCMS_.Properties.Resources.repair;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(993, 548);
            this.Controls.Add(this.cbfiltering2);
            this.Controls.Add(this.cbFiltering);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotalPages);
            this.Controls.Add(this.lblPageNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAllPersons);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.DoubleBuffered = true;
            this.Name = "frmManageRepairOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Repair Orders";
            this.Load += new System.EventHandler(this.frmManageRepairOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalPages;
        private System.Windows.Forms.Label lblPageNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAllPersons;
        private Guna.UI2.WinForms.Guna2Button btnPrevious;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelRepairOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showRepairOrderDetailsToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2ComboBox cbFiltering;
        private Guna.UI2.WinForms.Guna2ComboBox cbfiltering2;
        private System.Windows.Forms.ToolStripMenuItem showRepairOrderHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem diagnosisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem performDiagnosisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerApprovalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordUsedPartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setRepairCostToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
    }
}