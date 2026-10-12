namespace SCMSControlsLib
{
    partial class ucShowBrandInfo
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
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblBrandName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBrandID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.lblBrandName);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.lblBrandID);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 1);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(520, 229);
            this.guna2GroupBox1.TabIndex = 1;
            this.guna2GroupBox1.Text = "Brand Information";
            // 
            // lblBrandName
            // 
            this.lblBrandName.AutoSize = true;
            this.lblBrandName.BackColor = System.Drawing.Color.Transparent;
            this.lblBrandName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrandName.Location = new System.Drawing.Point(237, 140);
            this.lblBrandName.Name = "lblBrandName";
            this.lblBrandName.Size = new System.Drawing.Size(73, 37);
            this.lblBrandName.TabIndex = 3;
            this.lblBrandName.Text = "[???]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Brand Name :";
            // 
            // lblBrandID
            // 
            this.lblBrandID.AutoSize = true;
            this.lblBrandID.BackColor = System.Drawing.Color.Transparent;
            this.lblBrandID.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrandID.Location = new System.Drawing.Point(237, 75);
            this.lblBrandID.Name = "lblBrandID";
            this.lblBrandID.Size = new System.Drawing.Size(73, 37);
            this.lblBrandID.TabIndex = 1;
            this.lblBrandID.Text = "[???]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Brand ID :";
            // 
            // ucShowBrandInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2GroupBox1);
            this.Name = "ucShowBrandInfo";
            this.Size = new System.Drawing.Size(522, 233);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label lblBrandName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBrandID;
        private System.Windows.Forms.Label label1;
    }
}
