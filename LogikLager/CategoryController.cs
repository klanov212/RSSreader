using DataLayer;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LogicLayer
{
    public class CategoryController
    {
        IRepository<Category> categoryRepository;
        public CategoryController() 
        { 
            categoryRepository = new CategoryRepository(); 
        }
        public void CreateCategory(string name)
        {
            Category categoryObj = new Category(name);
            categoryRepository.Insert(categoryObj);
            
        }

        public List<Category> RetrieveAllCategorys() 
        { 
            return categoryRepository.GetAll(); 
        }
        public void DeleteCategory(int index)
        {
            categoryRepository.Delete(index);
        }
        public Category UpdateCategory(int index, string name)
        {
            Category categoryObj = new Category(name);
            categoryRepository.Update(index, categoryObj);
            return categoryObj;
        }
    }
}
