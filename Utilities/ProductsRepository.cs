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
    public class ProductsRepository : IProductsRepository
    {
        ProductsDataAccess _productsAccess = new();
        public ProductsRepository()
        {

        }

        public IEnumerable<IProducts> GetProducts()
        {
            try {
            var results = _productsAccess.LoadData();
            return results;
            }
            catch (Exception)
            {
                throw new DatabaseOperationException("Something went wrong. Unable to load Products list");
            }
        }

        public async Task<Products> AddProduct(Products product)
        {
            try
            {
                var new_product = await _productsAccess.Create(product);
                return new_product;
            }
            catch (Exception)
            {
                throw new DatabaseOperationException("Something went wrong. Unable to add this product");
            }
        }

        public async Task<List<Categories>> EditProduct(Products product)
        {
            try
            {

            var categories = await _productsAccess.UpdateProduct(product);
                return categories;
            }
            catch (Exception)
            {
                throw new DatabaseOperationException("Something went wrong. Unable to update this Product");
            }
        }

        public delegate void RefreshProductsTable(Products products);

        public void UpdateTable(Action<Products> RefreshTable, Products products)
        {
            RefreshTable(products);
        }



        public async Task DeleteProduct(Products product)
        {
            try
            {
                await _productsAccess.DeleteProduct(product);
            }
            catch (Exception)
            {
                throw new DatabaseOperationException("Something went wrong. Unable to delete this product");
            }
        }


    }
}
