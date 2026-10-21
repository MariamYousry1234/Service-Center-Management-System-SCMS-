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
using SharedLib;
using System.Configuration;

namespace Service_Center_Management_System__SCMS_
{
    public partial class frmLoginScreen : Form
    {
        private const string ValueNameUsername = "Username";
        private const string ValueNamePassword = "Password";
        private string CurrentUserKeyPath = ConfigurationManager.AppSettings["CurrentUserKeyPath"];
        private string KeyPathWithoutRegistryHive = ConfigurationManager.AppSettings["KeyPathWithoutRegistryHive"];
        private string EncryptDecryptKey = ConfigurationManager.AppSettings["EncrytDecryptKey"];
        private string ApplicationName = ConfigurationManager.AppSettings["ApplicationName"];

        public frmLoginScreen()
        {
            InitializeComponent();

            clsEventLogger.CreateEventSource(ApplicationName);
        }
        private void frmLoginScreen_Load(object sender, EventArgs e)
        {
        }

        private void frmLoginScreen_Activated(object sender, EventArgs e)
        {
            //read saved data if exists
            string Username = clsRegistry.ReadFromRegistry<string>(CurrentUserKeyPath, ValueNameUsername);
            string Password = clsRegistry.ReadFromRegistry<string>(CurrentUserKeyPath, ValueNamePassword);

            txtUsername.Text = Username ?? "";
            txtPassword.Text = Password == null ? "" : clsSymmetric.Decrypt(Password, EncryptDecryptKey);
            chbRememberme.Checked =( Username != null && Password != null);
            txtUsername.Focus();
            txtUsername.SelectionStart = txtUsername.Text.Length;
        }

        private void _SaveUsernameAndPasswordToRegistry()
        {
            if (chbRememberme.Checked)
            {

                clsRegistry.SaveToRegistry(CurrentUserKeyPath,
                  ValueNameUsername, txtUsername.Text.Trim(), Microsoft.Win32.RegistryValueKind.String);

                string EncryptPassword = clsSymmetric.Encrypt(txtPassword.Text.Trim(), EncryptDecryptKey);

                clsRegistry.SaveToRegistry(CurrentUserKeyPath,
                   ValueNamePassword, EncryptPassword, Microsoft.Win32.RegistryValueKind.String);
            }
            else
            {
                clsRegistry.DeleteValueFromRegistry(KeyPathWithoutRegistryHive,
                     ValueNameUsername, Microsoft.Win32.RegistryHive.CurrentUser);
                clsRegistry.DeleteValueFromRegistry(KeyPathWithoutRegistryHive,
                  ValueNamePassword, Microsoft.Win32.RegistryHive.CurrentUser);
            }

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!txtUsername.IsValid() || !txtPassword.IsValid()) return;

            clsUser User =
                clsUser.FindByUsernameAndPassword(txtUsername.Text.Trim(),
                txtPassword.Text.Trim());

            if(User == null)
            {
                MessageBox.Show("Invalid username or password.",
                "Login Failed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                txtUsername.Focus();
                return;
            }

            if(!User.IsActive)
            {
                MessageBox.Show(
                   "Your account is inactive. Please contact the administrator.",
                   "Account Inactive",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);

                return;
            }
            clsGlobal.CurrentUser = User;
            //save user data
            _SaveUsernameAndPasswordToRegistry();


            clsEventLogger.WriteEntryToEventLog(ApplicationName,
                $"User with username = {User.Username} logged into SCMS successfully",
                System.Diagnostics.EventLogEntryType.Information);

            this.Hide();

            MainScreen frmMainScreen = new MainScreen(this);

            frmMainScreen.ShowDialog();
        }
    }
}
