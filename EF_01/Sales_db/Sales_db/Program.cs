using Microsoft.EntityFrameworkCore;
using Sales_db.Data;


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<SalesContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("sqlConnection")));


builder.Services.AddControllers();
builder.Services.AddSwaggerGen(); // Swagger


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

app.MapControllers();
app.Run();
