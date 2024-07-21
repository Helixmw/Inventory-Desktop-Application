using InventoryApplication.Models;

namespace InventoryApplication.Utilities
{
    public interface IProductsRepository
    {
        Products AddProduct(Products product);
        void DeleteProduct(int id);
        IProducts GetProduct(int id);
        IEnumerable<IProducts> GetProducts();
        void UpdateProduct(IProducts product);
    }
}