using BookShop_System.Data.Bogus;
using BookShop_System.Data.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<BookShopContext>(
    options =>
    {
        options.UseSqlServer(
                builder.Configuration.GetConnectionString("sqlConnection"),
                options => options.MigrationsAssembly("BookShop_System")
            );
    });


var app = builder.Build();


#region Problems
{
    GetDataFromDb.options.UseSqlServer(builder.Configuration.GetConnectionString("sqlConnection"));

    // Problem 01
    //Console.Write("Input command: ");
    //Console.WriteLine("Books:\n" + GetDataFromDb.GetBooksByAgeRestriciton(Console.ReadLine()!));

    // Problem 02
    //Console.WriteLine("Golden Books:\n" + GetDataFromDb.GetGoldenBooks());

    // Problem 03
    //Console.WriteLine("Books by price:\n" + GetDataFromDb.GetBooksByPrice());

    // Problem 04
    //Console.Write("Input year: ");
    //Console.WriteLine("Books is not realeased in this year:\n" + 
    //    GetDataFromDb.GetBooksNotRealeased(Convert.ToInt32(Console.ReadLine()!)));

    // Problem 05
    //Console.Write("Categories:\n" + GetDataFromDb.GetBooksByCategory(null) + "\nInput category: ");
    //Console.WriteLine("Books by this category:\n\n" +
    //    GetDataFromDb.GetBooksByCategory(Console.ReadLine()));

    // Problem 06
    //Console.Write("Input date(dd-mm-yyyy): ");
    //Console.WriteLine("Books released before this date:" + 
    //    GetDataFromDb.GetBookReleasedBefore(Console.ReadLine()!));

    // Problem 07
    //Console.Write("Input sufix: ");
    //Console.WriteLine("Authors, whose first name ends with a this sufix:\n" + GetDataFromDb.GetAuthorNamesEnglishIn(Console.ReadLine()!));

    // Problem 08
    //Console.Write("Input string: ");
    //Console.WriteLine("Books:\n" + GetDataFromDb.GetBookTitlesContaining(Console.ReadLine()!));

    // Problem 09
    //Console.Write("Input string: ");
    //Console.WriteLine("Books:\n" + GetDataFromDb.GetBookByAuthor(Console.ReadLine()!));

    // Problem 10
    //Console.Write("Input lengthCheck: ");
    //Console.WriteLine(GetDataFromDb.CountBooks(Convert.ToInt32(Console.ReadLine()!)));

    // Problem 11
    //Console.WriteLine(GetDataFromDb.CountCopiesByAuthor());

    // Problem 12
    //Console.WriteLine(GetDataFromDb.GetTotalProfitByCategory());

    // Problem 13
    //Console.WriteLine(GetDataFromDb.GetMostRecentBooks());

    // Problem 14
    //Console.WriteLine(GetDataFromDb.IncreasePrices());

    // Problem 15
    //Console.WriteLine(GetDataFromDb.RemoveBooks());
}
#endregion

app.Run();
