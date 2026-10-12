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
    public partial class frmShowRepairOrderHistory : Form
    {
        int _RepairOrderID;
        public frmShowRepairOrderHistory(int RepairOrderID)
        {
            InitializeComponent();

            _RepairOrderID = RepairOrderID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowRepairOrderHistory_Load(object sender, EventArgs e)
        {
            ucShowRepairOrderHistory1.LoadRepairOrderHistory(_RepairOrderID);
        }
    }
}
