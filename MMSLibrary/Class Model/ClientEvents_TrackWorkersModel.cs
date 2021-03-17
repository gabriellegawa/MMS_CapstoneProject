namespace MMSLibrary.Class_Model
{
    public class ClientEvents_TrackWorkersModel
    {
        /// <summary>
        /// ClientsEvents_TrackWorkersModel - contain join table attributes
        /// </summary>
        public int ClientEventID { get; set; }
        public int TrackWorkerID { get; set; }
        public bool IsApplied { get; set; }
        public bool IsSelected { get; set; }
        public bool IsPresent { get; set; }
    }
}
