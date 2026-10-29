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
    public partial class frmShowSupplierInfo : Form
    {
        int _SupplierID;
        public frmShowSupplierInfo(int SupplierID)
        {
            InitializeComponent();
            _SupplierID = SupplierID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowSupplierInfo_Load(object sender, EventArgs e)
        {
            ucShowSupplierInfo1.LoadSupplierInfo(_SupplierID);
        }
    }
}
