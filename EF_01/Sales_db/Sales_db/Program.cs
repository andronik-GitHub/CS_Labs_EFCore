using Microsoft.EntityFrameworkCore;
using Sales_db.Data;
using Sales_db.Data.Bogus;

var builder = WebApplication.CreateBuilder(args);


//builder.Services.AddControllers();
builder.Services.AddDbContext<SalesContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("sqlConnection")));


var app = builder.Build();

// Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = string.Empty;
    });
}


Console.WriteLine("DB Seeded Product: ");
DataGenerator.InitBogusData();
Console.WriteLine(DataGenerator.Sales.Count);


//app.MapControllers();
app.Run();

