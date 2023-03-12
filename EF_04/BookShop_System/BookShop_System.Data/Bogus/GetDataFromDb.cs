using BookShop_System.Data.DBContext;
using BookShop_System.Data.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Update.Internal;
using Microsoft.IdentityModel.Tokens;
using System.Reflection.Metadata.Ecma335;

namespace BookShop_System.Data.Bogus
{
    public class GetDataFromDb
    {
        public static DbContextOptionsBuilder<BookShopContext> options = new();
        private static BookShopContext dbContext = new(options.Options);

        public static string GetBooksByAgeRestriciton(string command) // Problem 01
        {
            dbContext = new(options.Options);

            var books = dbContext.Books
                .AsEnumerable()
                .Where(book =>
                    (book.AgeRestriction == AgeRestriction.Teen && command.ToLower() == "teen") ||
                    (book.AgeRestriction == AgeRestriction.Adult && command.ToLower() == "adult") ||
                    (book.AgeRestriction == AgeRestriction.Minor && command.ToLower() == "minor")
                )
                .OrderBy(book => book.Title)
                .Select(book => book.Title)
                .ToList();

            if (books.Count == 0) return "Result not found!";
            return string.Join(Environment.NewLine, books);
        }
        public static string GetGoldenBooks() // Problem 02
        {
            dbContext = new(options.Options);

            var books = dbContext.Books
                .AsEnumerable()
                .Where(book => book.EditionType == EditionType.Gold && book.Copies < 5000)
                .OrderBy(book => book.BookId)
                .Select(book => book.Title)
                .ToList();


            if (books.Count == 0) return "Result not found!";
            return string.Join(Environment.NewLine, books);
        }
        public static string GetBooksByPrice() // Problem 03
        {
            dbContext = new(options.Options);

            var books = dbContext.Books
                .AsEnumerable()
                .Where(book => book.Price > 40)
                .OrderByDescending(book => book.Price)
                .Select(book => book.Title + "   $" + book.Price)
                .ToList();

            if (books.Count == 0) return "Result not found!";
            return string.Join(Environment.NewLine, books);
        }
        public static string GetBooksNotRealeased(int year) // Problem 04
        {
            dbContext = new(options.Options);

            var books = dbContext.Books
                .AsEnumerable()
                .Where(book => book.ReleaseDate != null && book.ReleaseDate.Value.Year != year)
                .OrderBy(book => book.BookId)
                .Select(book => book.Title)
                .ToList();

            if (books.Count == 0) return "Result not found!";
            return string.Join(Environment.NewLine, books);
        }
        public static string GetBooksByCategory(string? input) // Problem 05
        {
            dbContext = new(options.Options);
            List<string> list = new();

            if (input.IsNullOrEmpty()) // input all categories
            {
                list = dbContext.Categories
                    .Select(category => category.Name + ", ")
                    .ToList();
            }
            else // input all bookTitle by category
            {
                list = dbContext.Books.Join(
                    dbContext.BookCategories.Join(
                        dbContext.Categories.Where(c => c.Name == input),
                        bc => bc.CategoryId,
                        c => c.CategoryId,
                        (bc, c) => new
                        {
                            bc.BookId,
                            c.CategoryId,
                        }),
                    book => book.BookId,
                    bookCategory => bookCategory.BookId,
                    (b, bc) => new
                    {
                        b.Title
                    })
                    .Select(book => book.Title)
                    .ToList();
            }

            if (list.Count == 0) return "Result not found!";
            return string.Join(Environment.NewLine, list);
        }
        public static string GetBookReleasedBefore(string date) // Problem 06
        {
            dbContext = new(options.Options);
            List<string> books = new();

            try
            {
                var Date = new DateTime(
                        Convert.ToInt32(date.Split('-', ',', '.', ':', ':', ' ')[2]),
                        Convert.ToInt32(date.Split('-', ',', '.', ':', ':', ' ')[1]),
                        Convert.ToInt32(date.Split('-', ',', '.', ':', ':', ' ')[0])
                    );

                books = dbContext.Books
                    .AsEnumerable()
                    .Where(book => book.ReleaseDate != null && book.ReleaseDate < Date)
                    .OrderBy(book => book.ReleaseDate)
                    .Select(book => book.Title + "   $" + book.Price)
                    .ToList();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            if (books.Count == 0) return "Result not found!";
            return string.Join(Environment.NewLine, books);
        }
        public static string GetAuthorNamesEnglishIn(string input) // Problem 07
        {
            dbContext = new(options.Options);

            var authorNames = dbContext.Authors
                .AsEnumerable()
                .Where(author => author.FirtsName.EndsWith(input))
                .OrderBy(author => author.FirtsName)
                .Select(author => author.FirtsName + " " + author.LastName)
                .ToList();

            if (authorNames.Count == 0) return "Result not found!";
            return string.Join(Environment.NewLine, authorNames);
        }
        public static string GetBookTitlesContaining(string input) // Problem 08
        {
            dbContext = new(options.Options);

            var books = dbContext.Books
                .AsEnumerable()
                .Where(book => book.Title.Contains(input, StringComparison.InvariantCultureIgnoreCase))
                .Select(book => book.Title)
                .ToList();

            if (books.Count == 0) return "Result not found!";
            return string.Join(Environment.NewLine, books);
        }
        public static string GetBookByAuthor(string input) // Problem 09
        {
            dbContext = new(options.Options);

            var books = dbContext.Books
                .AsEnumerable()
                .Join(
                    dbContext.Authors
                        .AsEnumerable()
                        .Where(author => author.LastName.StartsWith(input, StringComparison.InvariantCultureIgnoreCase))
                        .Select(author => author)
                        .ToList(),
                    book => book.AuthorId,
                    author => author.AuthorId,
                    (book, author) => new
                    {
                        book.Title,
                        authorName = author.FirtsName + " " + author.LastName
                    }
                )
                .Select(obj => obj.Title + "(" + obj.authorName + ")")
                .ToList();

            if (books.Count == 0) return "Result not found!";
            return string.Join(Environment.NewLine, books);
        }
        public static string CountBooks(int lengthCheck) // Problem 10
        {
            dbContext = new(options.Options);

            var countBooks = dbContext.Books
                .AsEnumerable()
                .Where(book => book.Title.Length > lengthCheck)
                .Count();

            return $"There are {countBooks} books with longer title than {lengthCheck} symbols";
        }
        public static string CountCopiesByAuthor() // Problem 11
        {
            dbContext = new(options.Options);

            var result = dbContext.Books
                .Join(
                    dbContext.Authors,
                    book => book.AuthorId,
                    author => author.AuthorId,
                    (book, author) => new
                    {
                        book,
                        author
                    }
                )
                .GroupBy(obj => obj.author.FirtsName + " " + obj.author.LastName)
                .Select(obj => obj.Key + " - " + obj.Sum(s => s.book.Copies))
                .ToList();

            return string.Join(Environment.NewLine, result);
        }
        public static string GetTotalProfitByCategory() // Problem 12
        {
            dbContext = new(options.Options);

            var retult = dbContext.Books.AsEnumerable().Join(
                    dbContext.BookCategories.Join(
                        dbContext.Categories,
                        bc => bc.CategoryId,
                        c => c.CategoryId,
                        (bc, c) => new
                        {
                            bc.BookId,
                            CategoryName = c.Name
                        })
                        .ToList(),
                    book => book.BookId,
                    bc => bc.BookId,
                    (book, bc) => new
                    {
                        TotalPrice = book.Copies * book.Price,
                        bc.CategoryName
                    })
                    .GroupBy(obj => obj.CategoryName)
                    .OrderBy(obj => obj.Key)
                    .ThenByDescending(obj => obj.Sum(s => s.TotalPrice))
                    .Select(obj => obj.Key + "   $" + obj.Sum(s => s.TotalPrice))
                    .ToList();

            return string.Join(Environment.NewLine, retult);
        }
        public static string GetMostRecentBooks() // Problem 13
        {
            dbContext = new(options.Options);


            var result = 
                dbContext.Books.AsEnumerable().Join(
                    dbContext.BookCategories.Join(
                        dbContext.Categories,
                        bc => bc.CategoryId,
                        caregory => caregory.CategoryId,
                        (BookCategory, Category) => new
                        {
                            BookCategory.BookId,
                            CategoryName = Category.Name
                        })
                        .ToList(),
                    book => book.BookId,
                    bc => bc.BookId,
                    (book, bc) => new
                    {
                        book.Title,
                        book.ReleaseDate,
                        book.Copies,
                        bc.CategoryName
                    })
                    .ToList()
                    .GroupBy(obj => obj.CategoryName)
                    .OrderBy(obj => obj.Sum(s => s.Copies))
                    .Select(group => 
                    $"--{group.Key}\n" +
                    $"{
                        string.Join(
                                "\n", 
                                group
                                .OrderByDescending(s => s.ReleaseDate)
                                .Select(book => book.Title + " (" + 
                                    (book.ReleaseDate == null ? "Not released" : book.ReleaseDate.Value.Year) + ")"
                                )
                                .Take(3)
                            )
                    }")
                    .ToList();


            return string.Join(Environment.NewLine, result);
        }
        public static string IncreasePrices() // Problem 14
        {
            dbContext = new(options.Options);

            var beforeBooks = dbContext.Books
                .OrderBy(b => b.Title)
                .Where(b => b.ReleaseDate != null && b.ReleaseDate.Value.Year > 2010)
                .Select(b => b.Title.PadRight(25, ' ') + " $" + b.Price)
                .Take(5)
                .ToList();

            dbContext.Books
                .Where(b => b.ReleaseDate != null && b.ReleaseDate.Value.Year > 2010)
                .ToList()
                ?.ForEach(book => book.Price *= 5);
            dbContext.SaveChanges();


            return string.Join(Environment.NewLine, beforeBooks);
        }
        public static string RemoveBooks() // Problem 15
        {
            dbContext = new(options.Options);

            int count = 4200;
            int countDeleted = dbContext.Books.Where(book => book.Copies < count).Count();

            dbContext.Books.RemoveRange(
                    dbContext.Books.Where(book => book.Copies < count).ToList()
                );
            dbContext.SaveChanges();

            return $"{countDeleted} books with fewer than {count} copies were removed from the database";
        }
    }
}
