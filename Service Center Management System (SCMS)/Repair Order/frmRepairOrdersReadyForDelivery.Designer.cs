namespace Service_Center_Management_System__SCMS_
{
    partial class frmRepairOrdersReadyForDelivery
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
            this.ucRepairOrdersReadyForDelivery1 = new SCMSControlsLib.ucRepairOrdersReadyForDelivery();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // ucRepairOrdersReadyForDelivery1
            // 
            this.ucRepairOrdersReadyForDelivery1.Location = new System.Drawing.Point(-2, -3);
            this.ucRepairOrdersReadyForDelivery1.Name = "ucRepairOrdersReadyForDelivery1";
            this.ucRepairOrdersReadyForDelivery1.Size = new System.Drawing.Size(906, 401);
            this.ucRepairOrdersReadyForDelivery1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.BorderColor = System.Drawing.Color.Gainsboro;
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
            this.btnClose.Location = new System.Drawing.Point(373, 404);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(156, 45);
            this.btnClose.TabIndex = 32;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmRepairOrdersReadyForDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(907, 459);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ucRepairOrdersReadyForDelivery1);
            this.Name = "frmRepairOrdersReadyForDelivery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repair Orders Ready For Delivery";
            this.Load += new System.EventHandler(this.frmRepairOrdersReadyForDelivery_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private SCMSControlsLib.ucRepairOrdersReadyForDelivery ucRepairOrdersReadyForDelivery1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}