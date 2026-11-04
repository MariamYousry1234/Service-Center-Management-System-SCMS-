using SCMS_Business_Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCMSControlsLib
{
    public partial class ucShowRepairOrderDetails : UserControl
    {
        enum enImageStatus { 
            BeforRepair=1,
            AfterRepair=2
        }

        clsRepairOrder _RepairOrder;
        public ucShowRepairOrderDetails()
        {
            InitializeComponent();
        }

        private void _LoadImage(string ImagePath,enImageStatus Status)
        {
            if (ImagePath == null || !File.Exists(ImagePath)) return;


            if(Status ==enImageStatus.BeforRepair)
            {
                pbBeforeRepair.ImageLocation = ImagePath;
            }
            else
            {
                pbAfterRepair.ImageLocation = ImagePath;
            }
        }
        private void _LoadData()
        {
            lblRepairOrderID.Text = _RepairOrder.RepairOrderID.ToString();
            lblDateReceived.Text = _RepairOrder.DateReceived.ToString("dd/MM/yyyy");
            lblEstimatedCost.Text =  _RepairOrder.DiagnosisInfo?.EstimatedCost.ToString()?? "Un Konwn";
           
            lblActualCost.Text = 
                clsInvoice.FindByRepairOrderID(_RepairOrder.RepairOrderID)?.RepairCostInfo?.TotalRepairCost.ToString()?? "Un Konwn";
            lblDateDelivered.Text =  _RepairOrder.DeliveryInfo?.DeliveryDate.ToString("dd/MM/yyyy")??"Un Known";
            lblStatus.Text = _RepairOrder.txtStatus;
            lblPriority.Text = _RepairOrder.txtPriority;
            lblAssignedTechnicianID.Text = _RepairOrder.AssignedTechnicianID.ToString();
            lblAssignedTechnicianName.Text = _RepairOrder.AssignedTechnicianInfo.EmployeeInfo.FullName;
            lblDeviceID.Text = _RepairOrder.DeviceID.ToString();
            lblDeviceTypeName.Text = _RepairOrder.DeviceInfo.DeviceTypeInfo.DeviceTypeName;
            lblCustomerID.Text = _RepairOrder.DeviceInfo.CustomerID.ToString();
            lblCustomerName.Text = _RepairOrder.DeviceInfo.CustomerInfo.FullName;
            lblLastUpdatedUser.Text = _RepairOrder.LastUpdatedUserInfo?.Username ?? "Un Known";
            lblCreatedUser.Text = _RepairOrder.CreatedUserInfo.Username;
            lblLastUpdatedDate.Text = _RepairOrder.LastUpdatedDate?.ToString("dd/MM/yyyy") ?? "Un Known";
            lblProblemDescription.Text = _RepairOrder.ProblemDescription?? "Un Known";
            lblNotes.Text = _RepairOrder.Notes ?? "Un Known";
            lblRepairCompletionDate.Text = 
                _RepairOrder.RepairCompletionDate?.ToString("dd/MM/yyyy") ?? "Not Completed Yet";

            _LoadImage(_RepairOrder.BeforeRepairImagePath,enImageStatus.BeforRepair);
            _LoadImage(_RepairOrder.DeliveryInfo?.AfterRepairImagePath,enImageStatus.AfterRepair);
        }
        public void LoadRepairOrderInfo(int RepairOrderID)
        {
            _RepairOrder = clsRepairOrder.Find(RepairOrderID);

            if(_RepairOrder == null)
            {
                MessageBox.Show($"Repair order with id = {RepairOrderID} Not found!",
                    "",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            _LoadData();
        }
    }
}
