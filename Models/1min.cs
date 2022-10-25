using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class _1min : Frequency
    {
        public override double UpdateTime
        {
            get
            {
                return base.UpdateTime;
            }
            set
            {
                base.UpdateTime = 60000;
            }
        }
        public _1min()
        {
            
        }
    }
}
