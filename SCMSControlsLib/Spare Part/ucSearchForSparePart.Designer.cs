namespace SCMSControlsLib
{
    partial class ucSearchForSparePart
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
            this.gbSearch = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtSearch = new SCMSControlsLib.cusTextBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.cbField = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtTitle = new System.Windows.Forms.Label();
            this.ucShowSparePartDetails1 = new SCMSControlsLib.ucShowSparePartDetails();
            this.gbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.txtSearch);
            this.gbSearch.Controls.Add(this.btnSearch);
            this.gbSearch.Controls.Add(this.cbField);
            this.gbSearch.Controls.Add(this.txtTitle);
            this.gbSearch.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbSearch.Location = new System.Drawing.Point(-1, 0);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(765, 101);
            this.gbSearch.TabIndex = 3;
            this.gbSearch.Text = "Search 🔍";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.IsRequired = true;
            this.txtSearch.Length = null;
            this.txtSearch.Location = new System.Drawing.Point(355, 53);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(261, 35);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.WritingType = SCMSControlsLib.cusTextBox.enWritingType.None;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.BorderColor = System.Drawing.Color.White;
            this.btnSearch.BorderRadius = 10;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Image = global::SCMSControlsLib.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(673, 44);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(58, 45);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbField
            // 
            this.cbField.BackColor = System.Drawing.Color.Transparent;
            this.cbField.BorderThickness = 5;
            this.cbField.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbField.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbField.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbField.ItemHeight = 30;
            this.cbField.Items.AddRange(new object[] {
            "Part ID",
            "Part Name"});
            this.cbField.Location = new System.Drawing.Point(163, 53);
            this.cbField.Name = "cbField";
            this.cbField.Size = new System.Drawing.Size(172, 36);
            this.cbField.TabIndex = 1;
            this.cbField.SelectedIndexChanged += new System.EventHandler(this.cbField_SelectedIndexChanged);
            // 
            // txtTitle
            // 
            this.txtTitle.AutoSize = true;
            this.txtTitle.BackColor = System.Drawing.Color.Transparent;
            this.txtTitle.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.Color.Black;
            this.txtTitle.Location = new System.Drawing.Point(48, 60);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(110, 23);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.Text = "Search By :";
            // 
            // ucShowSparePartDetails1
            // 
            this.ucShowSparePartDetails1.Location = new System.Drawing.Point(-2, 101);
            this.ucShowSparePartDetails1.Name = "ucShowSparePartDetails1";
            this.ucShowSparePartDetails1.Size = new System.Drawing.Size(764, 437);
            this.ucShowSparePartDetails1.TabIndex = 4;
            // 
            // ucSearchForSparePart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucShowSparePartDetails1);
            this.Controls.Add(this.gbSearch);
            this.Name = "ucSearchForSparePart";
            this.Size = new System.Drawing.Size(762, 537);
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gbSearch;
        private cusTextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cbField;
        private System.Windows.Forms.Label txtTitle;
        private ucShowSparePartDetails ucShowSparePartDetails1;
    }
}
