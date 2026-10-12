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
    public partial class ucSearchForEmployeeWithAddingEditing : UserControl
    {
        public Func<int?,int?> EmployeeSaved;

        public ucSearchForEmployeeWithAddingEditing()
        {
            InitializeComponent();
        }

        public int? EmployeeID
        {
            get
            {
                return ucSearchForAnEmployee1.EmployeeID;
            }
        }

        public clsEmployee EmployeeInfo
        {
            get
            {
                return ucSearchForAnEmployee1.EmployeeInfo;
            }
        }
        public void LoadEmployeeInfo(int? EmployeeID=null)
        {
            if(EmployeeID ==null)
            {
                ucSearchForAnEmployee1.txtFocus();
                btnAddEditEmployee.Text = "Add New Employee";
            }
            else
            {
                btnAddEditEmployee.Text = "Edit Employee Info";
                ucSearchForAnEmployee1.LoadEmployeeInfo(EmployeeID.Value);
                ucSearchForAnEmployee1.gbEnabled = false;
            }
        }

        private void btnAddEditEmployee_Click(object sender, EventArgs e)
        {
            int?EmployeeID = EmployeeSaved?.Invoke(ucSearchForAnEmployee1.EmployeeID);

            if (EmployeeID.HasValue)
                ucSearchForAnEmployee1.LoadEmployeeInfo(EmployeeID.Value);
        }
    }
}
