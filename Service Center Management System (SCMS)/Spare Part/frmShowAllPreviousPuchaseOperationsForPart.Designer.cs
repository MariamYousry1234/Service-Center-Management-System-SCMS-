namespace Service_Center_Management_System__SCMS_
{
    partial class frmShowAllPreviousPuchaseOperationsForPart
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
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.ucShowAllPreviousOperationsForPart1 = new SCMSControlsLib.ucShowAllPreviousOperationsForPart();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.BorderColor = System.Drawing.Color.White;
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.LightGray;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Image = global::Service_Center_Management_System__SCMS_.Properties.Resources.close;
            this.btnCancel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCancel.Location = new System.Drawing.Point(442, 350);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(156, 45);
            this.btnCancel.TabIndex = 45;
            this.btnCancel.Text = "Close";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ucShowAllPreviousOperationsForPart1
            // 
            this.ucShowAllPreviousOperationsForPart1.Location = new System.Drawing.Point(-1, -2);
            this.ucShowAllPreviousOperationsForPart1.Name = "ucShowAllPreviousOperationsForPart1";
            this.ucShowAllPreviousOperationsForPart1.Size = new System.Drawing.Size(1043, 330);
            this.ucShowAllPreviousOperationsForPart1.TabIndex = 0;
            // 
            // frmShowAllPreviousPuchaseOperationsForPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1042, 407);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.ucShowAllPreviousOperationsForPart1);
            this.Name = "frmShowAllPreviousPuchaseOperationsForPart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show All Previous Puchase Operations For Part";
            this.Load += new System.EventHandler(this.frmShowAllPreviousPuchaseOperationsForPart_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private SCMSControlsLib.ucShowAllPreviousOperationsForPart ucShowAllPreviousOperationsForPart1;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
    }
}