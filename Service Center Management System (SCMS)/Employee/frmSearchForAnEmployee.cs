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
    public partial class frmSearchForAnEmployee : Form
    {
        public frmSearchForAnEmployee()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSearchForAnEmployee_Load(object sender, EventArgs e)
        {
       
        }

        private void frmSearchForAnEmployee_Activated(object sender, EventArgs e)
        {
            ucSearchForAnEmployee1.txtFocus();
        }
    }
}
