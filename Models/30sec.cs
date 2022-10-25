using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class _30sec : Frequency
    {
        public override double UpdateTime 
        {
            get
            {
                return base.UpdateTime; 
            }
            set 
            { 
                base.UpdateTime = 30000; 
            }
        }
        public _30sec()
        {
            
        }
    }
}
