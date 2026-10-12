namespace Service_Center_Management_System__SCMS_
{
    partial class frmManageSuppliers
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
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.updateInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decativateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAllPersons = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumberOfSuppliers = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.guna2ContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToOrderColumns = true;
            this.dgvData.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.ContextMenuStrip = this.guna2ContextMenuStrip1;
            this.dgvData.Location = new System.Drawing.Point(20, 160);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(837, 296);
            this.dgvData.TabIndex = 52;
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateInfoToolStripMenuItem,
            this.decativateToolStripMenuItem});
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
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(137, 48);
            this.guna2ContextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.guna2ContextMenuStrip1_Opening);
            // 
            // updateInfoToolStripMenuItem
            // 
            this.updateInfoToolStripMenuItem.Image = global::Service_Center_Management_System__SCMS_.Properties.Resources.system_update;
            this.updateInfoToolStripMenuItem.Name = "updateInfoToolStripMenuItem";
            this.updateInfoToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.updateInfoToolStripMenuItem.Text = "Update Info";
            this.updateInfoToolStripMenuItem.Click += new System.EventHandler(this.updateInfoToolStripMenuItem_Click);
            // 
            // decativateToolStripMenuItem
            // 
            this.decativateToolStripMenuItem.Image = global::Service_Center_Management_System__SCMS_.Properties.Resources.touch_screen;
            this.decativateToolStripMenuItem.Name = "decativateToolStripMenuItem";
            this.decativateToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.decativateToolStripMenuItem.Text = "Decativate";
            this.decativateToolStripMenuItem.Click += new System.EventHandler(this.decativateToolStripMenuItem_Click);
            // 
            // lblAllPersons
            // 
            this.lblAllPersons.AutoSize = true;
            this.lblAllPersons.BackColor = System.Drawing.Color.Transparent;
            this.lblAllPersons.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllPersons.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAllPersons.Location = new System.Drawing.Point(220, 1);
            this.lblAllPersons.Name = "lblAllPersons";
            this.lblAllPersons.Size = new System.Drawing.Size(435, 56);
            this.lblAllPersons.TabIndex = 46;
            this.lblAllPersons.Text = "Manage Suppliers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(23, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 32);
            this.label1.TabIndex = 56;
            this.label1.Text = "Number Of Suppliers :";
            // 
            // lblNumberOfSuppliers
            // 
            this.lblNumberOfSuppliers.AutoSize = true;
            this.lblNumberOfSuppliers.BackColor = System.Drawing.Color.Transparent;
            this.lblNumberOfSuppliers.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfSuppliers.ForeColor = System.Drawing.Color.Red;
            this.lblNumberOfSuppliers.Location = new System.Drawing.Point(356, 98);
            this.lblNumberOfSuppliers.Name = "lblNumberOfSuppliers";
            this.lblNumberOfSuppliers.Size = new System.Drawing.Size(83, 32);
            this.lblNumberOfSuppliers.TabIndex = 57;
            this.lblNumberOfSuppliers.Text = "[???]";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderColor = System.Drawing.Color.White;
            this.btnClose.BorderRadius = 10;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.LightGray;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Image = global::Service_Center_Management_System__SCMS_.Properties.Resources.close;
            this.btnClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClose.Location = new System.Drawing.Point(362, 492);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(156, 45);
            this.btnClose.TabIndex = 54;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.btnAdd.Location = new System.Drawing.Point(712, 84);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(58, 45);
            this.btnAdd.TabIndex = 53;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.btnSearch.Location = new System.Drawing.Point(800, 85);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(58, 45);
            this.btnSearch.TabIndex = 47;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmManageSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Service_Center_Management_System__SCMS_.Properties.Resources.supplier;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(878, 546);
            this.Controls.Add(this.lblNumberOfSuppliers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblAllPersons);
            this.DoubleBuffered = true;
            this.Name = "frmManageSuppliers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Suppliers";
            this.Load += new System.EventHandler(this.frmManageSuppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private System.Windows.Forms.DataGridView dgvData;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private System.Windows.Forms.Label lblAllPersons;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decativateToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumberOfSuppliers;
    }
}