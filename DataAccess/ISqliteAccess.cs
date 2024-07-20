
namespace InventoryApplication.DataAccess
{
    public interface ISqliteAccess<T> where T : class
    {
        void Create(T Value);
        string LoadConnectionString(string id = "DefaultConnectionString");
        List<T> LoadData();
    }
}