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
    public partial class frmShowTechnicianInfo : Form
    {
        int _TechnicianID;
        public frmShowTechnicianInfo(int TechnicianID)
        {
            InitializeComponent();

            _TechnicianID = TechnicianID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowTechnicianInfo_Load(object sender, EventArgs e)
        {
            ucShowTechnicianInfo1.LoadTechnicianInfo(_TechnicianID);
        }
    }
}
