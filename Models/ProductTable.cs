using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApplication.Models
{
    public class ProductTable
    {
        public int ProductId { get; set; }

        public string Name { get; set; } = null!;

        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public int Quantity { get; set; }

        public int Price { get; set; }
        public string CreatedDate { get; set; } = null!;
    }
}
