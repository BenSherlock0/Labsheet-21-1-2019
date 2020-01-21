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

        public Band(string name, int year, string members)
        {
            Name = name;
            Year = year;
            Members = members;
        }

        public int CompareTo(object obj)
        {
            Band that = (Band)obj;
            return this.Name.CompareTo(that.Name);
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
