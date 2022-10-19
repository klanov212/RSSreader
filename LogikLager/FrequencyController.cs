using DataLayer;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class FrequencyController
    {
        IRepository<Frequency> frequencyRepository;
        public FrequencyController() 
        { 
            frequencyRepository = new FrequencyRepository(); 
        }
        public void CreateFrequency(string name)
        {
            Frequency frequencyObj = new Frequency(name);
            frequencyRepository.Insert(frequencyObj);
        }

        public List<Frequency> RetrieveAllFrequencys() 
        { 
            return frequencyRepository.GetAll(); 
        }
    }
}
