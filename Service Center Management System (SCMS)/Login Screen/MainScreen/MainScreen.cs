using SCMS_Business_Logic;
using SharedLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service_Center_Management_System__SCMS_
{
    public partial class MainScreen : Form
    {
        frmLoginScreen _frmLogin;

        private string ApplicationName = ConfigurationManager.AppSettings["ApplicationName"];

        public MainScreen(frmLoginScreen frmLogin)
        {
            InitializeComponent();
 
           _frmLogin = frmLogin;
        }

     
        private void manageDeviceTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.HavePermissions(clsUser.enPermissions.Devices))
            {
                MessageBox.Show(
                 "You do not have permission to manage devices.",
                 "Access Denied",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning);

                return;
            }

            frmManageDeviceTypes frm = new frmManageDeviceTypes();

            frm.ShowDialog();
        }

        private void manageBrandsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.HavePermissions(clsUser.enPermissions.Devices))
            {
                MessageBox.Show(
                 "You do not have permission to manage devices.",
                 "Access Denied",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning);

                return;
            }

            frmManageBands frm = new frmManageBands();

            frm.ShowDialog();
        }

        private void manageModelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.HavePermissions(clsUser.enPermissions.Devices))
            {
                MessageBox.Show(
                 "You do not have permission to manage devices.",
                 "Access Denied",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning);

                return;
            }

            frmManageModels frm = new frmManageModels();
            frm.ShowDialog();
        }

        private void manageDevicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.HavePermissions(clsUser.enPermissions.Devices))
            {
                MessageBox.Show(
                 "You do not have permission to manage devices.",
                 "Access Denied",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning);

                return;
            }

            frmManageDevices frm = new frmManageDevices();
            frm.ShowDialog();
        }

        private void manageRepairOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.HavePermissions(clsUser.enPermissions.ManageRepairOrder))
            {
                MessageBox.Show(
                 "You do not have permission to manage repair orders.",
                 "Access Denied",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning);

                return;
            }
            frmManageRepairOrders frm = new frmManageRepairOrders();

            frm.ShowDialog();
        }

        private void addRepairOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.HavePermissions(clsUser.enPermissions.AddRepairOrder))
            {
                MessageBox.Show(
                 "You do not have permission to add repair order.",
                 "Access Denied",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning);

                return;
            }

            frmAddEditRepairOrder frm = new frmAddEditRepairOrder();

            frm.ShowDialog();
        }

        private void manageSparePartsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.HavePermissions(clsUser.enPermissions.SpareParts))
            {
                MessageBox.Show(
                 "You do not have permission to manage spare parts.",
                 "Access Denied",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning);

                return;
            }
            frmManageSpareParts frm = new frmManageSpareParts();

            frm.ShowDialog();
        }

      
      

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.HavePermissions(clsUser.enPermissions.Suppliers))
            {
                MessageBox.Show(
                 "You do not have permission to manage suppliers.",
                 "Access Denied",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning);

                return;
            }
            frmManageSuppliers frm = new frmManageSuppliers();

            frm.ShowDialog();
        }

        private void purchasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void diagnosesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.HavePermissions(clsUser.enPermissions.ManageRepairOrder))
            {
                MessageBox.Show(
                 "You do not have permission to manage diagnosis.",
                 "Access Denied",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning);

                return;
            }
            frmManageDiagnoses frm = new frmManageDiagnoses();

            frm.ShowDialog();
        }

     
        private void partBrandsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.HavePermissions(clsUser.enPermissions.SpareParts))
            {
                MessageBox.Show(
                 "You do not have permission to manage spare parts.",
                 "Access Denied",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning);

                return;
            }
            frmManagePartBrands frm = new frmManagePartBrands();

            frm.ShowDialog();
        }

        private void partCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.HavePermissions(clsUser.enPermissions.SpareParts))
            {
                MessageBox.Show(
                 "You do not have permission to manage spare parts.",
                 "Access Denied",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning);

                return;
            }
            frmManagePartCategories frm = new frmManagePartCategories();

            frm.ShowDialog();
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.HavePermissions(clsUser.enPermissions.Employees))
            {
                MessageBox.Show(
                 "You do not have permission to manage employees.",
                 "Access Denied",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning);

                return;
            }


            frmManageEmployees frm = new frmManageEmployees();

            frm.ShowDialog();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.HavePermissions(clsUser.enPermissions.Customers))
            {
                MessageBox.Show(
                 "You do not have permission to manage customers.",
                 "Access Denied",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning);

                return;
            }
            frmManageCustomers frm = new frmManageCustomers();


            frm.ShowDialog();

        }

        private void techniciansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.HavePermissions(clsUser.enPermissions.Technicians))
            {
                MessageBox.Show(
                 "You do not have permission to manage technicians.",
                 "Access Denied",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning);

                return;
            }
            frmManageTechnicians frm = new frmManageTechnicians();

            frm.ShowDialog();
        }

        private void manageInvoicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.HavePermissions(clsUser.enPermissions.InvoicesAndPayments))
            {
                MessageBox.Show(
                 "You do not have permission to manage invoices and payments.",
                 "Access Denied",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning);

                return;
            }
            frmManageInvoices frm = new frmManageInvoices();

            frm.ShowDialog();
        }

        private void repairOrdersReadyForInvoicingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.HavePermissions(clsUser.enPermissions.ROReadyForInvoicing))
            {
                MessageBox.Show(
                 "You do not have permission to manage repair orders ready for invoicing.",
                 "Access Denied",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning);

                return;
            }

            frmRepairOrdersReadyForInvoicing frm =
                new frmRepairOrdersReadyForInvoicing();

            frm.ShowDialog();
        }

        private void invoicesAwaitingPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.HavePermissions(clsUser.enPermissions.InvoicesAndPayments))
            {
                MessageBox.Show(
                 "You do not have permission to manage invoices and payments.",
                 "Access Denied",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning);

                return;
            }

            frmInvoicesAwaitingPayment frm = new frmInvoicesAwaitingPayment();

            frm.ShowDialog();
        }

       
        private void repairOrdersReadyForDeliveryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.HavePermissions(clsUser.enPermissions.ROReadyForDelivery))
            {
                MessageBox.Show(
                 "You do not have permission to manage repair orders ready for delivery.",
                 "Access Denied",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning);

                return;
            }

            frmRepairOrdersReadyForDelivery frm = 
                new frmRepairOrdersReadyForDelivery();

            frm.ShowDialog();
        }

        private void deliveriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.HavePermissions(clsUser.enPermissions.Deliveries))
            {
                MessageBox.Show(
                 "You do not have permission to manage deliveries.",
                 "Access Denied",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning);

                return;
            }

            frmManageDeliveries frm = new frmManageDeliveries();

            frm.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword(clsGlobal.CurrentUser.UserID);

            frm.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsEventLogger.WriteEntryToEventLog(ApplicationName,
                $"User with username = {clsGlobal.CurrentUser.Username} logged out of SCMS successfully",
                System.Diagnostics.EventLogEntryType.Information);


            clsGlobal.CurrentUser = null;
            _frmLogin.Show();
            this.Close();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.HavePermissions(clsUser.enPermissions.Users))
            {
                MessageBox.Show(
                 "You do not have permission to manage users.",
                 "Access Denied",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning);

                return;
            }
            frmManageUsers frm = new frmManageUsers();
            frm.ShowDialog();
        }

        private void devicesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void createSparePartPurchaseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.HavePermissions(clsUser.enPermissions.Puchases))
            {
                MessageBox.Show(
                 "You do not have permission to manage purchases.",
                 "Access Denied",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning);

                return;
            }
            frmCreateSparePartPurchase frm = new frmCreateSparePartPurchase();

            frm.ShowDialog();

        }

        private void managePuchasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.HavePermissions(clsUser.enPermissions.Puchases))
            {
                MessageBox.Show(
                 "You do not have permission to manage purchases.",
                 "Access Denied",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning);

                return;
            }
            frmManagePurchases frm = new frmManagePurchases();

            frm.ShowDialog();
        }

        private void invoicesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
