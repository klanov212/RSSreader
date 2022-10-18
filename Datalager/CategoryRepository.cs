using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }
        public List<Category> GetAll() 
        { 
            return CategorySerializer.Deserialize(); 
        }
        public Category GetByID(string id)
        {
            Category category = null;

            foreach (var item in CategorySerializer.Deserialize())
            {
                if (item.Name.Equals(id))
                { category = item; }
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

