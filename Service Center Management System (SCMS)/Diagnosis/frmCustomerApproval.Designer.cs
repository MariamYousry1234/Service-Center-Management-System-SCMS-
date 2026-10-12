namespace Service_Center_Management_System__SCMS_
{
    partial class frmCustomerApproval
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
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dtpApprovalDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.rbRejected = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbApproved = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ucShowDiagnosisDetails1 = new SCMSControlsLib.ucShowDiagnosisDetails();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.dtpApprovalDate);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.rbRejected);
            this.guna2GroupBox1.Controls.Add(this.rbApproved);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(1, 601);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(833, 128);
            this.guna2GroupBox1.TabIndex = 1;
            this.guna2GroupBox1.Text = "Customer Approval";
            // 
            // dtpApprovalDate
            // 
            this.dtpApprovalDate.Checked = true;
            this.dtpApprovalDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpApprovalDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpApprovalDate.Location = new System.Drawing.Point(654, 66);
            this.dtpApprovalDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpApprovalDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpApprovalDate.Name = "dtpApprovalDate";
            this.dtpApprovalDate.Size = new System.Drawing.Size(152, 36);
            this.dtpApprovalDate.TabIndex = 4;
            this.dtpApprovalDate.Value = new System.DateTime(2026, 9, 22, 13, 26, 10, 946);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(454, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Approval Date :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rbRejected
            // 
            this.rbRejected.AutoSize = true;
            this.rbRejected.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbRejected.CheckedState.BorderThickness = 0;
            this.rbRejected.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbRejected.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbRejected.CheckedState.InnerOffset = -4;
            this.rbRejected.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRejected.Location = new System.Drawing.Point(263, 71);
            this.rbRejected.Name = "rbRejected";
            this.rbRejected.Size = new System.Drawing.Size(105, 29);
            this.rbRejected.TabIndex = 2;
            this.rbRejected.Text = "Rejected";
            this.rbRejected.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbRejected.UncheckedState.BorderThickness = 2;
            this.rbRejected.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbRejected.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbApproved
            // 
            this.rbApproved.AutoSize = true;
            this.rbApproved.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbApproved.CheckedState.BorderThickness = 0;
            this.rbApproved.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbApproved.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbApproved.CheckedState.InnerOffset = -4;
            this.rbApproved.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbApproved.Location = new System.Drawing.Point(135, 71);
            this.rbApproved.Name = "rbApproved";
            this.rbApproved.Size = new System.Drawing.Size(119, 29);
            this.rbApproved.TabIndex = 1;
            this.rbApproved.Text = "Approved";
            this.rbApproved.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbApproved.UncheckedState.BorderThickness = 2;
            this.rbApproved.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbApproved.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbApproved.CheckedChanged += new System.EventHandler(this.rbApproved_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(29, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status :";
            // 
            // ucShowDiagnosisDetails1
            // 
            this.ucShowDiagnosisDetails1.Location = new System.Drawing.Point(0, 0);
            this.ucShowDiagnosisDetails1.Name = "ucShowDiagnosisDetails1";
            this.ucShowDiagnosisDetails1.Size = new System.Drawing.Size(837, 577);
            this.ucShowDiagnosisDetails1.TabIndex = 0;
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
            this.btnCancel.Location = new System.Drawing.Point(489, 740);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(156, 45);
            this.btnCancel.TabIndex = 42;
            this.btnCancel.Text = "Cancel";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderColor = System.Drawing.Color.White;
            this.btnSave.BorderRadius = 10;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Image = global::Service_Center_Management_System__SCMS_.Properties.Resources.people;
            this.btnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSave.Location = new System.Drawing.Point(668, 741);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(157, 45);
            this.btnSave.TabIndex = 41;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmCustomerApproval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(831, 795);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.ucShowDiagnosisDetails1);
            this.Name = "frmCustomerApproval";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Approval";
            this.Load += new System.EventHandler(this.frmCustomerApproval_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SCMSControlsLib.ucShowDiagnosisDetails ucShowDiagnosisDetails1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2RadioButton rbRejected;
        private Guna.UI2.WinForms.Guna2RadioButton rbApproved;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpApprovalDate;
        private System.Windows.Forms.Label label2;
    }
}