using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]
    public class Category
    {
        public string Name { get; set; }

        public Category(string name)
        {
            Name = name;
        }
        public Category()
        {

        }
        public List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();
            return categories;
        }

        public List<Category> AddCategory(Category category)
        {
            if (!GetCategories().Contains(category))
            {
                GetCategories().Add(category);
            }
            return GetCategories();
        }
    }

}
