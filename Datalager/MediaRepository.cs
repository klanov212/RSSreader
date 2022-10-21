﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DataLayer
{
    [Serializable]
    public class MediaRepository : IRepository<Media>
    {
        GenericSerializer<Media> MediaSerializer;
        List<Media> MediaList;
        public MediaRepository()
        {
            MediaSerializer = new GenericSerializer<Media>(nameof(MediaList));
            MediaList = GetAll();
        }
        public List<Media> GetAll() 
        {
            return MediaSerializer.Deserialize();
        }
        public Media GetByID(string id)

        {
            Media media = null;

            foreach (var item in MediaSerializer.Deserialize())
            {
                if (item.Name.Equals(id))
                { media = item; }
            }
            return media;
        }
        public void Insert(Media theObject) { MediaList.Add(theObject); SaveChanges(); }
        public void Update(int index, Media theNewObject) { if (index >= 0) { MediaList[index] = theNewObject; } SaveChanges(); }
        public void Delete(int index) { MediaList.RemoveAt(index); SaveChanges(); }
        public void SaveChanges() { MediaSerializer.Serialize(MediaList); }
    }
}
