using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public DateTime UpdateNext { get; set; }
        public Frequency()
        {            
            Update();
        }
        public bool NeedsUpdate
        {
            get
            {
                // Om nästa uppdatering är innan nuvarande klockslag så ska en uppdatering ske
                // dvs metoden NeedsUpdate ska returnera true
                return UpdateNext <= DateTime.Now;
            }
        }
        public void Update()
        {
            // nästa uppdatering sker om "UpdateInterval" minuter
            // Vi hittar den tidpunkten genom att lägga till det antalet millisekunder till den 
            // nuvarande tiden.
            UpdateNext = DateTime.Now.AddMilliseconds(UpdateTime);           
        }
    }
}
