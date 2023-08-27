namespace MicroService1;

public static class Api
{
    public static void ConfigureApi(this WebApplication app)
    {
        // dta: All of my API endpoint mapping
        app.MapGet("/Categories", GetCategories);
        app.MapGet("/Categories/{id}", GetCategory);
        app.MapPost("/Categories", InsertCategory);
        app.MapPut("/Categories", UpdateCategory);
        app.MapDelete("/Categories", DeleteCategory);
    }

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




}
