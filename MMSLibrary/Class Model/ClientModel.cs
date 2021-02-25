namespace MMSLibrary
{
    public class ClientModel
    {
        /// <summary>
        /// Client model - this class attribute is based on Clients table in database
        /// </summary>
        public int Id { get; set; }
        public string Name { get; set; }
        public string PrimaryContactName { get; set; }
        public string PrimaryContactCell { get; set; }
        public string PrimaryContactEmail { get; set; }
        public bool IsDeleted { get; set; }
    }
}
