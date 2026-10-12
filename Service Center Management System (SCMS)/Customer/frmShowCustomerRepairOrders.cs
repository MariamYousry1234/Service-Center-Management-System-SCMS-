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
    public partial class frmShowCustomerRepairOrders : Form
    {
        int _CustomerID;
        public frmShowCustomerRepairOrders(int CustomerID)
        {
            InitializeComponent();

            _CustomerID = CustomerID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frmShowCustomerRepairOrders_Load(object sender, EventArgs e)
        {
            ucShowCustomerRepairOrders1.ShowRepairOrderDetails=_ShowRepairOrderDetails;
            await ucShowCustomerRepairOrders1.LoadCustomerRepairOrders(_CustomerID);
        }

        private void _ShowRepairOrderDetails(int RepairOrderID)
        {
            frmShowRepairOrderDetails frm = new frmShowRepairOrderDetails(RepairOrderID);

            frm.ShowDialog();
        }
    }
}
