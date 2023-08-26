using DataAccess.DbAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data;
public class CategoryData : ICategoryData
{
    private readonly ISqlDataAccess _db;

    public CategoryData(ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<IEnumerable<CategoryModel>> GetCategories() =>
        _db.LoadData<CategoryModel, dynamic>("dbo.spCategory_GetAll", new { });

    public async Task<CategoryModel?> GetCategory(int categoryID)
    {
        var results = await _db.LoadData<CategoryModel, dynamic>(
            "dbo.spCategory_Get",
            new { CategoryID = categoryID });

        return results.FirstOrDefault();
    }

    public Task InsertCategory(CategoryModel category) =>
        _db.SaveData("dbo.spCategory_Insert", new { category.Name });

    public Task UpdateCategory(CategoryModel category) =>
        _db.SaveData("dbo.spCategory_Update", new { category });

    public Task DeleteCategory(int categoryID) =>
        _db.SaveData("dbo.spCategory_Delete", new { CategoryID = categoryID });


}
