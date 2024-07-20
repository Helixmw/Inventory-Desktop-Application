using InventoryApplication.DataAccess;
using InventoryApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApplication.Utilities
{
    public class CategoriesRepository : ICategoriesRepository
    {
        CategoryDataAccess _dbContext = new();
        public CategoriesRepository()
        {
          
        }

        public IEnumerable<ICategories> GetCategories()
        {
            var result = _dbContext.LoadData();
            return result;
        }

        public void AddCategory(ICategories category)
        {

        }
        public ICategories GetCategory(int id)
        {
            return null;
        }

        public void UpdateCategory(ICategories category)
        {

        }
        public void DeleteCategory(ICategories category)
        {

        }
    }
}
