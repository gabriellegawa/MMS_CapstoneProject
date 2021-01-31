using System;
using System.Collections.Generic;
using System.Text;

namespace MMSLibrary
{
    public class ClientModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PrimaryContactName { get; set; }
        public string PrimaryContactCell { get; set; }
        public string PrimaryContactEmailCell { get; set; }
        public bool isDeleted { get; set; }
    }
}
