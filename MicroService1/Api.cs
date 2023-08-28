namespace MicroService1;
using System.Web.Http.Cors;

public static class Api
{
    [EnableCors(origins: "https://microservicemandiri.azurewebsites.net", headers: "*", methods: "*")]
    public static void ConfigureApi(this WebApplication app)
    {
        // dta: All of my API endpoint mapping
        app.MapGet("/Categories", GetCategories);
        app.MapGet("/Categories/{categoryID}", GetCategory);
        app.MapPost("/Categories", InsertCategory);
        app.MapPut("/Categories", UpdateCategory);
        app.MapDelete("/Categories", DeleteCategory);

        app.MapGet("/Items", GetItems);
        app.MapGet("/Items/{itemID}", GetItem);
        app.MapPost("/Items", InsertItem);
        app.MapPut("/Items", UpdateItem);
        app.MapDelete("/Items", DeleteItem);
    }

     

    #region Category
    private static async Task<IResult> GetCategories(ICategoryData data)
    {
        try
        {
            return Results.Ok(await data.GetCategories());
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    } 

    private static async Task<IResult> GetCategory(int categoryID, ICategoryData data)
    {
        try
        {
            var results = await data.GetCategory(categoryID);
            if (results == null) return Results.NotFound();
            return Results.Ok(results);
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> InsertCategory(CategoryModel category, ICategoryData data)
    {
        try
        {
            await data.InsertCategory(category);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> UpdateCategory(CategoryModel category, ICategoryData data)
    {
        try
        {
            await data.UpdateCategory(category);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> DeleteCategory(int categoryID, ICategoryData data)
    {
        try
        {
            await data.DeleteCategory(categoryID);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    #endregion

    #region Item

    private static async Task<IResult> GetItems(IItemData data)
    {
        try
        {
            return Results.Ok(await data.GetItems());
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> GetItem(int itemID, IItemData data)
    {
        try
        {
            var results = await data.GetItem(itemID);
            if (results == null) return Results.NotFound();
            return Results.Ok(results);
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> InsertItem(ItemModel item, IItemData data)
    {
        try
        {
            await data.InsertItem(item);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> UpdateItem(ItemModel item, IItemData data)
    {
        try
        {
            await data.UpdateItem(item);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> DeleteItem(int itemID, IItemData data)
    {
        try
        {
            await data.DeleteItem(itemID);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    #endregion



}
