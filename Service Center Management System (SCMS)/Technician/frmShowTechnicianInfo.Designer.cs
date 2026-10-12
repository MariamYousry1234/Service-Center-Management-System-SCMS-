namespace Service_Center_Management_System__SCMS_
{
    partial class frmShowTechnicianInfo
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
            this.lblAllPersons = new System.Windows.Forms.Label();
            this.ucShowTechnicianInfo1 = new SCMSControlsLib.ucShowTechnicianInfo();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // lblAllPersons
            // 
            this.lblAllPersons.AutoSize = true;
            this.lblAllPersons.BackColor = System.Drawing.Color.Transparent;
            this.lblAllPersons.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllPersons.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAllPersons.Location = new System.Drawing.Point(121, 9);
            this.lblAllPersons.Name = "lblAllPersons";
            this.lblAllPersons.Size = new System.Drawing.Size(344, 44);
            this.lblAllPersons.TabIndex = 28;
            this.lblAllPersons.Text = "Technician Details";
            // 
            // ucShowTechnicianInfo1
            // 
            this.ucShowTechnicianInfo1.Location = new System.Drawing.Point(-4, 56);
            this.ucShowTechnicianInfo1.Name = "ucShowTechnicianInfo1";
            this.ucShowTechnicianInfo1.Size = new System.Drawing.Size(592, 650);
            this.ucShowTechnicianInfo1.TabIndex = 29;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
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
            this.btnClose.Location = new System.Drawing.Point(215, 712);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(156, 45);
            this.btnClose.TabIndex = 32;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmShowTechnicianInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(589, 767);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ucShowTechnicianInfo1);
            this.Controls.Add(this.lblAllPersons);
            this.Name = "frmShowTechnicianInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show Technician Info";
            this.Load += new System.EventHandler(this.frmShowTechnicianInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAllPersons;
        private SCMSControlsLib.ucShowTechnicianInfo ucShowTechnicianInfo1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}