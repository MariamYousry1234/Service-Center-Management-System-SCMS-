namespace Service_Center_Management_System__SCMS_
{
    partial class frmManageDevices
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
            this.deleteInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDeviceDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalPages = new System.Windows.Forms.Label();
            this.lblPageNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.lblAllPersons = new System.Windows.Forms.Label();
            this.btnPrevious = new Guna.UI2.WinForms.Guna2Button();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.showRepairOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.btnAdd.Location = new System.Drawing.Point(998, 135);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(58, 45);
            this.btnAdd.TabIndex = 33;
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
            this.dgvData.Location = new System.Drawing.Point(21, 186);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(1122, 260);
            this.dgvData.TabIndex = 32;
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateInfoToolStripMenuItem,
            this.deleteInfoToolStripMenuItem,
            this.showDeviceDetailsToolStripMenuItem,
            this.showRepairOrdersToolStripMenuItem});
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
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(181, 114);
            this.guna2ContextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.guna2ContextMenuStrip1_Opening);
            // 
            // updateInfoToolStripMenuItem
            // 
            this.updateInfoToolStripMenuItem.Image = global::Service_Center_Management_System__SCMS_.Properties.Resources.system_update;
            this.updateInfoToolStripMenuItem.Name = "updateInfoToolStripMenuItem";
            this.updateInfoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateInfoToolStripMenuItem.Text = "Update Info";
            this.updateInfoToolStripMenuItem.Click += new System.EventHandler(this.updateInfoToolStripMenuItem_Click);
            // 
            // deleteInfoToolStripMenuItem
            // 
            this.deleteInfoToolStripMenuItem.Image = global::Service_Center_Management_System__SCMS_.Properties.Resources.delete;
            this.deleteInfoToolStripMenuItem.Name = "deleteInfoToolStripMenuItem";
            this.deleteInfoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteInfoToolStripMenuItem.Text = "Delete Info";
            this.deleteInfoToolStripMenuItem.Click += new System.EventHandler(this.deleteInfoToolStripMenuItem_Click);
            // 
            // showDeviceDetailsToolStripMenuItem
            // 
            this.showDeviceDetailsToolStripMenuItem.Image = global::Service_Center_Management_System__SCMS_.Properties.Resources.page;
            this.showDeviceDetailsToolStripMenuItem.Name = "showDeviceDetailsToolStripMenuItem";
            this.showDeviceDetailsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showDeviceDetailsToolStripMenuItem.Text = "Show Device Details";
            this.showDeviceDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDeviceDetailsToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(327, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 38);
            this.label3.TabIndex = 31;
            this.label3.Text = "/";
            // 
            // lblTotalPages
            // 
            this.lblTotalPages.AutoSize = true;
            this.lblTotalPages.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPages.Font = new System.Drawing.Font("Microsoft New Tai Lue", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPages.ForeColor = System.Drawing.Color.Red;
            this.lblTotalPages.Location = new System.Drawing.Point(365, 132);
            this.lblTotalPages.Name = "lblTotalPages";
            this.lblTotalPages.Size = new System.Drawing.Size(34, 38);
            this.lblTotalPages.TabIndex = 30;
            this.lblTotalPages.Text = "0";
            // 
            // lblPageNumber
            // 
            this.lblPageNumber.AutoSize = true;
            this.lblPageNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblPageNumber.Font = new System.Drawing.Font("Microsoft New Tai Lue", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageNumber.ForeColor = System.Drawing.Color.Lime;
            this.lblPageNumber.Location = new System.Drawing.Point(279, 134);
            this.lblPageNumber.Name = "lblPageNumber";
            this.lblPageNumber.Size = new System.Drawing.Size(34, 38);
            this.lblPageNumber.TabIndex = 29;
            this.lblPageNumber.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(15, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 32);
            this.label1.TabIndex = 28;
            this.label1.Text = "Number Of Page :";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.BorderColor = System.Drawing.Color.White;
            this.btnSearch.BorderRadius = 10;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Image = global::Service_Center_Management_System__SCMS_.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(1084, 136);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(58, 45);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblAllPersons
            // 
            this.lblAllPersons.AutoSize = true;
            this.lblAllPersons.BackColor = System.Drawing.Color.Transparent;
            this.lblAllPersons.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllPersons.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAllPersons.Location = new System.Drawing.Point(362, -7);
            this.lblAllPersons.Name = "lblAllPersons";
            this.lblAllPersons.Size = new System.Drawing.Size(413, 85);
            this.lblAllPersons.TabIndex = 26;
            this.lblAllPersons.Text = "Manage Devices";
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.White;
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
            this.btnPrevious.Location = new System.Drawing.Point(377, 472);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(168, 45);
            this.btnPrevious.TabIndex = 25;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
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
            this.btnNext.Location = new System.Drawing.Point(611, 473);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(156, 45);
            this.btnNext.TabIndex = 24;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // showRepairOrdersToolStripMenuItem
            // 
            this.showRepairOrdersToolStripMenuItem.Image = global::Service_Center_Management_System__SCMS_.Properties.Resources.repair;
            this.showRepairOrdersToolStripMenuItem.Name = "showRepairOrdersToolStripMenuItem";
            this.showRepairOrdersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showRepairOrdersToolStripMenuItem.Text = "View Repair Orders";
            this.showRepairOrdersToolStripMenuItem.Click += new System.EventHandler(this.showRepairOrdersToolStripMenuItem_Click);
            // 
            // frmManageDevices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Service_Center_Management_System__SCMS_.Properties.Resources.device;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1155, 538);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotalPages);
            this.Controls.Add(this.lblPageNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblAllPersons);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.DoubleBuffered = true;
            this.Name = "frmManageDevices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Devices";
            this.Load += new System.EventHandler(this.frmManageDevices_Load);
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
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private System.Windows.Forms.Label lblAllPersons;
        private Guna.UI2.WinForms.Guna2Button btnPrevious;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDeviceDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showRepairOrdersToolStripMenuItem;
    }
}