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
    public partial class frmShowSparePartDetails : Form
    {

        int _SparePartID;
        public frmShowSparePartDetails(int SparePartID)
        {
            InitializeComponent();

            _SparePartID = SparePartID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowSparePartDetails_Load(object sender, EventArgs e)
        {
            ucShowSparePartDetails1.LoadSparePartInfo(_SparePartID);
        }
    }
}
