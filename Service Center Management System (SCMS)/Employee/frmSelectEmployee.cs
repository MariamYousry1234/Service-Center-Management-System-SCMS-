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
    public partial class frmSelectEmployee : Form
    {
        public Action<int?> EmployeeID;
        public frmSelectEmployee()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if(ucSearchForAnEmployee1.EmployeeID==null)
            {
                MessageBox.Show("No employee selected. Please select an employee", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            EmployeeID?.Invoke(ucSearchForAnEmployee1.EmployeeID);
            this.Close();
        }
    }
}
