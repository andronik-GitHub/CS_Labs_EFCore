using BillsPaymentSystem.Data.DBContext;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<BillsPaymentSystemContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("sqlConnection"),
        options => options.MigrationsAssembly("BillsPaymentSystem.App")));


var app = builder.Build();

app.Run();
