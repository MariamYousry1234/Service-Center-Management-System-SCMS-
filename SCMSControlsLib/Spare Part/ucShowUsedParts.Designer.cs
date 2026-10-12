namespace SCMSControlsLib
{
    partial class ucShowUsedParts
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
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showSparePartDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUsedSparePartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSparePartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalParts = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToOrderColumns = true;
            this.dgvData.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvData.Location = new System.Drawing.Point(1, 57);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(879, 150);
            this.dgvData.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showSparePartDetailsToolStripMenuItem,
            this.addUsedSparePartToolStripMenuItem,
            this.deleteSparePartToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(198, 70);
            // 
            // showSparePartDetailsToolStripMenuItem
            // 
            this.showSparePartDetailsToolStripMenuItem.Image = global::SCMSControlsLib.Properties.Resources.list;
            this.showSparePartDetailsToolStripMenuItem.Name = "showSparePartDetailsToolStripMenuItem";
            this.showSparePartDetailsToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.showSparePartDetailsToolStripMenuItem.Text = "Show Spare Part Details";
            this.showSparePartDetailsToolStripMenuItem.Click += new System.EventHandler(this.showSparePartDetailsToolStripMenuItem_Click);
            // 
            // addUsedSparePartToolStripMenuItem
            // 
            this.addUsedSparePartToolStripMenuItem.Image = global::SCMSControlsLib.Properties.Resources.plus;
            this.addUsedSparePartToolStripMenuItem.Name = "addUsedSparePartToolStripMenuItem";
            this.addUsedSparePartToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.addUsedSparePartToolStripMenuItem.Text = "Add Used Spare Part";
            this.addUsedSparePartToolStripMenuItem.Click += new System.EventHandler(this.addUsedSparePartToolStripMenuItem_Click);
            // 
            // deleteSparePartToolStripMenuItem
            // 
            this.deleteSparePartToolStripMenuItem.Image = global::SCMSControlsLib.Properties.Resources.delete;
            this.deleteSparePartToolStripMenuItem.Name = "deleteSparePartToolStripMenuItem";
            this.deleteSparePartToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.deleteSparePartToolStripMenuItem.Text = "Delete Used Spare Part";
            this.deleteSparePartToolStripMenuItem.Click += new System.EventHandler(this.deleteSparePartToolStripMenuItem_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(3, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(319, 31);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Repair Order ID = [???]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total Parts = ";
            // 
            // lblTotalParts
            // 
            this.lblTotalParts.AutoSize = true;
            this.lblTotalParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalParts.Location = new System.Drawing.Point(237, 219);
            this.lblTotalParts.Name = "lblTotalParts";
            this.lblTotalParts.Size = new System.Drawing.Size(62, 31);
            this.lblTotalParts.TabIndex = 4;
            this.lblTotalParts.Text = "???";
            // 
            // ucShowUsedParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.lblTotalParts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvData);
            this.Name = "ucShowUsedParts";
            this.Size = new System.Drawing.Size(883, 262);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalParts;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showSparePartDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUsedSparePartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSparePartToolStripMenuItem;
    }
}
