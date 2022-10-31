using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Models
{
    [Serializable]
    [XmlInclude(typeof(_30sec))]
    [XmlInclude(typeof(_10sec))]
    [XmlInclude(typeof(_1min))]
    public class Frequency
    {
        public virtual double UpdateTime { get; set; }
        public DateTime NextUpdate { get; set; }
        public Frequency()
        {
            Update();
        }
        public bool NeedsUpdate
        {
            get
            {
                return NextUpdate <= DateTime.Now;
            }
        }
        public string Update()
        {
            NextUpdate = DateTime.Now.AddMilliseconds(UpdateTime);
            return "'s Update() was invoked. Next update is at " + NextUpdate;
        }
    }
}
