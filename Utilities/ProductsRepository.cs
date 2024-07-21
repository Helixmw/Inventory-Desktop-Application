using InventoryApplication.DataAccess;
using InventoryApplication.Exceptions;
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

        public Products AddProduct(Products product)
        {
            try
            {
               return _productsAccess.Create(product);
            }
            catch (Exception)
            {
                throw new DatabaseOperationException("Something went wrong. Unable to add this product");
            }
        }

        public void EditProduct(Products product)
        {
            try
            {

            _productsAccess.UpdateProduct(product);
            }
            catch (Exception)
            {
                throw new DatabaseOperationException("Something went wrong. Unable to update this product");
            }
        }

        public delegate void RefreshProductsTable(Products products);

        public void UpdateTable(Action<Products> RefreshTable, Products products)
        {
            RefreshTable(products);
        }



        public void DeleteProduct(int id)
        {
            try
            {
                _productsAccess.DeleteProduct(id);
            }
            catch (Exception)
            {
                throw new DatabaseOperationException("Something went wrong. Unable to delete this product");
            }
        }


    }
}
