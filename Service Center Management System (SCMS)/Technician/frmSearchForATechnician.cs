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
    public partial class frmSearchForATechnician : Form
    {
        public frmSearchForATechnician()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSearchForATechnician_Load(object sender, EventArgs e)
        {
            ucSearchForATechnician1.AddEditVisible = false;
        }

        private void frmSearchForATechnician_Activated(object sender, EventArgs e)
        {
            ucSearchForATechnician1.txtFocus();
        }
    }
}
