using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class _10sec : Frequency
    {
        public _10sec(string name) : base(name)
        {
            Name = "10 sekunder";
            UpdateTime = 10000;
        }
    }
}
