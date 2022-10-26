using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataLayer
{
    public class CategoryRepository : IRepository<Category>
    {
        GenericSerializer<Category> CategorySerializer;
        List<Category> CategoryList;
        public CategoryRepository()
        {
            CategoryList = new List<Category>();
            CategorySerializer = new GenericSerializer<Category>(nameof(CategoryList));
            CategoryList = GetAll();
        }
        public List<Category> GetAll() 
        {
            return CategorySerializer.Deserialize();
        }
        //Här används LINQ
        public Category GetByID(int index)
        {
            Category category = null;
            foreach (var item in CategorySerializer.Deserialize().Where(item => item.Name.Equals(index)))
            {
                category = item;
            }

            return category;
        }
        public void Insert(Category theObject) 
        { 
            CategoryList.Add(theObject); SaveChanges(); 
        }
        public void Update(int index, Category theNewObject) 
        { if (index >= 0) 
            { 
                CategoryList[index] = theNewObject; 
            } 
            SaveChanges(); 
        }
        public void Delete(int index) 
        { 
            CategoryList.RemoveAt(index); SaveChanges(); 
        }
        public void SaveChanges() 
        { 
            CategorySerializer.Serialize(CategoryList); 
        }

    }
}

