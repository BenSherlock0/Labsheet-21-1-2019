using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet1
{
    class Band : IComparable
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public string Members { get; set; }

        public Band()
        {

        }

        public int CompareTo(object obj)
        {
            Band that = (Band)obj;
            return this.Name.CompareTo(that.Name);
        }
    }
}
