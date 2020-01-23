using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet1
{
    public class Album
    {
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int AlbumSales { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
