using InventoryApplication.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApplication.Utilities.Validation
{
    internal static class QuantityPriceValidation
    {
        public static void CheckValueLimits(NumericUpDown quantity, NumericUpDown price)
        {
            if (quantity.Value > 1000 && price.Value > 10000000)
                throw new InvalidEntryException("Quantity and Price limits have been exceeded\n" +
                                                 "- Product Quantity exceeds the limit of 1,000 items\n" +
                                                 "- Product Price exceeds the limit cost of 10,000,000",
                                                 "Values Limit Error");

            else if (quantity.Value > 1000)
                throw new InvalidEntryException("Product Quantity has exceeded the limit of 1,000 items",
                    "Values Limit Error");

            else if (price.Value > 10000000)
                throw new InvalidEntryException("Product Price has exceeded the limit cost of 10,000,000",
                    "Values Limit Error");

            
        }
    }
}
