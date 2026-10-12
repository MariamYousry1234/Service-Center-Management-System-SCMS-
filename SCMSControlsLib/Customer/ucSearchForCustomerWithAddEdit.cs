using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCMSControlsLib
{
    public partial class ucSearchForCustomerWithAddEdit : UserControl
    {
        public Func <int?,int?> SavedCustomer;
        public ucSearchForCustomerWithAddEdit()
        {
            InitializeComponent();
        }

        public int? CustomerID
        {
            get
            {
                return ucSearchForCustomer1.CustomerID;
            }
        }
        public void LoadCustomerInfo(int? CustomerID=null)
        {
            //Add New
            if(CustomerID == null)
            {
              
                btnAddEditCustomer.Text = "Add New Customer";
            }
            //edit
            else
            {
                ucSearchForCustomer1.LoadCustomerInfo(CustomerID.Value);
                ucSearchForCustomer1.gbEnabled = false;
                btnAddEditCustomer.Text = "Edit Customer Info";
            }
        }

        private void btnAddEditCustomer_Click(object sender, EventArgs e)
        {
            int? CustomerID = SavedCustomer?.Invoke(ucSearchForCustomer1.CustomerID);

            if (CustomerID != null)
                ucSearchForCustomer1.LoadCustomerInfo(CustomerID.Value);
        }
    }
}
