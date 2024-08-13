using InventoryApplication.Exceptions;
using InventoryApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApplication.Utilities.Validation
{
    public static class CategoryValidation
    {
        public static void ValidateInput(string name)
        {
            if (name == String.Empty)
                throw new InvalidEntryException("Please fill in all the fields");
        }

        public static void CategoryExists(string name, List<ICategories> categories)
        {
            var category = categories.Where(x => x.Name.ToLower() == name.Trim().ToLower()).FirstOrDefault();
            if(category is not null)
                throw new InvalidEntryException("Category already exists. Try a different name");
        }
    }
}
