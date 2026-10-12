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
    public partial class ucShowAllAcountsForAnEmployee : UserControl
    {
      
        public ucShowAllAcountsForAnEmployee()
        {
            InitializeComponent();
        }

        public async  void LoadAllAccounts(int EmployeeID)
        {
            clsEmployee Employee = clsEmployee.FindEmployee(EmployeeID);

            if(Employee ==null)
            {
                MessageBox.Show("Employee Not found!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                gbAllAccounts.Text = "All Accounts For Employee ID = [???]";
                return;
            }


            gbAllAccounts.Text = $"All Accounts For Employee ID = {EmployeeID}";
            dgvAllAcounts.DataSource =  await clsUser.GetAccountsForAnEmployee(EmployeeID);

            if(dgvAllAcounts.Rows.Count > 0)
            {
                dgvAllAcounts.Columns[2].Width =350;
                dgvAllAcounts.Columns[4].Width = 200;
            }
            lblNumberOfAccounts.Text = dgvAllAcounts.Rows.Count.ToString();
        }
    }
}
