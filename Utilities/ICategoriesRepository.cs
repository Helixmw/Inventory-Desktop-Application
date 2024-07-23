using InventoryApplication.Models;

namespace InventoryApplication.Utilities
{
    public interface ICategoriesRepository
    {
        Categories AddCategory(string name);
        void DeleteCategory(ICategories category);
        IEnumerable<ICategories> GetCategories();
        ICategories GetCategory(int id);
        void UpdateCategory(ICategories category);
    }
}