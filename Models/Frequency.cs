using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Frequency
    {
        public string Name { get; set; }
        public int Interval { get; set; }

        public Frequency(string name, int interval)
        {
            Name = name;
            Interval = interval;
        }   
    }
}
