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
        public FrequencyController() { frequencyRepository = new FrequencyRepository(); }
        public void CreateFrequency(string name, int interval)
        {
            Frequency frequencyObj = new Frequency(name, interval);
            frequencyRepository.Insert(frequencyObj);
        }

        public List<Frequency> RetrieveAllFrequencys() { return frequencyRepository.GetAll(); }
    }
}
