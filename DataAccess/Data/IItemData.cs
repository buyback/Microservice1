using DataAccess.Models;

namespace DataAccess.Data;
public interface IItemData
{
    Task DeleteItem(int itemID);
    Task<IEnumerable<ItemModel>> GetItems();
    Task<ItemModel?> GetItem(int itemID);
    Task InsertItem(ItemModel item);
    Task UpdateItem(ItemModel item);
}