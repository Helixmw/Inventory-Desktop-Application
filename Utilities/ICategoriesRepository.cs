using InventoryApplication.Models;

namespace InventoryApplication.Utilities
{
    public interface ICategoriesRepository
    {
        void AddCategory(ICategories category);
        void DeleteCategory(ICategories category);
        IEnumerable<ICategories> GetCategories();
        ICategories GetCategory(int id);
        void UpdateCategory(ICategories category);
    }
}