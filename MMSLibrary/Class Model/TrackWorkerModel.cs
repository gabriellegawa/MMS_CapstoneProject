using System;
using System.Collections.Generic;
using System.Text;

namespace MMSLibrary
{
    public class TrackWorkerModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Cell { get; set; }
        public bool IsCapableCaptain { get; set; }
        public bool IsDeleted { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public List<ClientEventModel> ClientEvents { get; set; }
    }
}
