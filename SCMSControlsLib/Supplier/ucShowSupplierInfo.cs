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
    public partial class ucShowSupplierInfo : UserControl
    {
        clsSupplier _Supplier;
        int? _SupplierID;
        public ucShowSupplierInfo()
        {
            InitializeComponent();
        }

        public int? SupplierID
        {
            get
            {
                return _SupplierID;
            }
        }
        public clsSupplier Supplier
        {
            get
            {
                return _Supplier;
            }
        }
        private void _SetIntailData()
        {
            _SupplierID = null;
            gbInfo.Text = "Information For Supplier ID = [???]";
            lblSupplierID.Text = "[???]";
            lblSupplierName.Text = "[???]";
            lblPhoneNumber.Text = "[???]";
            lblAddress.Text = "[???]";
            lblIsActive.Text = "[???]";
        }

        private void _LoadSupplierInfo()
        {
            _SupplierID = _Supplier.SupplierID;
            gbInfo.Text = $"Information For Supplier ID = {_Supplier.SupplierID}";
            lblSupplierID.Text = _Supplier.SupplierID.ToString();
            lblSupplierName.Text = _Supplier.SupplierName;
            lblPhoneNumber.Text = _Supplier.PhoneNumber;
            lblAddress.Text = _Supplier.Address??"Un Known";
            lblIsActive.Text = _Supplier.IsActive?"YES":"NO";
        }
        public void LoadSupplierInfo(int SupplierID)
        {
            _Supplier = clsSupplier.FindSupplier(SupplierID);


            if(_Supplier==null)
            {
                MessageBox.Show($"Supplier with id ={SupplierID} Not found!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                _SetIntailData();
                return;
            }

            _LoadSupplierInfo();

        }


        public void LoadSupplierInfoByPhoneNumber(string PhoneNumber)
        {
            _Supplier = clsSupplier.FindSupplierByPhoneNumber(PhoneNumber);


            if (_Supplier == null)
            {
                MessageBox.Show($"Supplier with phone number = {PhoneNumber} Not found!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                _SetIntailData();
                return;
            }

            _LoadSupplierInfo();

        }

        public void LoadSupplierInfo(string SupplierName)
        {
            _Supplier = clsSupplier.FindSupplier(SupplierName);


            if (_Supplier == null)
            {
                MessageBox.Show($"Supplier with name = {SupplierName} Not found!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                _SetIntailData();
                return;
            }

            _LoadSupplierInfo();

        }

    }
}
