using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

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
            FileName = fName+".xml";
        }



        public void Serialize(List<T> list)
        {
            List<T> list2 = list;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));
                using (FileStream xmlOut =
                    new FileStream(fileName, FileMode.Create, FileAccess.Write))
                {
                    xmlSerializer.Serialize(xmlOut, list2);
                }
        }

        public List<T> Deserialize()
        {
            List<T> list;
            if (File.Exists(fileName))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));
                using (FileStream xmlIn =
                    new FileStream(fileName, FileMode.Open, FileAccess.Read))
                {
                    list = (List<T>)xmlSerializer.Deserialize(xmlIn);
                }
                return list;
            }
            else 
            { 
                return new List<T>(); 
            
            }               
        }
    }
}
