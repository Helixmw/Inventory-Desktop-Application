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
    }
}
