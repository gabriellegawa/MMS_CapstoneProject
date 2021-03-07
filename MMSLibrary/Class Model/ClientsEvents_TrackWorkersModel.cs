using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMSLibrary.Class_Model
{
    class ClientsEvents_TrackWorkersModel
    {
        public int ClientEventID { get; set; }
        public int TrackWorkerID { get; set; }
        public bool IsApplied { get; set; }
        public bool IsSelected { get; set; }
        public bool IsPresent { get; set; }
    }
}
