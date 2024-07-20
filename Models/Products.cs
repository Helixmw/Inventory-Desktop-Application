using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApplication.Models
{
    public class Products : IProducts
    {
        public int ProductId { get; set; }

        public string Name { get; set; } = null!;

        public int Quantity { get; set; }

        public int Price { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CategoryId { get; set; }

    }
}
