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
    public partial class frmShowEmployeeUserAcounts : Form
    {
        int _EmployeeID;
        public frmShowEmployeeUserAcounts(int EmployeeID)
        {
            InitializeComponent();

            _EmployeeID = EmployeeID;
        }

        private void frmShowEmployeeUserAcounts_Load(object sender, EventArgs e)
        {
            ucShowAllAcountsForAnEmployee1.LoadAllAccounts(_EmployeeID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
