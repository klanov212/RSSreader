using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    [Serializable]
    public class FrequencyRepository : IRepository<Frequency>
    {
        GenericSerializer<Frequency> FrequencySerializer;
        List<Frequency> FrequencyList;
        public FrequencyRepository()
        {
            FrequencyList = new List<Frequency>(); 
            FrequencySerializer = new GenericSerializer<Frequency>(nameof(FrequencyList));
        }
        public List<Frequency> GetAll() { return FrequencySerializer.Deserialize(); }
        public Frequency GetByID(string id)

        {
            Frequency frequency = null;

            foreach (var item in FrequencySerializer.Deserialize())
            {
                if (item.Name.Equals(id))
                { frequency = item; }
            }
            return frequency;
        }
        public void Insert(Frequency theObject) 
        { 
            FrequencyList.Add(theObject); SaveChanges(); 
        }
        public void Update(int index, Frequency theNewObject) 
        { if (index >= 0) 
            { 
                FrequencyList[index] = theNewObject; 
            } 
            SaveChanges(); 
        }
        public void Delete(int index) 
        {
            FrequencyList.RemoveAt(index); SaveChanges(); 
        }
        public void SaveChanges() 
        { 
            FrequencySerializer.Serialize(FrequencyList); 
        }
    }
}
