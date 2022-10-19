using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class _30sec : Frequency
    {
        public _30sec(string name) : base(name)
        {
            Name = "30 sekunder";
            UpdateTime = 30000; 
        }
    }
}
