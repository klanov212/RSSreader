using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class _1min : Frequency
    {
        public _1min(string name) : base(name)
        {
            Name = "1 minut";
            UpdateTime = 60000;
        }
    }
}
