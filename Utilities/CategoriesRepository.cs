using InventoryApplication.DataAccess;
using InventoryApplication.Exceptions;
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
            try
            {
                var result = _dbContext.LoadData();
                return result;
            }
            catch (Exception)
            {
                throw new DatabaseOperationException("Something went wrong. Unable to load Categories list");
            }
        }

        public Categories AddCategory(string name)
        {
            try {
                 return _dbContext.Create(name);
                }
            catch (Exception)
                {
                throw new DatabaseOperationException("Something went wrong. Unable to add this Category");
             }
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
