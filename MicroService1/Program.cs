using DataAccess.DbAccess;
using MicroService1;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// dta: add DI
builder.Services.AddSingleton<ISqlDataAccess, SqlDataAccess>();
builder.Services.AddSingleton<ICategoryData, CategoryData>();
builder.Services.AddSingleton<IItemData, ItemData>();

builder.Services.AddCors();

builder.Services.AddCors(options => options.AddPolicy("ApiCorsPolicy", builder =>
{
    //builder.WithOrigins("https://microservicemandiri.azurewebsites.net").AllowAnyMethod().AllowAnyHeader();
    builder.WithOrigins("https://localhost:7010").AllowAnyMethod().AllowAnyHeader();
}));

builder.Services.AddMvcCore();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
app.UseSwagger();
app.UseSwaggerUI();
//}

app.UseCors("ApiCorsPolicy");

// dta: not allowed user to use http
app.UseHttpsRedirection();

app.ConfigureApi();

app.Run();
