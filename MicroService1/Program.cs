using DataAccess.DbAccess;
using MicroService1;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// dta: add DI
builder.Services.AddSingleton<ISqlDataAccess, SqlDataAccess>();
builder.Services.AddSingleton<ICategoryData, CategoryData>();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
app.UseSwagger();
app.UseSwaggerUI();
//}

// dta: not allowed user to use http
app.UseHttpsRedirection();

app.ConfigureApi();

app.Run();
