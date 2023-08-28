using DataAccess.DbAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data;
public class ItemData : IItemData
{
    private readonly ISqlDataAccess _db;

    public ItemData(ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<IEnumerable<ItemModel>> GetItems() =>
        _db.LoadData<ItemModel, dynamic>("dbo.spItem_GetAll", new { });

    public async Task<ItemModel?> GetItem(int itemID)
    {
        var results = await _db.LoadData<ItemModel, dynamic>(
            "dbo.spItem_Get",
            new { ItemID = itemID });

        return results.FirstOrDefault();
    }

    public Task InsertItem(ItemModel item) =>
        _db.SaveData("dbo.spItem_Insert", new { CategoryID = item.CategoryID, item.Name, Description = item.Description });

    public Task UpdateItem(ItemModel item) =>
        _db.SaveData("dbo.spItem_Update", new { CategoryID = item.CategoryID, ItemID = item.ItemID, Name = item.Name, Description = item.Description });

    public Task DeleteItem(int itemID) =>
        _db.SaveData("dbo.spItem_Delete", new { ItemID = itemID });


}
