﻿using Models;
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
        public void CreateMedia(Category category, Frequency frequency, string url) 
        { 
            Media mediaObj = new Media(category, frequency, url); 
            mediaRepository.Insert(mediaObj); 
        }

        public List<Media> RetrieveAllParts() 
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

    }
}