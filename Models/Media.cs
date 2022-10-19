using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]
    public class Media
    {
        public string Name { get; set; }
        public Category Category { get; set; }
        public Frequency Frequency { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public int NumberOfEpisodes { get; set; }

        public Media(Category category, Frequency frequency, string url)
        {
            Category = category;
            Frequency = frequency;
            Url = url;
        }
        public Media()
        {

        }

    }
}