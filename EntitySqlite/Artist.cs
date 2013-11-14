using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitySqlite
{
    public class Artist
    {
        public Artist()
        {
            Albums = new List<Album>();
        }

        public long ArtistId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Album> Albums { get; set; }
    }
}
