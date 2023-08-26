using System.Collections.Generic;

namespace MicroService1.Methods;

public class CategoryMethod
{
    public int CategoryID { get; set; }
    public string Name { get; set; }
    public CategoryMethod(string Name)
    {
        this.Name = Name;
    }

    public CategoryMethod()
    {
    }

    public List<CategoryMethod> GetCategories(int categoryID)
    {
        // open connection, get all categories
        List<CategoryMethod> list = new List<CategoryMethod>();
        try
        {
            return list;
        }
        catch (Exception ex)
        {
            throw ex;
            return list;
        }

    }

    public void Create(CategoryMethod data)
    {
        // open connection, save to database
    }

    public void Update(CategoryMethod data)
    {
        // open connection, save to database
    }

    public void Delete(CategoryMethod data)
    {
        // open connection, save to database
    }
}


