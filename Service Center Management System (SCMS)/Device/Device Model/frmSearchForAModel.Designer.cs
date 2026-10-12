namespace Service_Center_Management_System__SCMS_
{
    partial class frmSearchForAModel
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
            this.ucSearchForAModel1 = new SCMSControlsLib.ucSearchForAModel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // ucSearchForAModel1
            // 
            this.ucSearchForAModel1.Location = new System.Drawing.Point(0, 0);
            this.ucSearchForAModel1.Name = "ucSearchForAModel1";
            this.ucSearchForAModel1.Size = new System.Drawing.Size(521, 456);
            this.ucSearchForAModel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderColor = System.Drawing.Color.LightGray;
            this.btnClose.BorderRadius = 10;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Silver;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Image = global::Service_Center_Management_System__SCMS_.Properties.Resources.close;
            this.btnClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClose.Location = new System.Drawing.Point(174, 464);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(156, 45);
            this.btnClose.TabIndex = 41;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmSearchForAModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(518, 518);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ucSearchForAModel1);
            this.Name = "frmSearchForAModel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search For A Model";
            this.ResumeLayout(false);

        }

        #endregion

        private SCMSControlsLib.ucSearchForAModel ucSearchForAModel1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}