using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace SharedLib
{
    public class clsEventLogger
    {

        public static void CreateEventSource(string SourceName)
        {
            if(!EventLog.SourceExists(SourceName))
            {
                EventLog.CreateEventSource(SourceName, "Application");       
            }
        }

        public static void WriteEntryToEventLog
            (string SourceName,string Message, EventLogEntryType LogType)
        {
            EventLog.WriteEntry(SourceName, Message,LogType);
        }
    }
}
