using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet1
{
    public abstract class Band : IComparable
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public string Members { get; set; }

        public List<Album> Albums { get; set; }

        public Band()
        {
            Albums = new List<Album>();
        }

        public Band(string name, int year, string members)
        {
            Name = name;
            Year = year;
            Members = members;

            Albums = new List<Album>();
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
    public class Rock : Band
    {
        public Rock(string name, int year, string members)
        {
            Name = name;
            Year = year;
            Members = members;
        }

        public override string ToString()
        {
            return $"{Name} (Rock)";
        }
    }
    public class Pop : Band
    {
        public Pop(string name, int year, string members)
        {
            Name = name;
            Year = year;
            Members = members;
        }
        public override string ToString()
        {
            return $"{Name} (Pop)";
        }
    }
    public class Indie : Band
    {
        public Indie(string name, int year, string members)
        {
            Name = name;
            Year = year;
            Members = members;
        }
        public override string ToString()
        {
            return $"{Name} (Indie)";
        }

    
    }
}
