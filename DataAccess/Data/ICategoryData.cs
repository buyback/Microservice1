using DataAccess.Models;

namespace DataAccess.Data;
public interface ICategoryData
{
    Task DeleteCategory(int categoryID);
    Task<IEnumerable<CategoryModel>> GetCategories();
    Task<CategoryModel?> GetCategory(int categoryID);
    Task InsertCategory(CategoryModel category);
    Task UpdateCategory(CategoryModel category);
}