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
    public partial class frmShowDeliveryInfo : Form
    {
        int _DeliveryID;
        public frmShowDeliveryInfo(int DeliveryID)
        {
            InitializeComponent();

            _DeliveryID = DeliveryID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowDeliveryInfo_Load(object sender, EventArgs e)
        {
            ucShowDeliveryInfo1.LoadDeliveryInfo(_DeliveryID);
        }
    }
}
