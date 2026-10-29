using SCMS_Business_Logic;
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
    public partial class ucShowCustomerInfo : UserControl
    {
        clsCustomer _Customer;
        int? _CustomerID = null;

        public ucShowCustomerInfo()
        {
            InitializeComponent();
        }

        public int? CustomerID
        {
            get
            {
                return _CustomerID;
            }
        }

        private void lblNotes_Click(object sender, EventArgs e)
        {

        }

        private void _SetIntialInfo()
        {
            ucShowPersonInfo1.SetDefaultData();

            lblCustomerID.Text = "???";
            lblCreatedByUser.Text = "???";
            lblCreatedDate.Text = "???";
            lblLastUpdatedDate.Text = "???";
            lblLastUpdatedUser.Text = "???";
           
            lblNotes.Text = "???";
        }
        private void _LoadDate()
        {
            _CustomerID = _Customer.CustomerID;
            ucShowPersonInfo1.LoadPersonInfo(_Customer.FullName,_Customer.txtGender,
                _Customer.PhoneNumber,_Customer.Email,_Customer.Address);

            lblCustomerID.Text = _CustomerID.ToString();
            lblCreatedByUser.Text = _Customer.CreatedUserInfo.Username;
            lblCreatedDate.Text = _Customer.CreatedDate.ToString("dd/MM/yyyy");
            lblLastUpdatedDate.Text = _Customer.LastUpdatedDate?.ToString("dd/MM/yyyy")?? "Un Known";
            lblLastUpdatedUser.Text = _Customer.LastUpdatedUserInfo ==null ? "Un Known" :
                _Customer.LastUpdatedUserInfo.Username;
            lblNotes.Text = _Customer.Notes ?? "Un Known";
        }

        public void LoadCustomerInfo(int CustomerID)
        {
            _Customer = clsCustomer.FindCustomer(CustomerID);

            if(_Customer == null)
            {
                MessageBox.Show($"No customer found with id= {CustomerID}", "Not found",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                _CustomerID = null;
                _SetIntialInfo();
                return;
            }
            
            _LoadDate();
        }

     
        public void LoadCustomerInfoByPhoneNumber(string PhoneNumber)
        {
            _Customer = clsCustomer.FindCustomerByPhoneNumber(PhoneNumber);

            if (_Customer == null)
            {
                MessageBox.Show($"No customer found with phone number = {PhoneNumber}", "Not found",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                _CustomerID = null;
                _SetIntialInfo();
                return;
            }

            _LoadDate();
        }

    }
}
