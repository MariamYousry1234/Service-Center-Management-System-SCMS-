using SCMS_Business_Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCMSControlsLib
{
    public partial class ucUserPermissions : UserControl
    {
     
        public ucUserPermissions()
        {
            InitializeComponent();


            chkAllSystem.Enabled = true;

            gbAllPermissions.Enabled = false;
        }

        public int? UserPermissions
        {
            get
            {
                if (!_IsValid())
                    return null;

               return _GetUserPermissions();

            }
        }


        private int _GetUserPermissions()
        {
            int Permissions = 0;

            if (chkAllSystem.Checked)
                Permissions = -1;
            else
            {
                if (chkEmployees.Checked)
                {
                   Permissions = Permissions | (int)clsUser.enPermissions.Employees;

                }

                if (chkCustomers.Checked)
                {
                    Permissions = Permissions | (int)clsUser.enPermissions.Customers;
                }

                if (chkUsers.Checked)
                {
                   Permissions = Permissions | (int)clsUser.enPermissions.Users;
                }

                if (chkTechnicians.Checked)
                {
                    Permissions =Permissions | (int)clsUser.enPermissions.Technicians;
                }

                if (chkDevices.Checked)
                {
                    Permissions = Permissions | (int)clsUser.enPermissions.Devices;
                }

                if (chkInvoicesAndPayments.Checked)
                {
                    Permissions = Permissions | (int)clsUser.enPermissions.InvoicesAndPayments;
                }

                if (chkDeliveries.Checked)
                {
                    Permissions = Permissions | (int)clsUser.enPermissions.Deliveries;
                }

                if (chkSpareParts.Checked)
                {
                    Permissions = Permissions | (int)clsUser.enPermissions.SpareParts;
                }

                if (chkPurchases.Checked)
                {
                    Permissions =Permissions | (int)clsUser.enPermissions.Puchases;
                }

                if (chkSuppliers.Checked)
                {
                   Permissions =Permissions | (int)clsUser.enPermissions.Suppliers;
                }

                if (chkRepairOrders.Checked)
                {

                    if (chkAddRepairOrder.Checked)
                    {
                        Permissions =Permissions | (int)clsUser.enPermissions.AddRepairOrder;
                    }

                    if (chkManageRepairOrder.Checked)
                    {
                       Permissions = Permissions | (int)clsUser.enPermissions.ManageRepairOrder;
                    }

                    if (chkROReadyForInvoicing.Checked)
                    {
                        Permissions =Permissions | (int)clsUser.enPermissions.ROReadyForInvoicing;
                    }

                    if (chkROReadyForDelivery.Checked)
                    {
                        Permissions = Permissions | (int)clsUser.enPermissions.ROReadyForDelivery;
                    }
                }


            }

            return Permissions;

        }
        private void chkAllSystem_CheckedChanged(object sender, EventArgs e)
        { 
           gbAllPermissions.Enabled = !chkAllSystem.Checked;
      
        }

        private void chkRepairOrders_CheckedChanged(object sender, EventArgs e)
        {
            gbRepairOrders.Enabled = chkRepairOrders.Checked;
      
        }


        private bool _IsValid()
        {
            if(gbAllPermissions.Enabled)
            {
                if (!chkEmployees.Checked &&
                    !chkCustomers.Checked &&
                    !chkUsers.Checked &&
                    !chkTechnicians.Checked &&
                    !chkDevices.Checked &&
                    !chkInvoicesAndPayments.Checked &&
                    !chkDeliveries.Checked &&
                    !chkSpareParts.Checked &&
                    !chkPurchases.Checked &&
                    !chkSuppliers.Checked &&
                    !chkRepairOrders.Checked) return false;

            }

            if(gbRepairOrders.Enabled)
            {

                if (!chkAddRepairOrder.Checked &&
                    !chkManageRepairOrder.Checked &&
                    !chkROReadyForInvoicing.Checked &&
                    !chkROReadyForDelivery.Checked) return false;

            }

            return true;
        }

        
        public void LoadUserPermissions(int UserPermissions)
        {
            if(UserPermissions ==-1)
            {
                chkAllSystem.Checked = true;
            }
            else
            {
                chkAllSystem.Checked = false;

                chkEmployees.Checked =
                    (UserPermissions & (int)clsUser.enPermissions.Employees) 
                    == (int)clsUser.enPermissions.Employees;


                chkCustomers.Checked =
                    (UserPermissions & (int)clsUser.enPermissions.Customers)
                        == (int)clsUser.enPermissions.Customers;

                chkUsers.Checked =
                    (UserPermissions & (int)clsUser.enPermissions.Users)
                    == (int)clsUser.enPermissions.Users;

                chkTechnicians.Checked =
                    (UserPermissions & (int)clsUser.enPermissions.Technicians)
                    == (int)clsUser.enPermissions.Technicians;

                chkDevices.Checked =
                    (UserPermissions & (int)clsUser.enPermissions.Devices)
                    == (int)clsUser.enPermissions.Devices;

                chkInvoicesAndPayments.Checked =
                    (UserPermissions & (int)clsUser.enPermissions.InvoicesAndPayments)
                    == (int)clsUser.enPermissions.InvoicesAndPayments;

                chkDeliveries.Checked =
                    (UserPermissions & (int)clsUser.enPermissions.Deliveries)
                    == (int)clsUser.enPermissions.Deliveries;

                chkSpareParts.Checked =
                    (UserPermissions & (int)clsUser.enPermissions.SpareParts)
                    == (int)clsUser.enPermissions.SpareParts;

                chkPurchases.Checked =
                    (UserPermissions & (int)clsUser.enPermissions.Puchases)
                    == (int)clsUser.enPermissions.Puchases;

                chkSuppliers.Checked =
                    (UserPermissions & (int)clsUser.enPermissions.Suppliers)
                    == (int)clsUser.enPermissions.Suppliers;


                chkAddRepairOrder.Checked=
                    (UserPermissions & (int)clsUser.enPermissions.AddRepairOrder)
                    == (int)clsUser.enPermissions.AddRepairOrder;


                chkManageRepairOrder.Checked =
                           (UserPermissions & (int)clsUser.enPermissions.ManageRepairOrder)
                            == (int)clsUser.enPermissions.ManageRepairOrder;

                chkROReadyForInvoicing.Checked =
                      (UserPermissions & (int)clsUser.enPermissions.ROReadyForInvoicing)
                           == (int)clsUser.enPermissions.ROReadyForInvoicing;

                chkROReadyForDelivery.Checked =
                    (UserPermissions & (int)clsUser.enPermissions.ROReadyForDelivery)
                           == (int)clsUser.enPermissions.ROReadyForDelivery;

                chkRepairOrders.Checked =
                    chkAddRepairOrder.Checked || chkManageRepairOrder.Checked
                    || chkROReadyForInvoicing.Checked || chkROReadyForDelivery.Checked;

            }



        }
    }
}
