using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMSLibrary.Class_Model
{
    public class TrackWorkerReportModel
    {
        public string TrackWorkerFullName { get; set; }
        public int TotalDaysApplied { get; set; }
        public int TotalDaysSelected { get; set; }
        public int TotalDaysPresent { get; set; }
    }
}
