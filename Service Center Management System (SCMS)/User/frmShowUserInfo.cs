using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service_Center_Management_System__SCMS_
{
    public partial class frmShowUserInfo : Form
    {
        int _UserID;
        public frmShowUserInfo(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowUserInfo_Load(object sender, EventArgs e)
        {
            ucShowUserInfo1.LoadUserInfo(_UserID);
        }
    }
}
