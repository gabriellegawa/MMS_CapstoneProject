using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMSLibrary
{
    public class ClientEventModel
    {
        [Key]
        public int Id { get; set; }
        public ClientModel ClientId { get; set; }
        public TrackModel ClientEventTrack { get; set; }
        public DateTime ClientEventDate { get; set; }
        public int ClientEventWorkerRequested { get; set; }
        public bool IsLunchProvided { get; set; }
        public bool IsUsingUpperPaddock { get; set; }
        public bool IsUsingMiddlePaddock { get; set; }
        public bool IsUsingLowerPaddock { get; set; }
        public bool WorkerCalloutSent { get; set; }
        public bool RequiresSafetyDemo { get; set; }
        public List<TrackWorkerModel> TrackWorkers { get; set; }
        
    }
}
