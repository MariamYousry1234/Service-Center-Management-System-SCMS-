namespace SCMSControlsLib
{
    partial class ucShowRepairCostDetailsWithEditing
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
            this.ucShowRepairCostDetails1 = new SCMSControlsLib.ucShowRepairCostDetails();
            this.label9 = new System.Windows.Forms.Label();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // ucShowRepairCostDetails1
            // 
            this.ucShowRepairCostDetails1.Location = new System.Drawing.Point(0, -2);
            this.ucShowRepairCostDetails1.Name = "ucShowRepairCostDetails1";
            this.ucShowRepairCostDetails1.Size = new System.Drawing.Size(596, 389);
            this.ucShowRepairCostDetails1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(132, 385);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(325, 30);
            this.label9.TabIndex = 36;
            this.label9.Text = "---------------------------------------";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnEdit.BorderRadius = 10;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEdit.Location = new System.Drawing.Point(174, 418);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(235, 45);
            this.btnEdit.TabIndex = 35;
            this.btnEdit.Text = "Edit Repair Cost";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // ucShowRepairCostDetailsWithEditing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.ucShowRepairCostDetails1);
            this.Name = "ucShowRepairCostDetailsWithEditing";
            this.Size = new System.Drawing.Size(596, 467);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ucShowRepairCostDetails ucShowRepairCostDetails1;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
    }
}
