using InventoryApplication.Exceptions;
using InventoryApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApplication.Utilities.Validation
{
    public static class ProductValidation
    {
        public static void ValidateInput(Products products)
        {
            if (products.Name == String.Empty || products.CategoryId == 0 || products.Quantity == 0 || products.Price == 0)
                throw new InvalidEntryException("Please fill in all the fields");
        }
    }
}
