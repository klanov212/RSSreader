using Models;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class MediaController
    {
        IRepository<Media> mediaRepository; 
        public MediaController() { mediaRepository = new MediaRepository(); }
        public void CreateMedia(string name, Category category, Frequency frequency, string url, string description, int numberOfEpisodes) 
        { 
            Media mediaObj = new Media(name, category, frequency, url, description, numberOfEpisodes); 
            mediaRepository.Insert(mediaObj); 
        }

        public List<Media> RetrieveAllParts() { return mediaRepository.GetAll(); }
        
    }
}