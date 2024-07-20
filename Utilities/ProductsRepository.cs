using InventoryApplication.DataAccess;
using InventoryApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApplication.Utilities
{
    public class ProductsRepository : IProductsRepository
    {
        ProductsDataAccess _productsAccess = new();
        public ProductsRepository()
        {

        }

        public IEnumerable<IProducts> GetProducts()
        {
            var results = _productsAccess.LoadData();
            return results;
        }

        public void AddProduct(IProducts product)
        {

        }

        public IProducts GetProduct(int id)
        {
            return null;
        }

        public void UpdateProduct(IProducts product)
        {

        }

        public void DeleteProduct(int id)
        {

        }


    }
}
