using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using DataLayer;
using Models;

namespace DataLayer
{
    public class GenericSerializer<T>
    {
        private string fileName;
        public string FileName
        {
            set
            {
                fileName = value;
            }
        }
        public GenericSerializer(string fName)
        {
            FileName = fName + ".xml";
        }

        public void Serialize(List<T> list)
        {    
            
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));
            using (FileStream xmlOut =
                new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read))
            {
                xmlSerializer.Serialize(xmlOut, list);

            }
        }

        public List<T> Deserialize()
        {
            List<T> list;
            if (File.Exists(fileName))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));
                using (FileStream xmlIn =
                    new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Write))
                {
                    list = (List<T>)xmlSerializer.Deserialize(xmlIn);
                }
                return list;
            }
            return new List<T>();

        }


    }
}

