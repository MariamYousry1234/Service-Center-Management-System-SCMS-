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
    public partial class ucShowDeliveryInfo : UserControl
    {

        clsDelivery _DeliveryInfo;
        clsRepairOrder _RepairOrderInfo;

        public ucShowDeliveryInfo()
        {
            InitializeComponent();
        }


        private void _SetIntialInfo()
        {
            lblDeliveryID.Text = "[???]";
            lblRepairOrderID.Text = "[???]";
            lblCustomerID.Text = "[???]";
            lblCustomerName.Text = "[???]";
            lblDeviceID.Text = "[???]";
            lblDeviceTypeName.Text = "[???]";
            lblDeliveredDate.Text = "[???]";
            lblWarrantyEndDate.Text = "[???]";
            lblDeliveredByUser.Text = "[???]";
            lblDeliveryNotes.Text = "[???]";

        }

        private void _LoadDeliveryInfo()
        {
            lblDeliveryID.Text = _DeliveryInfo.DeliveryID.ToString();
            lblRepairOrderID.Text = _DeliveryInfo.RepairOrderID.ToString();
            lblCustomerID.Text = _RepairOrderInfo.DeviceInfo.CustomerID.ToString();
            lblCustomerName.Text = _RepairOrderInfo.DeviceInfo.CustomerInfo.FullName;
            lblDeviceID.Text = _RepairOrderInfo.DeviceID.ToString();
            lblDeviceTypeName.Text = _RepairOrderInfo.DeviceInfo.DeviceTypeInfo.DeviceTypeName;
            lblDeliveredDate.Text = _DeliveryInfo.DeliveryDate.ToString("dd/MM/yyyy");
            lblWarrantyEndDate.Text = _DeliveryInfo.WarrantyEndDate?.ToString("dd/MM/yyyy")?? "Un Known";
            lblDeliveredByUser.Text = _DeliveryInfo.DeliveredUserInfo.Username;
            lblDeliveryNotes.Text = _DeliveryInfo.DeliveryNotes??"Un Known";

        }
        public void LoadDeliveryInfo(int DeliveryID)
        {
            _DeliveryInfo = clsDelivery.FindDelivery(DeliveryID);

            if(_DeliveryInfo ==null)
            {
                MessageBox.Show(
                   "No delivery info found for this repair order.",
                   "Not Found",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);


                _SetIntialInfo();
                return;
            }

            _RepairOrderInfo = clsRepairOrder.Find(_DeliveryInfo.RepairOrderID);

            if(_RepairOrderInfo==null)
            {
                MessageBox.Show(
                 "The repair order associated with this delivery could not be found.",
                  "Not Found",
                  MessageBoxButtons.OK,
              MessageBoxIcon.Warning);


                _SetIntialInfo();
                return;
            }

            _LoadDeliveryInfo();
        }
    }
}
