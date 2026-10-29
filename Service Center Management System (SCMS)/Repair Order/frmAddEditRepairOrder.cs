using SCMS_Business_Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using SharedLib;

namespace Service_Center_Management_System__SCMS_
{
    public partial class frmAddEditRepairOrder : Form
    {
        enum enMode { AddNew = 0, Update = 1 }
        enMode _Mode;

        clsRepairOrder _RepairOrder;
        int _RepairOrderID;

        private string ApplicationName = ConfigurationManager.AppSettings["ApplicationName"];

        string RepairOrderImagesFolderPath = ConfigurationManager.AppSettings["ImagesFolderPath"];
        public frmAddEditRepairOrder()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        
        }

        public frmAddEditRepairOrder(int RepairOrderID)
        {
            InitializeComponent();

            _Mode = enMode.Update;
            _RepairOrderID = RepairOrderID;
        }

        private void _SetIntailInfo()
        {
        
            if(_Mode==enMode.AddNew)
            {
                this.Text = "Add New Repair Order";
                lblTitle.Text = "Add New Repair Order";
                lblRepairOrderID.Text = "[???]";
                cbPriority.SelectedIndex = 0;
                pbDeviceImage.Image = Properties.Resources.select;
                lblUserCreated.Text = clsGlobal.CurrentUser.Username;
                lblCreatedDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
                llRemoveImage.Visible = false;
            }
            else
            {
                this.Text = "Update Repair Order Info";
                lblTitle.Text = "Update Repair Order Info";

            }
          
        }


        private void _LoadImage()
        {
            if (_RepairOrder.BeforeRepairImagePath == null) return;

            if(!File.Exists(_RepairOrder.BeforeRepairImagePath))
            {
                MessageBox.Show("Couldn't find image ", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            pbDeviceImage.ImageLocation = _RepairOrder.BeforeRepairImagePath;
            llRemoveImage.Visible = true;
        }
        private void _LoadData()
        {
            _SetIntailInfo();
            if (_Mode==enMode.AddNew)
            {
                _RepairOrder = new clsRepairOrder();
                ucSearchForDeviceWithAddEdit1.LoadDeviceInfo();

                ucSearchForATechnician1.LoadTechnicianInfo();
                ucSearchForATechnician1.AddEditVisible = true;
            }
            else
            {
                _RepairOrder = clsRepairOrder.Find(_RepairOrderID);

                if(_RepairOrder == null)
                {
                    MessageBox.Show($"Repair order with id = {_RepairOrderID} Not found!",
                        "Not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ucSearchForDeviceWithAddEdit1.LoadDeviceInfo(_RepairOrder.DeviceID);

                ucSearchForATechnician1.LoadTechnicianInfo(_RepairOrder.AssignedTechnicianID);
            
                lblRepairOrderID.Text = _RepairOrder.RepairOrderID.ToString();
                cbPriority.SelectedIndex = (byte)(_RepairOrder.Priority-1);
                txtProblemDescription.Text = _RepairOrder.ProblemDescription ?? "";
                txtNotes.Text = _RepairOrder.Notes ?? "";
                lblUserCreated.Text = _RepairOrder.CreatedUserInfo.Username;
                lblCreatedDate.Text = _RepairOrder.DateReceived.ToString("dd/MM/yyyy");

                _LoadImage();
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddEditRepairOrder_Load(object sender, EventArgs e)
        {
            _LoadData();

            ucSearchForDeviceWithAddEdit1.DeviceSaved = _LoadDeviceForm;
            ucSearchForATechnician1.TechnicianSaved = _LoadTechnicainForm;
        }

      
        private int? _LoadDeviceForm(int? DeviceID)
        {
            int? NewDeviceID = null;
            frmAddEditDevice frm;

            if (_Mode == enMode.AddNew)
            {
                frm =new frmAddEditDevice();
            }
            else
            {
                frm = new frmAddEditDevice(DeviceID.Value);
            }

            frm.DelegateDeviceID += (int DeviceId) =>
            {
                NewDeviceID = DeviceId;
            };
            frm.ShowDialog();
            return NewDeviceID;
        }

        private int? _LoadTechnicainForm(int? TechnicianID)
        {
            int? NewTechnicianID = null;
            frmAddEditTechnician frm;

            if (_Mode == enMode.AddNew)
            {
                frm =new frmAddEditTechnician();
            }
            else
            {
                frm = new frmAddEditTechnician(TechnicianID.Value);
            }

            frm.delegateTechnicianID += (int TechnicianId) =>
            {
                NewTechnicianID = TechnicianId;
            };
            frm.ShowDialog();

            return NewTechnicianID;
        }

        private void llAddDeviceImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pbDeviceImage.ImageLocation = openFileDialog1.FileName;
                llRemoveImage.Visible = true;
            }
        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbDeviceImage.ImageLocation = null;
            llRemoveImage.Visible = false;
            pbDeviceImage.Image = Properties.Resources.select;
        }


        private void _SetImage()
        {
            if(_RepairOrder.BeforeRepairImagePath != pbDeviceImage.ImageLocation)
            {
                if(_RepairOrder.BeforeRepairImagePath != null)
                {
                    clsUtil.DeleteImageFromFolder(_RepairOrder.BeforeRepairImagePath);
                    _RepairOrder.BeforeRepairImagePath = null;
                }

                if (pbDeviceImage.ImageLocation != null)
                {
                    string? NewImagePath=null;

                    clsUtil.SaveImageToFolder(pbDeviceImage.ImageLocation, RepairOrderImagesFolderPath,
                      ref NewImagePath);

                    _RepairOrder.BeforeRepairImagePath = NewImagePath;
                }

            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(ucSearchForDeviceWithAddEdit1.DeviceID == null)
            {
                MessageBox.Show("Device Not Selected", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (ucSearchForATechnician1.TechnicianID == null)
            {
                MessageBox.Show("Technician Not Selected", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if(_Mode == enMode.AddNew && 
                !ucSearchForATechnician1.TechnicianInfo.EmployeeInfo.IsActive)
            {
                MessageBox.Show($"Technicain with id = {ucSearchForATechnician1.TechnicianID} is inactive",
                    "Not allow", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }


            if (MessageBox.Show("Are you sure you want to save repair order data?", "Confirm",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.Cancel) return;


            _RepairOrder.DeviceID = ucSearchForDeviceWithAddEdit1.DeviceID.Value;
            _RepairOrder.AssignedTechnicianID = ucSearchForATechnician1.TechnicianID.Value;

            _RepairOrder.ProblemDescription =
                string.IsNullOrEmpty(txtProblemDescription.Text.Trim()) ? null : txtProblemDescription.Text.Trim();

            _RepairOrder.Notes =
                string.IsNullOrEmpty(txtNotes.Text.Trim()) ? null : txtNotes.Text.Trim();

            _RepairOrder.Priority = (clsRepairOrder.enPriority)(cbPriority.SelectedIndex + 1);

            if (_Mode == enMode.AddNew)
                _RepairOrder.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            else
                _RepairOrder.LastUpdatedUserID = clsGlobal.CurrentUser.UserID;


            _SetImage();

            if (_RepairOrder.Save())
            {
                MessageBox.Show("Data saved successfully", "Saved", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                _RepairOrderID = _RepairOrder.RepairOrderID;
                lblRepairOrderID.Text = _RepairOrderID.ToString();
                _Mode = enMode.Update;

                ucSearchForDeviceWithAddEdit1.LoadDeviceInfo(_RepairOrder.DeviceID);

                ucSearchForATechnician1.LoadTechnicianInfo(_RepairOrder.AssignedTechnicianID);

                _SetIntailInfo();


                clsEventLogger.WriteEntryToEventLog(
                   ApplicationName,
                    $"User with username = {clsGlobal.CurrentUser.Username} saved Repair Order with ID = {_RepairOrderID} successfully",
                   System.Diagnostics.EventLogEntryType.Information);

            }
            else
            {
                MessageBox.Show("Failed to save repair order data.", "An error occurred", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }

        private void frmAddEditRepairOrder_Activated(object sender, EventArgs e)
        {
            if (_Mode == enMode.AddNew)
                ucSearchForDeviceWithAddEdit1.txtFocus();
        }
    }
}
