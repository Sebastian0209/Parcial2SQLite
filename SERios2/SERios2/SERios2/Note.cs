
using System;
using System.Collections.Generic;
using System.Text;
using SQLite.Net.Attributes;
using System.Linq;
using System.Threading.Tasks;

namespace SERios2
{
    class Note
    {
        [PrimaryKey, AutoIncrement]
        public int NotesId { get; set; }
        public string Contents { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }



        public override string ToString()
        {
            return string.Format(" {0} {1} {2} {3} ", NotesId, Contents, CreatedDate, ModifiedDate);

        }

    }
}
