namespace Service_Center_Management_System__SCMS_
{
    partial class frmManageTechnicians
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
            this.showTechnicianInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllAssignedRepairsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showCompletedRepairsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showCurrentWorkloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deactivateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalPages = new System.Windows.Forms.Label();
            this.lblPageNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAllPersons = new System.Windows.Forms.Label();
            this.btnPrevious = new Guna.UI2.WinForms.Guna2Button();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
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
            this.btnAdd.Location = new System.Drawing.Point(949, 128);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(58, 45);
            this.btnAdd.TabIndex = 42;
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
            this.dgvData.Location = new System.Drawing.Point(15, 185);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(1083, 272);
            this.dgvData.TabIndex = 41;
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateInfoToolStripMenuItem,
            this.showTechnicianInfoToolStripMenuItem,
            this.showAllAssignedRepairsToolStripMenuItem,
            this.showCompletedRepairsToolStripMenuItem,
            this.showCurrentWorkloadToolStripMenuItem,
            this.deactivateToolStripMenuItem});
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
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(213, 136);
            this.guna2ContextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.guna2ContextMenuStrip1_Opening);
            // 
            // updateInfoToolStripMenuItem
            // 
            this.updateInfoToolStripMenuItem.Image = global::Service_Center_Management_System__SCMS_.Properties.Resources.system_update;
            this.updateInfoToolStripMenuItem.Name = "updateInfoToolStripMenuItem";
            this.updateInfoToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.updateInfoToolStripMenuItem.Text = "Update Info";
            this.updateInfoToolStripMenuItem.Click += new System.EventHandler(this.updateInfoToolStripMenuItem_Click);
            // 
            // showTechnicianInfoToolStripMenuItem
            // 
            this.showTechnicianInfoToolStripMenuItem.Image = global::Service_Center_Management_System__SCMS_.Properties.Resources.mechanic;
            this.showTechnicianInfoToolStripMenuItem.Name = "showTechnicianInfoToolStripMenuItem";
            this.showTechnicianInfoToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.showTechnicianInfoToolStripMenuItem.Text = "Show Technician Info";
            this.showTechnicianInfoToolStripMenuItem.Click += new System.EventHandler(this.showTechnicianInfoToolStripMenuItem_Click);
            // 
            // showAllAssignedRepairsToolStripMenuItem
            // 
            this.showAllAssignedRepairsToolStripMenuItem.Image = global::Service_Center_Management_System__SCMS_.Properties.Resources.assignment;
            this.showAllAssignedRepairsToolStripMenuItem.Name = "showAllAssignedRepairsToolStripMenuItem";
            this.showAllAssignedRepairsToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.showAllAssignedRepairsToolStripMenuItem.Text = "Show All Assigned Repairs";
            this.showAllAssignedRepairsToolStripMenuItem.Click += new System.EventHandler(this.showAllAssignedRepairsToolStripMenuItem_Click);
            // 
            // showCompletedRepairsToolStripMenuItem
            // 
            this.showCompletedRepairsToolStripMenuItem.Image = global::Service_Center_Management_System__SCMS_.Properties.Resources.checklist;
            this.showCompletedRepairsToolStripMenuItem.Name = "showCompletedRepairsToolStripMenuItem";
            this.showCompletedRepairsToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.showCompletedRepairsToolStripMenuItem.Text = "Show Completed Repairs";
            this.showCompletedRepairsToolStripMenuItem.Click += new System.EventHandler(this.showCompletedRepairsToolStripMenuItem_Click);
            // 
            // showCurrentWorkloadToolStripMenuItem
            // 
            this.showCurrentWorkloadToolStripMenuItem.Image = global::Service_Center_Management_System__SCMS_.Properties.Resources.currentworkload;
            this.showCurrentWorkloadToolStripMenuItem.Name = "showCurrentWorkloadToolStripMenuItem";
            this.showCurrentWorkloadToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.showCurrentWorkloadToolStripMenuItem.Text = "Show Current Workload";
            this.showCurrentWorkloadToolStripMenuItem.Click += new System.EventHandler(this.showCurrentWorkloadToolStripMenuItem_Click);
            // 
            // deactivateToolStripMenuItem
            // 
            this.deactivateToolStripMenuItem.Image = global::Service_Center_Management_System__SCMS_.Properties.Resources.customer1;
            this.deactivateToolStripMenuItem.Name = "deactivateToolStripMenuItem";
            this.deactivateToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.deactivateToolStripMenuItem.Text = "Deactivate";
            this.deactivateToolStripMenuItem.Click += new System.EventHandler(this.deactivateToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Fuchsia;
            this.label3.Location = new System.Drawing.Point(316, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 39);
            this.label3.TabIndex = 40;
            this.label3.Text = "/";
            // 
            // lblTotalPages
            // 
            this.lblTotalPages.AutoSize = true;
            this.lblTotalPages.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPages.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPages.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblTotalPages.Location = new System.Drawing.Point(353, 126);
            this.lblTotalPages.Name = "lblTotalPages";
            this.lblTotalPages.Size = new System.Drawing.Size(35, 39);
            this.lblTotalPages.TabIndex = 39;
            this.lblTotalPages.Text = "0";
            // 
            // lblPageNumber
            // 
            this.lblPageNumber.AutoSize = true;
            this.lblPageNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblPageNumber.Font = new System.Drawing.Font("Microsoft New Tai Lue", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageNumber.ForeColor = System.Drawing.Color.Lime;
            this.lblPageNumber.Location = new System.Drawing.Point(276, 130);
            this.lblPageNumber.Name = "lblPageNumber";
            this.lblPageNumber.Size = new System.Drawing.Size(34, 38);
            this.lblPageNumber.TabIndex = 38;
            this.lblPageNumber.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(19, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 32);
            this.label1.TabIndex = 37;
            this.label1.Text = "Number Of Page :";
            // 
            // lblAllPersons
            // 
            this.lblAllPersons.AutoSize = true;
            this.lblAllPersons.BackColor = System.Drawing.Color.Transparent;
            this.lblAllPersons.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllPersons.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAllPersons.Location = new System.Drawing.Point(331, 9);
            this.lblAllPersons.Name = "lblAllPersons";
            this.lblAllPersons.Size = new System.Drawing.Size(491, 56);
            this.lblAllPersons.TabIndex = 36;
            this.lblAllPersons.Text = "Manage Technicians";
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
            this.btnPrevious.Location = new System.Drawing.Point(353, 472);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(168, 45);
            this.btnPrevious.TabIndex = 35;
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
            this.btnNext.Location = new System.Drawing.Point(587, 473);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(156, 45);
            this.btnNext.TabIndex = 34;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
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
            this.btnSearch.Location = new System.Drawing.Point(1036, 128);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(58, 45);
            this.btnSearch.TabIndex = 43;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmManageTechnicians
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Service_Center_Management_System__SCMS_.Properties.Resources.mechanic1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1110, 535);
            this.Controls.Add(this.btnSearch);
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
            this.Name = "frmManageTechnicians";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Technicians";
            this.Load += new System.EventHandler(this.frmManageTechnicians_Load);
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
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showTechnicianInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllAssignedRepairsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showCompletedRepairsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showCurrentWorkloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deactivateToolStripMenuItem;
    }
}