using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service_Center_Management_System__SCMS_
{
    public partial class frmShowRepairOrderDetails : Form
    {
        int _RepairOrderID;
        public frmShowRepairOrderDetails(int RepairOrderID)
        {
            InitializeComponent();
            _RepairOrderID = RepairOrderID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowRepairOrderDetails_Load(object sender, EventArgs e)
        {
            ucShowRepairOrderDetails1.LoadRepairOrderInfo(_RepairOrderID);
        }
    }
}
