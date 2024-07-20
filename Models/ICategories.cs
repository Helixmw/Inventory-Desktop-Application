namespace InventoryApplication.Models
{
    public interface ICategories : IEntity
    {
        int CategoryId { get; set; }
        int Total { get; set; }
    }
}