using InventoryApplication.Models;

namespace InventoryApplication.Utilities
{
    public interface ICategoriesRepository
    {
        List<Categories> AddCategory(string name);
        List<Categories> DeleteCategory(Categories category);
        IEnumerable<ICategories> GetCategories();
        ICategories GetCategory(int id);
        void UpdateCategory(ICategories category);
    }
}