using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.ServiceModel;
using System.ServiceModel.Syndication;
using Octokit;

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

        //Här används LINQ
        public async Task<List<SyndicationItem>> GetUrlAsync(string url)
        {
            return await Task.Run(() =>
            {
                XmlReader reader = XmlReader.Create(url);
                SyndicationFeed feed = SyndicationFeed.Load(reader);
                reader.Close();
                Name = feed.Title.Text;
                return feed.Items.ToList();
                
                
            });
        }

        public List<Episodes> SetEpisodes(List<SyndicationItem> feedList)
        {   
            List<Episodes> episodes = new List<Episodes>();
            foreach (var item in feedList)
            {
                Episodes episode = new Episodes();
                episode.Title = item.Title.Text;
                episode.Description = item.Summary.Text;
                
                episodes.Add(episode);
            }
           
            return episodes;
        }

        public List<Episodes> ListOfEpisodes()
        {
            return AllEpisodes;
        }
    }
}
