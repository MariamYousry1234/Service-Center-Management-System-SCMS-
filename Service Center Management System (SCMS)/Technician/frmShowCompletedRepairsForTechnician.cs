using SCMSControlsLib;
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
    public partial class frmShowCompletedRepairsForTechnician : Form
    {
        int _TechnicianID;

        public frmShowCompletedRepairsForTechnician(int TechnicianID)
        {
            InitializeComponent();

            _TechnicianID = TechnicianID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frmShowCompletedRepairsForTechnician_Load(object sender, EventArgs e)
        {
            ucShowCompletedRepairsForTechnician1.ShowRepairDetails = _ShowRepairDetails;
            await ucShowCompletedRepairsForTechnician1.LoadTechnicianCompletedRepairs(_TechnicianID);
        }

        private void _ShowRepairDetails(int RepairOrderID)
        {
            frmShowRepairOrderDetails frm = new frmShowRepairOrderDetails(RepairOrderID);

            frm.ShowDialog();
        }
    }
}
