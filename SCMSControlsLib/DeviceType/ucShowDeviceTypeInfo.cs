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
    public partial class ucShowDeviceTypeInfo : UserControl
    {
        clsDeviceType _DeviceType;
        public ucShowDeviceTypeInfo()
        {
            InitializeComponent();
        }

        private void _SetIntialData()
        {
            lblDeviceTypeID.Text = "[???]";
            lblDeviceTypeName.Text= "[???]";
        }
        private void _LoadData()
        {
            lblDeviceTypeID.Text = _DeviceType.DeviceTypeID.ToString();
            lblDeviceTypeName.Text = _DeviceType.DeviceTypeName;
        }
        public void LoadDeviceTypeInfo(int DeviceTypeID)
        {
            _DeviceType = clsDeviceType.FindDeviceType(DeviceTypeID);

            if(_DeviceType ==null)
            {
                MessageBox.Show($"Device Type with id={DeviceTypeID} Not found!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                _SetIntialData();
                return;
            }
            _LoadData();

        }

        public void LoadDeviceTypeInfo(string DeviceTypeName)
        {
            _DeviceType = clsDeviceType.FindDeviceType(DeviceTypeName);

            if (_DeviceType == null)
            {
                MessageBox.Show($"Device Type with Name={DeviceTypeName} Not found!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                _SetIntialData();
                return;
            }
            _LoadData();

        }
    }
}
