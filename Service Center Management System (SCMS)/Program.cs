using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharedLib;
using System.Configuration;

namespace Service_Center_Management_System__SCMS_
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //clsEventLogger.CreateEventSource(ConfigurationManager.AppSettings["ApplicationName"]);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLoginScreen());
        }
    }
}
