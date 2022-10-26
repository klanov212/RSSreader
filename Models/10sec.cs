using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class _10sec : Frequency
    {
        public override double UpdateTime
        {
            get
            {
                return base.UpdateTime;
            }
            set
            {
                base.UpdateTime = 10000;
            }
        }
        public _10sec()
        {
            
        }
    }
}
