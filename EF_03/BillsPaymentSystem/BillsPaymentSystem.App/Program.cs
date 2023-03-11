using BillsPaymentSystem.Data.Bogus;
using BillsPaymentSystem.Data.DBContext;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<BillsPaymentSystemContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("sqlConnection"),
        options => options.MigrationsAssembly("BillsPaymentSystem.App")));
DataGenerator.options.UseSqlServer(builder.Configuration.GetConnectionString("sqlConnection")!);


var app = builder.Build();


Console.WriteLine(DataGenerator
    .GetSeededUserFromDb(new Guid("2d57693d-8fec-4935-8641-5c2f0fb13cfc")) + "\n\n\n");
Console.WriteLine(DataGenerator
    .PayBills(new Guid("2d57693d-8fec-4935-8641-5c2f0fb13cfc"), 200));

app.Run();
