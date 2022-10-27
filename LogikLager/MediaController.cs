using Models;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Syndication;

namespace LogicLayer
{
    public class MediaController
    {
        IRepository<Media> mediaRepository; 
        public MediaController() { mediaRepository = new MediaRepository(); }
        public async void CreateMedia(Category category, Frequency frequency, string url) 
        { 
            Media mediaObj = new Media(category, frequency, url);
            Task<List<SyndicationItem>> GetUrlData = mediaObj.GetUrlAsync(mediaObj.Url);
            List<SyndicationItem> feedList = await GetUrlData;
            mediaObj.AllEpisodes = mediaObj.SetEpisodes(feedList);
            mediaObj.NumberOfEpisodes = mediaObj.AllEpisodes.Count();
            mediaRepository.Insert(mediaObj); 
        }

        public List<Media> RetrieveAllMedia() 
        { 
            return mediaRepository.GetAll(); 
        }
        public void DeleteMedia(int index)
        {
            mediaRepository.Delete(index);
        }
        public void UpdateMedia(int index, Category category, Frequency frequency, string url)
        {
            Media mediaObj = new Media(category, frequency, url);
            mediaRepository.Update(index, mediaObj);
        }
        public Media GetMediaById(int index)
        {
            return mediaRepository.GetByID(index);
        }
    }
}