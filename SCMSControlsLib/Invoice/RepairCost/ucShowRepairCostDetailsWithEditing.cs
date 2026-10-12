using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCMSControlsLib
{
    public partial class ucShowRepairCostDetailsWithEditing : UserControl
    {
        public Predicate<int> IsRepairCostUpdated;
        public ucShowRepairCostDetailsWithEditing()
        {
            InitializeComponent();
        }

        public int? RepairCostID
        {
            get
            {
                return ucShowRepairCostDetails1.RepairCostID;
            }

        }
        public void LoadRepairOrderInfo(int RepairCostID)
        {
            ucShowRepairCostDetails1.LoadRepairCostDetails(RepairCostID);
        }


        public void LoadRepairOrderInfoByInvoiceID(int InvoiceID)
        {
            ucShowRepairCostDetails1.LoadRepairCostDetailsByInvoiceID(InvoiceID);
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(ucShowRepairCostDetails1.RepairCostID ==null)
            {
                MessageBox.Show("No repair cost to edit", "Invalid", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;                  
            }

            bool IsUpdated =
                 IsRepairCostUpdated?.Invoke(ucShowRepairCostDetails1.RepairCostID.Value)??false;

            if (IsUpdated)
                LoadRepairOrderInfo(ucShowRepairCostDetails1.RepairCostID.Value);

        }
    }
}
