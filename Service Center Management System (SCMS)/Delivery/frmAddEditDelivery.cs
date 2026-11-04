using SCMS_Business_Logic;
using SharedLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Service_Center_Management_System__SCMS_
{
    public partial class frmAddEditDelivery : Form
    {
        enum enMode { AddNew=0,Update=1}
        enMode _Mode;

        clsRepairOrder _RepairOrder;
        int _RepairOrderID;
        clsDelivery _Delivery;
        int _DeliveryID;

        string RepairOrderImagesFolderPath =
            ConfigurationManager.AppSettings["ImagesFolderPath"];

        public frmAddEditDelivery(int RepairOrderID,bool AddNew)
        {
            InitializeComponent();

            _RepairOrder = clsRepairOrder.Find(RepairOrderID);

            //repair order
            if(_RepairOrder == null)
            {
                MessageBox.Show(
                   "Repair order not found!",
                     "Error",
                      MessageBoxButtons.OK,
                  MessageBoxIcon.Error);


                btnConfirm.Enabled = false;
                gbInfo.Enabled = false;
                return;
            }

            //invoice
            if(!_RepairOrder.HasInvoice)
            {

                MessageBox.Show(
                    "Cannot deliver the repair order because no invoice has been issued yet!",
                     "Delivery",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                btnConfirm.Enabled = false;
                gbInfo.Enabled = false;
                return;
            }

            //payments
            if (_RepairOrder.Status != clsRepairOrder.enStatus.ReadyForDelivery)
            {
                MessageBox.Show(
                   "Repair order is not ready for delivery!",
                   "Delivery",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                btnConfirm.Enabled = false;
                gbInfo.Enabled = false;
                return;
            }

            //delivery
            if(_RepairOrder.IsDelivered)
            {
                MessageBox.Show(
                    "This repair order has already been delivered!",
                    "Delivery",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);


                btnConfirm.Enabled = false;
                gbInfo.Enabled = false;
                return;
            }

            _Mode = enMode.AddNew;
            _RepairOrderID = RepairOrderID;
            _Delivery = new clsDelivery();

            lblDeviceTypeName.Text = _RepairOrder.DeviceInfo.DeviceTypeInfo.DeviceTypeName;
            lblCustomerName.Text = _RepairOrder.DeviceInfo.CustomerInfo.FullName;

        }
        public frmAddEditDelivery(int DeliveryID)
        {
            InitializeComponent();

       
            _Mode = enMode.Update;
            _DeliveryID = DeliveryID;
         
        }

        private void _LoadImage()
        {
            if  (_Delivery.AfterRepairImagePath == null) return;

            if (!File.Exists(_Delivery.AfterRepairImagePath))
            {
                MessageBox.Show("Couldn't find image ", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            pbImage.ImageLocation = _Delivery.AfterRepairImagePath;
            llRemoveImage.Visible = true;
        }

        private void _SetImage()
        {
            if (_Delivery.AfterRepairImagePath != pbImage.ImageLocation)
            {
                if (_Delivery.AfterRepairImagePath != null)
                {
                    clsUtil.DeleteImageFromFolder(_Delivery.AfterRepairImagePath);
                    _Delivery.AfterRepairImagePath = null;
                }

                if (pbImage.ImageLocation != null)
                {
                    string? NewImagePath = null;

                    clsUtil.SaveImageToFolder(pbImage.ImageLocation, RepairOrderImagesFolderPath,
                      ref NewImagePath);

                    _Delivery.AfterRepairImagePath = NewImagePath;
                }

            }
        }
        private void _SetIntialData()
        {
           
            if (_Mode == enMode.AddNew)
            {
                this.Text = "Add New Delivery";
                lblTitle.Text = "Add New Delivery";
                lblRepairOrderID.Text = _RepairOrderID.ToString();
                dtpWarrantyEndDate.Enabled = chkWarrantyEndDate.Checked;
                lblDeliveryDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
                lblCreatedUser.Text = clsGlobal.CurrentUser.Username;
                pbImage.Image = Properties.Resources.select;
            }
            else
            {
                this.Text = "Update Delivery Info";
                lblTitle.Text = "Update Delivery Info";

            }

        }


        private void _LoadData()
        {
            _SetIntialData();

            if(_Mode==enMode.Update)
            {
                _Delivery = clsDelivery.FindDelivery(_DeliveryID);

                if (_Delivery == null)
                {

                    MessageBox.Show(
                      "Delivery information was not found!",
                      "Error",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error);


                    btnConfirm.Enabled = false;
                    gbInfo.Enabled = false;
                    return;
                }

                _RepairOrderID = _Delivery.RepairOrderID;
                lblDeliveryID.Text = _DeliveryID.ToString();
                lblRepairOrderID.Text = _Delivery.RepairOrderID.ToString();
                _RepairOrder = clsRepairOrder.Find(_Delivery.RepairOrderID);

                lblDeviceTypeName.Text =
                  _RepairOrder.DeviceInfo.DeviceTypeInfo.DeviceTypeName;

                lblCustomerName.Text = _RepairOrder.DeviceInfo.CustomerInfo.FullName;
                if (_Delivery.WarrantyEndDate != null)
                {
                    chkWarrantyEndDate.Checked = true;
                    dtpWarrantyEndDate.Value = _Delivery.WarrantyEndDate.Value;
                }
                else
                {
                    chkWarrantyEndDate.Checked = false;
                    dtpWarrantyEndDate.Enabled = chkWarrantyEndDate.Checked;
                }

                lblDeliveryDate.Text = _Delivery.DeliveryDate.ToString("dd/MM/yyyy");
                lblCreatedUser.Text = _Delivery.DeliveredUserInfo.Username;

                _LoadImage();

            }
          
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkWarrantyEndDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpWarrantyEndDate.Enabled = chkWarrantyEndDate.Checked;
        }

        private void frmAddEditDelivery_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pbImage.ImageLocation = openFileDialog1.FileName;
                llRemoveImage.Visible = true ;
            }
        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbImage.ImageLocation = null;
            pbImage.Image = Properties.Resources.select;
            llRemoveImage.Visible = false;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(chkWarrantyEndDate.Checked &&
               dtpWarrantyEndDate.Value.Date < DateTime.Today.Date)
            {
                MessageBox.Show(
                    "Warranty end date cannot be earlier than today!",
                    "Invalid Warranty Date",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);


                return;
            }

            if (MessageBox.Show("Are you sure you want to save delivery data?", "Confirm",
             MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
             == DialogResult.Cancel) return;


            _Delivery.RepairOrderID = _RepairOrderID;
            _Delivery.DeliveryNotes =
                string.IsNullOrEmpty(txtNotes.Text) ? null : txtNotes.Text;
            _Delivery.WarrantyEndDate = chkWarrantyEndDate.Checked ?
                 (DateTime?)dtpWarrantyEndDate.Value : null;

            if (_Mode == enMode.AddNew)
                _Delivery.DeliveredByUserID = clsGlobal.CurrentUser.UserID;

           
            _SetImage();

            if(_Delivery.Save())
            {
                MessageBox.Show(
                  "Delivery information saved successfully!",
                  "Success",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);


                _Mode = enMode.Update;
            
                _SetIntialData();
                _DeliveryID = _Delivery.DeliveryID;
                lblDeliveryID.Text = _DeliveryID.ToString();
            }
            else
            {
                MessageBox.Show(
                 "Failed to save delivery information!",
                 "Save Failed",
                   MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }


        }

        private void llShowRepairOrderDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowRepairOrderDetails frm = new frmShowRepairOrderDetails(_RepairOrderID);

            frm.ShowDialog();
        }
    }
}
