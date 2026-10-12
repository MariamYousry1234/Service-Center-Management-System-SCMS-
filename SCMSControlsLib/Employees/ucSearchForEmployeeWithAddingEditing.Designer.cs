namespace SCMSControlsLib
{
    partial class ucSearchForEmployeeWithAddingEditing
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddEditEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.lblSep2 = new System.Windows.Forms.Label();
            this.lblOr = new System.Windows.Forms.Label();
            this.lblSep1 = new System.Windows.Forms.Label();
            this.ucSearchForAnEmployee1 = new SCMSControlsLib.ucSearchForAnEmployee();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnAddEditEmployee);
            this.groupBox1.Controls.Add(this.lblSep2);
            this.groupBox1.Controls.Add(this.lblOr);
            this.groupBox1.Controls.Add(this.lblSep1);
            this.groupBox1.Controls.Add(this.ucSearchForAnEmployee1);
            this.groupBox1.Location = new System.Drawing.Point(-1, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 665);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // btnAddEditEmployee
            // 
            this.btnAddEditEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btnAddEditEmployee.BorderColor = System.Drawing.Color.White;
            this.btnAddEditEmployee.BorderRadius = 10;
            this.btnAddEditEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddEditEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddEditEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddEditEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddEditEmployee.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAddEditEmployee.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEditEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnAddEditEmployee.HoverState.CustomBorderColor = System.Drawing.Color.Red;
            this.btnAddEditEmployee.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAddEditEmployee.Location = new System.Drawing.Point(157, 616);
            this.btnAddEditEmployee.Name = "btnAddEditEmployee";
            this.btnAddEditEmployee.Size = new System.Drawing.Size(268, 45);
            this.btnAddEditEmployee.TabIndex = 16;
            this.btnAddEditEmployee.Text = "Add New Employee";
            this.btnAddEditEmployee.Click += new System.EventHandler(this.btnAddEditEmployee_Click);
            // 
            // lblSep2
            // 
            this.lblSep2.AutoSize = true;
            this.lblSep2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSep2.ForeColor = System.Drawing.Color.Blue;
            this.lblSep2.Location = new System.Drawing.Point(302, 586);
            this.lblSep2.Name = "lblSep2";
            this.lblSep2.Size = new System.Drawing.Size(76, 25);
            this.lblSep2.TabIndex = 19;
            this.lblSep2.Text = "--------";
            // 
            // lblOr
            // 
            this.lblOr.AutoSize = true;
            this.lblOr.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOr.ForeColor = System.Drawing.Color.Blue;
            this.lblOr.Location = new System.Drawing.Point(259, 576);
            this.lblOr.Name = "lblOr";
            this.lblOr.Size = new System.Drawing.Size(54, 37);
            this.lblOr.TabIndex = 18;
            this.lblOr.Text = "Or";
            // 
            // lblSep1
            // 
            this.lblSep1.AutoSize = true;
            this.lblSep1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSep1.ForeColor = System.Drawing.Color.Blue;
            this.lblSep1.Location = new System.Drawing.Point(188, 586);
            this.lblSep1.Name = "lblSep1";
            this.lblSep1.Size = new System.Drawing.Size(76, 25);
            this.lblSep1.TabIndex = 17;
            this.lblSep1.Text = "--------";
            // 
            // ucSearchForAnEmployee1
            // 
            this.ucSearchForAnEmployee1.gbEnabled = true;
            this.ucSearchForAnEmployee1.Location = new System.Drawing.Point(-2, 0);
            this.ucSearchForAnEmployee1.Name = "ucSearchForAnEmployee1";
            this.ucSearchForAnEmployee1.Size = new System.Drawing.Size(594, 576);
            this.ucSearchForAnEmployee1.TabIndex = 0;
            // 
            // ucSearchForEmployeeWithAddingEditing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ucSearchForEmployeeWithAddingEditing";
            this.Size = new System.Drawing.Size(590, 661);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Button btnAddEditEmployee;
        private System.Windows.Forms.Label lblSep2;
        private System.Windows.Forms.Label lblOr;
        private System.Windows.Forms.Label lblSep1;
        private ucSearchForAnEmployee ucSearchForAnEmployee1;
    }
}
