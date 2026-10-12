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
    public partial class frmShowCurrentWorkloadForTechnician : Form
    {
        int _TechnicianID;
        public frmShowCurrentWorkloadForTechnician(int TechnicianID)
        {
            InitializeComponent();

            _TechnicianID = TechnicianID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frmShowCurrentWorkloadForTechnician_Load(object sender, EventArgs e)
        {
            ucShowCurrentWorkloadForTechnician1.ShowRepairDetails = _ShowRepairDetails;
           await ucShowCurrentWorkloadForTechnician1.LoadTechnicianCurrentWorkload(_TechnicianID);
        }

        private void _ShowRepairDetails(int RepairOrderID)
        {
            frmShowRepairOrderDetails frm = new frmShowRepairOrderDetails(RepairOrderID);

            frm.ShowDialog();
        }
    }
}
