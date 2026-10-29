namespace Service_Center_Management_System__SCMS_
{
    partial class frmAddEditDiagnosis
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRepairOrderID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpECDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.gbInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblDeviceID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEstimatedCost = new SCMSControlsLib.cusTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTehnicianNotes = new SCMSControlsLib.cusTextBox();
            this.txtLaborCost = new SCMSControlsLib.cusTextBox();
            this.txtRequireParts = new SCMSControlsLib.cusTextBox();
            this.txtDetectedProblems = new SCMSControlsLib.cusTextBox();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.gbInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(210, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(295, 39);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add Edit Diagnosis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(24, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Repair Order ID :";
            // 
            // lblRepairOrderID
            // 
            this.lblRepairOrderID.AutoSize = true;
            this.lblRepairOrderID.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepairOrderID.ForeColor = System.Drawing.Color.Blue;
            this.lblRepairOrderID.Location = new System.Drawing.Point(275, 59);
            this.lblRepairOrderID.Name = "lblRepairOrderID";
            this.lblRepairOrderID.Size = new System.Drawing.Size(65, 31);
            this.lblRepairOrderID.TabIndex = 2;
            this.lblRepairOrderID.Text = "[???]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(24, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Detected Problems :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(24, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "Require Parts :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(24, 439);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 31);
            this.label5.TabIndex = 7;
            this.label5.Text = "Labor Cost :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(24, 505);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(315, 28);
            this.label6.TabIndex = 9;
            this.label6.Text = "Estimated Completion Date :";
            // 
            // dtpECDate
            // 
            this.dtpECDate.Checked = true;
            this.dtpECDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dtpECDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpECDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpECDate.Location = new System.Drawing.Point(346, 501);
            this.dtpECDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpECDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpECDate.Name = "dtpECDate";
            this.dtpECDate.Size = new System.Drawing.Size(230, 36);
            this.dtpECDate.TabIndex = 10;
            this.dtpECDate.Value = new System.DateTime(2026, 9, 21, 10, 36, 32, 493);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(24, 562);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(236, 31);
            this.label7.TabIndex = 11;
            this.label7.Text = "Technician Notes :";
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.lblDeviceID);
            this.gbInfo.Controls.Add(this.label9);
            this.gbInfo.Controls.Add(this.txtEstimatedCost);
            this.gbInfo.Controls.Add(this.label8);
            this.gbInfo.Controls.Add(this.txtTehnicianNotes);
            this.gbInfo.Controls.Add(this.label7);
            this.gbInfo.Controls.Add(this.dtpECDate);
            this.gbInfo.Controls.Add(this.label6);
            this.gbInfo.Controls.Add(this.txtLaborCost);
            this.gbInfo.Controls.Add(this.label5);
            this.gbInfo.Controls.Add(this.txtRequireParts);
            this.gbInfo.Controls.Add(this.label4);
            this.gbInfo.Controls.Add(this.txtDetectedProblems);
            this.gbInfo.Controls.Add(this.label3);
            this.gbInfo.Controls.Add(this.lblRepairOrderID);
            this.gbInfo.Controls.Add(this.label2);
            this.gbInfo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfo.ForeColor = System.Drawing.Color.Black;
            this.gbInfo.Location = new System.Drawing.Point(12, 57);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(706, 754);
            this.gbInfo.TabIndex = 1;
            this.gbInfo.Text = "Diagonsis ID = [???]";
            // 
            // lblDeviceID
            // 
            this.lblDeviceID.AutoSize = true;
            this.lblDeviceID.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeviceID.ForeColor = System.Drawing.Color.Blue;
            this.lblDeviceID.Location = new System.Drawing.Point(202, 109);
            this.lblDeviceID.Name = "lblDeviceID";
            this.lblDeviceID.Size = new System.Drawing.Size(65, 31);
            this.lblDeviceID.TabIndex = 16;
            this.lblDeviceID.Text = "[???]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(26, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 31);
            this.label9.TabIndex = 15;
            this.label9.Text = "Device ID :";
            // 
            // txtEstimatedCost
            // 
            this.txtEstimatedCost.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstimatedCost.IsRequired = true;
            this.txtEstimatedCost.Length = null;
            this.txtEstimatedCost.Location = new System.Drawing.Point(221, 700);
            this.txtEstimatedCost.Name = "txtEstimatedCost";
            this.txtEstimatedCost.Size = new System.Drawing.Size(227, 43);
            this.txtEstimatedCost.TabIndex = 14;
            this.txtEstimatedCost.WritingType = SCMSControlsLib.cusTextBox.enWritingType.Numbers;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(16, 702);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 43);
            this.label8.TabIndex = 13;
            this.label8.Text = "Estimated Cost :";
            // 
            // txtTehnicianNotes
            // 
            this.txtTehnicianNotes.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTehnicianNotes.IsRequired = false;
            this.txtTehnicianNotes.Length = null;
            this.txtTehnicianNotes.Location = new System.Drawing.Point(51, 596);
            this.txtTehnicianNotes.Multiline = true;
            this.txtTehnicianNotes.Name = "txtTehnicianNotes";
            this.txtTehnicianNotes.Size = new System.Drawing.Size(620, 75);
            this.txtTehnicianNotes.TabIndex = 12;
            this.txtTehnicianNotes.WritingType = SCMSControlsLib.cusTextBox.enWritingType.None;
            // 
            // txtLaborCost
            // 
            this.txtLaborCost.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLaborCost.IsRequired = true;
            this.txtLaborCost.Length = null;
            this.txtLaborCost.Location = new System.Drawing.Point(202, 430);
            this.txtLaborCost.Name = "txtLaborCost";
            this.txtLaborCost.Size = new System.Drawing.Size(233, 43);
            this.txtLaborCost.TabIndex = 8;
            this.txtLaborCost.WritingType = SCMSControlsLib.cusTextBox.enWritingType.Numbers;
            // 
            // txtRequireParts
            // 
            this.txtRequireParts.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequireParts.IsRequired = false;
            this.txtRequireParts.Length = null;
            this.txtRequireParts.Location = new System.Drawing.Point(51, 331);
            this.txtRequireParts.Multiline = true;
            this.txtRequireParts.Name = "txtRequireParts";
            this.txtRequireParts.Size = new System.Drawing.Size(620, 75);
            this.txtRequireParts.TabIndex = 6;
            this.txtRequireParts.WritingType = SCMSControlsLib.cusTextBox.enWritingType.None;
            // 
            // txtDetectedProblems
            // 
            this.txtDetectedProblems.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetectedProblems.IsRequired = true;
            this.txtDetectedProblems.Length = null;
            this.txtDetectedProblems.Location = new System.Drawing.Point(51, 203);
            this.txtDetectedProblems.Multiline = true;
            this.txtDetectedProblems.Name = "txtDetectedProblems";
            this.txtDetectedProblems.Size = new System.Drawing.Size(620, 75);
            this.txtDetectedProblems.TabIndex = 4;
            this.txtDetectedProblems.WritingType = SCMSControlsLib.cusTextBox.enWritingType.None;
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
            this.btnCancel.Location = new System.Drawing.Point(389, 817);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(156, 45);
            this.btnCancel.TabIndex = 42;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.btnSave.Location = new System.Drawing.Point(568, 818);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(157, 45);
            this.btnSave.TabIndex = 41;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddEditDiagnosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(735, 866);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmAddEditDiagnosis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Edit Diagnosis";
            this.Activated += new System.EventHandler(this.frmAddEditDiagnosis_Activated);
            this.Load += new System.EventHandler(this.frmAddEditDiagnosis_Load);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRepairOrderID;
        private System.Windows.Forms.Label label3;
        private SCMSControlsLib.cusTextBox txtDetectedProblems;
        private System.Windows.Forms.Label label4;
        private SCMSControlsLib.cusTextBox txtRequireParts;
        private System.Windows.Forms.Label label5;
        private SCMSControlsLib.cusTextBox txtLaborCost;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpECDate;
        private System.Windows.Forms.Label label7;
        private SCMSControlsLib.cusTextBox txtTehnicianNotes;
        private Guna.UI2.WinForms.Guna2GroupBox gbInfo;
        private SCMSControlsLib.cusTextBox txtEstimatedCost;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Label lblDeviceID;
        private System.Windows.Forms.Label label9;
    }
}