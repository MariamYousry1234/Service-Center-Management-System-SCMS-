namespace SCMSControlsLib
{
    partial class ucShowAllPreviousOperationsForPart
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalOperations = new System.Windows.Forms.Label();
            this.dgvAllOperations = new System.Windows.Forms.DataGridView();
            this.gbAllOperations = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllOperations)).BeginInit();
            this.gbAllOperations.SuspendLayout();
            this.guna2ContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Operations :";
            // 
            // lblTotalOperations
            // 
            this.lblTotalOperations.AutoSize = true;
            this.lblTotalOperations.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalOperations.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOperations.ForeColor = System.Drawing.Color.Blue;
            this.lblTotalOperations.Location = new System.Drawing.Point(245, 287);
            this.lblTotalOperations.Name = "lblTotalOperations";
            this.lblTotalOperations.Size = new System.Drawing.Size(65, 32);
            this.lblTotalOperations.TabIndex = 2;
            this.lblTotalOperations.Text = "[???]";
            // 
            // dgvAllOperations
            // 
            this.dgvAllOperations.AllowUserToAddRows = false;
            this.dgvAllOperations.AllowUserToDeleteRows = false;
            this.dgvAllOperations.AllowUserToOrderColumns = true;
            this.dgvAllOperations.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAllOperations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllOperations.ContextMenuStrip = this.guna2ContextMenuStrip1;
            this.dgvAllOperations.Location = new System.Drawing.Point(1, 59);
            this.dgvAllOperations.Name = "dgvAllOperations";
            this.dgvAllOperations.ReadOnly = true;
            this.dgvAllOperations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllOperations.Size = new System.Drawing.Size(893, 205);
            this.dgvAllOperations.TabIndex = 3;
            // 
            // gbAllOperations
            // 
            this.gbAllOperations.Controls.Add(this.dgvAllOperations);
            this.gbAllOperations.Controls.Add(this.lblTotalOperations);
            this.gbAllOperations.Controls.Add(this.label1);
            this.gbAllOperations.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAllOperations.ForeColor = System.Drawing.Color.Black;
            this.gbAllOperations.Location = new System.Drawing.Point(1, 2);
            this.gbAllOperations.Name = "gbAllOperations";
            this.gbAllOperations.Size = new System.Drawing.Size(896, 330);
            this.gbAllOperations.TabIndex = 2;
            this.gbAllOperations.Text = "All Pervious Purchase Operations For Part ID = [???]";
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
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            this.guna2ContextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.guna2ContextMenuStrip1_Opening);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Image = global::SCMSControlsLib.Properties.Resources.list1;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // ucShowAllPreviousOperationsForPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbAllOperations);
            this.Name = "ucShowAllPreviousOperationsForPart";
            this.Size = new System.Drawing.Size(898, 330);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllOperations)).EndInit();
            this.gbAllOperations.ResumeLayout(false);
            this.gbAllOperations.PerformLayout();
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalOperations;
        private System.Windows.Forms.DataGridView dgvAllOperations;
        private Guna.UI2.WinForms.Guna2GroupBox gbAllOperations;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
    }
}
