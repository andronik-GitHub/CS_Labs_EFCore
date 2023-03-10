using Bogus;
using Microsoft.EntityFrameworkCore;
using Student_System.Data;
using Student_System.Data.Bogus;


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<StudentSystemContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("sqlConnection")));


var app = builder.Build();


Console.WriteLine("DB Seeded Studens:");
DataGenerator.GetSeededStudentsFromDb(builder.Configuration.GetConnectionString("sqlConnection")!)
    .ForEach(Console.WriteLine);

Console.WriteLine("\n\n\n\n\n\n");

Console.WriteLine("DB Seeded Courses:");
DataGenerator.GetSeededCoursesFromDb(builder.Configuration.GetConnectionString("sqlConnection")!)
    .ForEach(Console.WriteLine);


app.Run();
