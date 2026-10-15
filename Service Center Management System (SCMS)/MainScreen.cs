using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public MainScreen(frmLoginScreen frmLogin)
        {
            InitializeComponent();

            _frmLogin = frmLogin;
        }

     
        private void manageDeviceTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageDeviceTypes frm = new frmManageDeviceTypes();

            frm.ShowDialog();
        }

        private void manageBrandsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageBands frm = new frmManageBands();

            frm.ShowDialog();
        }

        private void manageModelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageModels frm = new frmManageModels();
            frm.ShowDialog();
        }

        private void manageDevicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageDevices frm = new frmManageDevices();
            frm.ShowDialog();
        }

        private void manageRepairOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageRepairOrders frm = new frmManageRepairOrders();

            frm.ShowDialog();
        }

        private void addRepairOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditRepairOrder frm = new frmAddEditRepairOrder();

            frm.ShowDialog();
        }

        private void manageSparePartsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageSpareParts frm = new frmManageSpareParts();

            frm.ShowDialog();
        }

      
        private void createSparePartPurchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCreateSparePartPurchase frm = new frmCreateSparePartPurchase();

            frm.ShowDialog();
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageSuppliers frm = new frmManageSuppliers();

            frm.ShowDialog();
        }

        private void purchasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManagePurchases frm = new frmManagePurchases();
           
            frm.ShowDialog();
        }

        private void diagnosesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageDiagnoses frm = new frmManageDiagnoses();

            frm.ShowDialog();
        }

     
        private void partBrandsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManagePartBrands frm = new frmManagePartBrands();

            frm.ShowDialog();
        }

        private void partCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManagePartCategories frm = new frmManagePartCategories();

            frm.ShowDialog();
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageEmployees frm = new frmManageEmployees();

            frm.ShowDialog();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageCustomers frm = new frmManageCustomers();


            frm.ShowDialog();

        }

        private void techniciansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageTechnicians frm = new frmManageTechnicians();

            frm.ShowDialog();
        }

        private void manageInvoicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageInvoices frm = new frmManageInvoices();

            frm.ShowDialog();
        }

        private void repairOrdersReadyForInvoicingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRepairOrdersReadyForInvoicing frm =
                new frmRepairOrdersReadyForInvoicing();

            frm.ShowDialog();
        }

        private void invoicesAwaitingPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInvoicesAwaitingPayment frm = new frmInvoicesAwaitingPayment();

            frm.ShowDialog();
        }

       
        private void repairOrdersReadyForDeliveryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmRepairOrdersReadyForDelivery frm = 
                new frmRepairOrdersReadyForDelivery();

            frm.ShowDialog();
        }

        private void deliveriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
            clsGlobal.CurrentUser = null;
            _frmLogin.Show();
            this.Close();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageUsers frm = new frmManageUsers();
            frm.ShowDialog();
        }
    }
}
