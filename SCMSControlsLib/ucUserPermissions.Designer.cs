namespace SCMSControlsLib
{
    partial class ucUserPermissions
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
            this.chkAllSystem = new System.Windows.Forms.CheckBox();
            this.gbAllPermissions = new System.Windows.Forms.GroupBox();
            this.chkPurchases = new System.Windows.Forms.CheckBox();
            this.chkSuppliers = new System.Windows.Forms.CheckBox();
            this.chkSpareParts = new System.Windows.Forms.CheckBox();
            this.gbRepairOrders = new System.Windows.Forms.GroupBox();
            this.chkROReadyForDelivery = new System.Windows.Forms.CheckBox();
            this.chkROReadyForInvoicing = new System.Windows.Forms.CheckBox();
            this.chkManageRepairOrder = new System.Windows.Forms.CheckBox();
            this.chkAddRepairOrder = new System.Windows.Forms.CheckBox();
            this.chkRepairOrders = new System.Windows.Forms.CheckBox();
            this.chkDeliveries = new System.Windows.Forms.CheckBox();
            this.chkInvoicesAndPayments = new System.Windows.Forms.CheckBox();
            this.chkDevices = new System.Windows.Forms.CheckBox();
            this.chkTechnicians = new System.Windows.Forms.CheckBox();
            this.chkUsers = new System.Windows.Forms.CheckBox();
            this.chkCustomers = new System.Windows.Forms.CheckBox();
            this.chkEmployees = new System.Windows.Forms.CheckBox();
            this.gbAllPermissions.SuspendLayout();
            this.gbRepairOrders.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkAllSystem
            // 
            this.chkAllSystem.AutoSize = true;
            this.chkAllSystem.Checked = true;
            this.chkAllSystem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAllSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAllSystem.Location = new System.Drawing.Point(23, 3);
            this.chkAllSystem.Name = "chkAllSystem";
            this.chkAllSystem.Size = new System.Drawing.Size(132, 29);
            this.chkAllSystem.TabIndex = 32;
            this.chkAllSystem.Text = "All System";
            this.chkAllSystem.UseVisualStyleBackColor = true;
            this.chkAllSystem.CheckedChanged += new System.EventHandler(this.chkAllSystem_CheckedChanged);
            // 
            // gbAllPermissions
            // 
            this.gbAllPermissions.Controls.Add(this.chkPurchases);
            this.gbAllPermissions.Controls.Add(this.chkSuppliers);
            this.gbAllPermissions.Controls.Add(this.chkSpareParts);
            this.gbAllPermissions.Controls.Add(this.gbRepairOrders);
            this.gbAllPermissions.Controls.Add(this.chkRepairOrders);
            this.gbAllPermissions.Controls.Add(this.chkDeliveries);
            this.gbAllPermissions.Controls.Add(this.chkInvoicesAndPayments);
            this.gbAllPermissions.Controls.Add(this.chkDevices);
            this.gbAllPermissions.Controls.Add(this.chkTechnicians);
            this.gbAllPermissions.Controls.Add(this.chkUsers);
            this.gbAllPermissions.Controls.Add(this.chkCustomers);
            this.gbAllPermissions.Controls.Add(this.chkEmployees);
            this.gbAllPermissions.Location = new System.Drawing.Point(1, 36);
            this.gbAllPermissions.Name = "gbAllPermissions";
            this.gbAllPermissions.Size = new System.Drawing.Size(608, 384);
            this.gbAllPermissions.TabIndex = 31;
            this.gbAllPermissions.TabStop = false;
            // 
            // chkPurchases
            // 
            this.chkPurchases.AutoSize = true;
            this.chkPurchases.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPurchases.Location = new System.Drawing.Point(392, 114);
            this.chkPurchases.Name = "chkPurchases";
            this.chkPurchases.Size = new System.Drawing.Size(133, 29);
            this.chkPurchases.TabIndex = 42;
            this.chkPurchases.Text = "Purchases";
            this.chkPurchases.UseVisualStyleBackColor = true;
            // 
            // chkSuppliers
            // 
            this.chkSuppliers.AutoSize = true;
            this.chkSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSuppliers.Location = new System.Drawing.Point(25, 160);
            this.chkSuppliers.Name = "chkSuppliers";
            this.chkSuppliers.Size = new System.Drawing.Size(121, 29);
            this.chkSuppliers.TabIndex = 41;
            this.chkSuppliers.Text = "Suppliers";
            this.chkSuppliers.UseVisualStyleBackColor = true;
            // 
            // chkSpareParts
            // 
            this.chkSpareParts.AutoSize = true;
            this.chkSpareParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSpareParts.Location = new System.Drawing.Point(201, 115);
            this.chkSpareParts.Name = "chkSpareParts";
            this.chkSpareParts.Size = new System.Drawing.Size(144, 29);
            this.chkSpareParts.TabIndex = 40;
            this.chkSpareParts.Text = "Spare Parts";
            this.chkSpareParts.UseVisualStyleBackColor = true;
            // 
            // gbRepairOrders
            // 
            this.gbRepairOrders.Controls.Add(this.chkROReadyForDelivery);
            this.gbRepairOrders.Controls.Add(this.chkROReadyForInvoicing);
            this.gbRepairOrders.Controls.Add(this.chkManageRepairOrder);
            this.gbRepairOrders.Controls.Add(this.chkAddRepairOrder);
            this.gbRepairOrders.Enabled = false;
            this.gbRepairOrders.Location = new System.Drawing.Point(19, 241);
            this.gbRepairOrders.Name = "gbRepairOrders";
            this.gbRepairOrders.Size = new System.Drawing.Size(577, 129);
            this.gbRepairOrders.TabIndex = 39;
            this.gbRepairOrders.TabStop = false;
            // 
            // chkROReadyForDelivery
            // 
            this.chkROReadyForDelivery.AutoSize = true;
            this.chkROReadyForDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkROReadyForDelivery.Location = new System.Drawing.Point(9, 94);
            this.chkROReadyForDelivery.Name = "chkROReadyForDelivery";
            this.chkROReadyForDelivery.Size = new System.Drawing.Size(344, 29);
            this.chkROReadyForDelivery.TabIndex = 42;
            this.chkROReadyForDelivery.Text = "Repair Order Ready For Delivery";
            this.chkROReadyForDelivery.UseVisualStyleBackColor = true;
            // 
            // chkROReadyForInvoicing
            // 
            this.chkROReadyForInvoicing.AutoSize = true;
            this.chkROReadyForInvoicing.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkROReadyForInvoicing.Location = new System.Drawing.Point(10, 55);
            this.chkROReadyForInvoicing.Name = "chkROReadyForInvoicing";
            this.chkROReadyForInvoicing.Size = new System.Drawing.Size(351, 29);
            this.chkROReadyForInvoicing.TabIndex = 41;
            this.chkROReadyForInvoicing.Text = "Repair Order Ready For Invoicing";
            this.chkROReadyForInvoicing.UseVisualStyleBackColor = true;
            // 
            // chkManageRepairOrder
            // 
            this.chkManageRepairOrder.AutoSize = true;
            this.chkManageRepairOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkManageRepairOrder.Location = new System.Drawing.Point(304, 16);
            this.chkManageRepairOrder.Name = "chkManageRepairOrder";
            this.chkManageRepairOrder.Size = new System.Drawing.Size(238, 29);
            this.chkManageRepairOrder.TabIndex = 40;
            this.chkManageRepairOrder.Text = "Manage Repair Order";
            this.chkManageRepairOrder.UseVisualStyleBackColor = true;
            // 
            // chkAddRepairOrder
            // 
            this.chkAddRepairOrder.AutoSize = true;
            this.chkAddRepairOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAddRepairOrder.Location = new System.Drawing.Point(11, 16);
            this.chkAddRepairOrder.Name = "chkAddRepairOrder";
            this.chkAddRepairOrder.Size = new System.Drawing.Size(198, 29);
            this.chkAddRepairOrder.TabIndex = 39;
            this.chkAddRepairOrder.Text = "Add Repair Order";
            this.chkAddRepairOrder.UseVisualStyleBackColor = true;
            // 
            // chkRepairOrders
            // 
            this.chkRepairOrders.AutoSize = true;
            this.chkRepairOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRepairOrders.Location = new System.Drawing.Point(27, 207);
            this.chkRepairOrders.Name = "chkRepairOrders";
            this.chkRepairOrders.Size = new System.Drawing.Size(165, 29);
            this.chkRepairOrders.TabIndex = 38;
            this.chkRepairOrders.Text = "Repair Orders";
            this.chkRepairOrders.UseVisualStyleBackColor = true;
            this.chkRepairOrders.CheckedChanged += new System.EventHandler(this.chkRepairOrders_CheckedChanged);
            // 
            // chkDeliveries
            // 
            this.chkDeliveries.AutoSize = true;
            this.chkDeliveries.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDeliveries.Location = new System.Drawing.Point(26, 113);
            this.chkDeliveries.Name = "chkDeliveries";
            this.chkDeliveries.Size = new System.Drawing.Size(126, 29);
            this.chkDeliveries.TabIndex = 37;
            this.chkDeliveries.Text = "Deliveries";
            this.chkDeliveries.UseVisualStyleBackColor = true;
            // 
            // chkInvoicesAndPayments
            // 
            this.chkInvoicesAndPayments.AutoSize = true;
            this.chkInvoicesAndPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInvoicesAndPayments.Location = new System.Drawing.Point(366, 70);
            this.chkInvoicesAndPayments.Name = "chkInvoicesAndPayments";
            this.chkInvoicesAndPayments.Size = new System.Drawing.Size(231, 29);
            this.chkInvoicesAndPayments.TabIndex = 36;
            this.chkInvoicesAndPayments.Text = "Invoices && Payments";
            this.chkInvoicesAndPayments.UseVisualStyleBackColor = true;
            // 
            // chkDevices
            // 
            this.chkDevices.AutoSize = true;
            this.chkDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDevices.Location = new System.Drawing.Point(201, 69);
            this.chkDevices.Name = "chkDevices";
            this.chkDevices.Size = new System.Drawing.Size(108, 29);
            this.chkDevices.TabIndex = 35;
            this.chkDevices.Text = "Devices";
            this.chkDevices.UseVisualStyleBackColor = true;
            // 
            // chkTechnicians
            // 
            this.chkTechnicians.AutoSize = true;
            this.chkTechnicians.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTechnicians.Location = new System.Drawing.Point(25, 66);
            this.chkTechnicians.Name = "chkTechnicians";
            this.chkTechnicians.Size = new System.Drawing.Size(147, 29);
            this.chkTechnicians.TabIndex = 34;
            this.chkTechnicians.Text = "Technicians";
            this.chkTechnicians.UseVisualStyleBackColor = true;
            // 
            // chkUsers
            // 
            this.chkUsers.AutoSize = true;
            this.chkUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUsers.Location = new System.Drawing.Point(373, 21);
            this.chkUsers.Name = "chkUsers";
            this.chkUsers.Size = new System.Drawing.Size(87, 29);
            this.chkUsers.TabIndex = 33;
            this.chkUsers.Text = "Users";
            this.chkUsers.UseVisualStyleBackColor = true;
            // 
            // chkCustomers
            // 
            this.chkCustomers.AutoSize = true;
            this.chkCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCustomers.Location = new System.Drawing.Point(199, 19);
            this.chkCustomers.Name = "chkCustomers";
            this.chkCustomers.Size = new System.Drawing.Size(134, 29);
            this.chkCustomers.TabIndex = 32;
            this.chkCustomers.Text = "Customers";
            this.chkCustomers.UseVisualStyleBackColor = true;
            // 
            // chkEmployees
            // 
            this.chkEmployees.AutoSize = true;
            this.chkEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEmployees.Location = new System.Drawing.Point(25, 19);
            this.chkEmployees.Name = "chkEmployees";
            this.chkEmployees.Size = new System.Drawing.Size(137, 29);
            this.chkEmployees.TabIndex = 31;
            this.chkEmployees.Text = "Employees";
            this.chkEmployees.UseVisualStyleBackColor = true;
            // 
            // ucUserPermissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.chkAllSystem);
            this.Controls.Add(this.gbAllPermissions);
            this.Name = "ucUserPermissions";
            this.Size = new System.Drawing.Size(609, 421);
            this.gbAllPermissions.ResumeLayout(false);
            this.gbAllPermissions.PerformLayout();
            this.gbRepairOrders.ResumeLayout(false);
            this.gbRepairOrders.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkAllSystem;
        private System.Windows.Forms.GroupBox gbAllPermissions;
        private System.Windows.Forms.CheckBox chkPurchases;
        private System.Windows.Forms.CheckBox chkSuppliers;
        private System.Windows.Forms.CheckBox chkSpareParts;
        private System.Windows.Forms.GroupBox gbRepairOrders;
        private System.Windows.Forms.CheckBox chkROReadyForDelivery;
        private System.Windows.Forms.CheckBox chkROReadyForInvoicing;
        private System.Windows.Forms.CheckBox chkManageRepairOrder;
        private System.Windows.Forms.CheckBox chkAddRepairOrder;
        private System.Windows.Forms.CheckBox chkRepairOrders;
        private System.Windows.Forms.CheckBox chkDeliveries;
        private System.Windows.Forms.CheckBox chkInvoicesAndPayments;
        private System.Windows.Forms.CheckBox chkDevices;
        private System.Windows.Forms.CheckBox chkTechnicians;
        private System.Windows.Forms.CheckBox chkUsers;
        private System.Windows.Forms.CheckBox chkCustomers;
        private System.Windows.Forms.CheckBox chkEmployees;
    }
}
