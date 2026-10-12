using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace SCMS_Data_Access
{
    internal static class clsSettings
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["SCMSConnectionString"].ConnectionString;

        public static string ApplicationName = ConfigurationManager.AppSettings["ApplicationName"];
    }
}
