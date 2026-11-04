namespace SCMSControlsLib
{
    partial class ucShowDeviceTypeInfo
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
            this.lblDeviceTypeName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDeviceTypeID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.lblDeviceTypeName);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.lblDeviceTypeID);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(3, 3);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(591, 229);
            this.guna2GroupBox1.TabIndex = 0;
            this.guna2GroupBox1.Text = "Device Type Information";
            // 
            // lblDeviceTypeName
            // 
            this.lblDeviceTypeName.AutoSize = true;
            this.lblDeviceTypeName.BackColor = System.Drawing.Color.Transparent;
            this.lblDeviceTypeName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeviceTypeName.Location = new System.Drawing.Point(288, 140);
            this.lblDeviceTypeName.Name = "lblDeviceTypeName";
            this.lblDeviceTypeName.Size = new System.Drawing.Size(73, 37);
            this.lblDeviceTypeName.TabIndex = 3;
            this.lblDeviceTypeName.Text = "[???]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Device Type Name :";
            // 
            // lblDeviceTypeID
            // 
            this.lblDeviceTypeID.AutoSize = true;
            this.lblDeviceTypeID.BackColor = System.Drawing.Color.Transparent;
            this.lblDeviceTypeID.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeviceTypeID.Location = new System.Drawing.Point(291, 75);
            this.lblDeviceTypeID.Name = "lblDeviceTypeID";
            this.lblDeviceTypeID.Size = new System.Drawing.Size(73, 37);
            this.lblDeviceTypeID.TabIndex = 1;
            this.lblDeviceTypeID.Text = "[???]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Device Type ID :";
            // 
            // ucShowDeviceTypeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2GroupBox1);
            this.Name = "ucShowDeviceTypeInfo";
            this.Size = new System.Drawing.Size(594, 234);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDeviceTypeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDeviceTypeID;
    }
}
