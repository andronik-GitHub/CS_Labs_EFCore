using BookShop_System.Data.DBContext;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<BookShopContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("sqlConnection"),
        options => options.MigrationsAssembly("BookShop_System")));


var app = builder.Build();

app.Run();
