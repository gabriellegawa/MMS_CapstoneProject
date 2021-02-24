using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMSLibrary
{
    public class TrackModel
    {
        /// <summary>
        /// Track model - this class attribute is based on Tracks table in database
        /// </summary>
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
    }
}
