using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MMSLibrary
{
    public class ClientEventModel
    {
        /// <summary>
        /// Client Event model - this class attribute is based on ClientEvents table in database
        /// </summary>

        [Key]
        public int ClientEventID { get; set; }
        public int ClientID { get; set; }
        public int TrackID { get; set; }
        public string Date { get; set; }
        public int WorkersRequested { get; set; }
        public bool IsLunchProvided { get; set; }
        public bool IsUsingUpperPaddock { get; set; }
        public bool IsUsingMiddlePaddock { get; set; }
        public bool IsUsingLowerPaddock { get; set; }
        public bool WorkerCalloutSent { get; set; }
        public bool RequireSafetyDemo { get; set; }
        public bool IsDeleted { get; set; }
        public List<int> TrackWorkersId { get; set; }
        public string ClientName { get; set; }
        public string TrackName { get; set; }

    }
}
