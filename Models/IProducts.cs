
namespace InventoryApplication.Models
{
    public interface IProducts : IEntity
    {
        int CategoryId { get; set; }
        DateTime CreatedDate { get; set; }
        int Price { get; set; }
        int ProductId { get; set; }
        int Quantity { get; set; }
    }
}