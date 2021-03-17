namespace MMSLibrary
{
    public class TrackWorkerModel
    {
        /// <summary>
        /// Track worker model - this class attribute is based on TrackWorkers table in database
        /// </summary>
        public int TrackWorkerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Cell { get; set; }
        public bool IsCapableCaptain { get; set; }
        public bool IsDeleted { get; set; }
        public string FullName()
        {
            return FirstName + " " + LastName;
        }
    }
}
