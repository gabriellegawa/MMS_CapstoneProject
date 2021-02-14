using System;
using System.Collections.Generic;
using System.Text;

namespace MMSLibrary
{
    public class ClientModel
    {
        /// <summary>
        /// Client model - this class attribute is based on Clients table in database
        /// </summary>

        //public ClientModel(string name, string primaryContactName, string primaryContactCell, string primaryContactEmail, bool isDeleted)
        //{
        //    Name = name ?? throw new ArgumentNullException(nameof(name));
        //    PrimaryContactName = primaryContactName ?? throw new ArgumentNullException(nameof(primaryContactName));
        //    PrimaryContactCell = primaryContactCell ?? throw new ArgumentNullException(nameof(primaryContactCell));
        //    PrimaryContactEmail = primaryContactEmail ?? throw new ArgumentNullException(nameof(primaryContactEmail));
        //    IsDeleted = isDeleted;
        //}

        public int Id { get; set; }
        public string Name { get; set; }
        public string PrimaryContactName { get; set; }
        public string PrimaryContactCell { get; set; }
        public string PrimaryContactEmail { get; set; }
        public bool IsDeleted { get; set; }
    }
}
