using InventoryApplication.Models;

namespace InventoryApplication.Utilities
{
    public interface IProductsRepository
    {
        Task<Products> AddProduct(Products product);
        Task DeleteProduct(Products product);
        IEnumerable<IProducts> GetProducts();
        void EditProduct(Products product);
    }
}