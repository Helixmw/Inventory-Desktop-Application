using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApplication.Models
{
    public class Categories : ICategories
    {
        public int CategoryId { get; set; }

        public string Name { get; set; } = null!;

        public int Total { get; set; }


    }
}
