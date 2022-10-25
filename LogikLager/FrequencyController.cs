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
        public void CreateFrequency10Sec()
        {
            _10sec frequencyObj = new _10sec();
            frequencyRepository.Insert(frequencyObj);
        }
        public void CreateFrequency30Sec()
        {
            _30sec frequencyObj = new _30sec();
            frequencyRepository.Insert(frequencyObj);
        }
        public void CreateFrequency1Min()
        {
            _1min frequencyObj = new _1min();
            frequencyRepository.Insert(frequencyObj);
        }

        public List<Frequency> RetrieveAllFrequencys() 
        { 
            return frequencyRepository.GetAll(); 
        }
    }
}
