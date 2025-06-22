using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Global
{
    public class clsLoggingEvent
    {
        public static void LoogingEvent(string ErrorMessage)
        {
            string sourceName = "TissueFactory";

            if (!EventLog.SourceExists(sourceName))
            {
                EventLog.CreateEventSource(sourceName, "Application");
            }
            EventLog.WriteEntry(sourceName, ErrorMessage, EventLogEntryType.Error);
        }

    }
}
