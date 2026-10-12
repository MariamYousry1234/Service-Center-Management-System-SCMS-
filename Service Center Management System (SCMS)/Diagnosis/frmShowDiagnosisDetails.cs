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
    public partial class frmShowDiagnosisDetails : Form
    {
        int _DiagnosisID;
        public frmShowDiagnosisDetails(int DiagnosisID)
        {
            InitializeComponent();

            _DiagnosisID = DiagnosisID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowDiagnosisDetails_Load(object sender, EventArgs e)
        {
           
            ucShowDiagnosisDetails1.LoadDiagnosisInfo(_DiagnosisID);

        }
    }
}
