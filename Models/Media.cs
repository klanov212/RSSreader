using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.ServiceModel;
using System.ServiceModel.Syndication;

namespace Models
{
    [Serializable]
    public class Media
    {
        public string Name { get; set; }
        public Category Category { get; set; }
        public Frequency Frequency { get; set; }
        public string Url { get; set; }
        public List<Episodes> AllEpisodes { get; set; }
        public int NumberOfEpisodes { get; set; }

        public Media(Category category, Frequency frequency, string url)
        {
            Category = category;
            Frequency = frequency;
            Url = url;
        }
        public Media(string name, Category category, Frequency frequency, string url)
        {
            Category = category;
            Frequency = frequency;
            Url = url;
            Name = name;
        }

        public Media()
        {

        }

        public void GetUrl(string url)
        {
            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();
            foreach (SyndicationItem item in feed.Items)
            {
                Episodes episode = new Episodes();
                episode.Title = item.Title.Text;
                episode.Description = item.Summary.Text;
                AllEpisodes.Add(episode);
            }
            //Om man ej fyllt i fältet för namn på feedet tas automatiskt namnet från feedet.
            if(Name == null) 
            { 
                Name = feed.Title.Text; 
            }           
            NumberOfEpisodes = AllEpisodes.Count();
        }

        public async Task GetUrlAsync(string url)
        {
            await Task.Run(() => GetUrl(url));
        }

        public List<Episodes> ListOfEpisodes()
        {
            return AllEpisodes;
        }
    }
}
