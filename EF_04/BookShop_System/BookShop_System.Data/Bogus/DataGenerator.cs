using Bogus;
using BookShop_System.Data.Models.Entities;
using BookShop_System.Data.Models.Enums;

namespace BookShop_System.Data.Bogus
{
    public class DataGenerator
    {
        public static readonly List<Author> Authors = new();
        public static readonly List<Book> Books = new();
        public static readonly List<Category> Categories = new();
        public static readonly List<BookCategory> BookCategories = new();

        private static int AUTHORS = 30;
        private static int BOOKS = 5;
        private static int CATEGORIES = 50;


        private static Faker<Author> GetAuthorGenerator()
        {
            return new Faker<Author>()
                .RuleFor(a => a.AuthorId, _ => Guid.NewGuid())
                .RuleFor(a => a.FirtsName, f => f.Name.FirstName())
                .RuleFor(a => a.LastName, f => f.Name.LastName());
        }
        private static Faker<Book> GetBookGenerator(Guid AuthorId)
        {
            return new Faker<Book>()
                .RuleFor(b => b.BookId, _ => Guid.NewGuid())
                .RuleFor(b => b.Title, f => f.Lorem.Word())
                .RuleFor(b => b.Description, f => f.Lorem.Text())
                .RuleFor(b => b.ReleaseDate,
                    f => f.Date.Between(DateTime.Now.AddYears(-50), DateTime.Now.AddYears(10)).OrNull(f, 0.2f))
                .RuleFor(b => b.Copies, f => f.Random.Int(0, 100000))
                .RuleFor(b => b.Price, f => f.Random.Decimal(10.0m, 10000.0m))
                .RuleFor(b => b.EditionType, f => f.PickRandom<EditionType>())
                .RuleFor(b => b.AgeRestriction, f => f.PickRandom<AgeRestriction>())
                .RuleFor(b => b.AuthorId, _ => AuthorId);
        }
        private static Faker<Category> GetCategoryGenerator()
        {
            return new Faker<Category>()
                .RuleFor(c => c.CategoryId, _ => Guid.NewGuid())
                .RuleFor(c => c.Name, f => f.Lorem.Word());
        }
        private static Faker<BookCategory> GetBookCategoryGenerator(Guid BookId, Guid CategoryId)
        {
            return new Faker<BookCategory>()
                .RuleFor(bc => bc.BookId, _ => BookId)
                .RuleFor(bc => bc.CategoryId, _ => CategoryId);
        }

        private static List<Book> GetBogusBookData(Guid AuthorId)
        {
            Faker<Book> bookGenerator = GetBookGenerator(AuthorId);
            List<Book> generatorBook = bookGenerator.Generate(BOOKS);

            return generatorBook;
        }
        private static List<BookCategory> GetBogusBookCategoryData(Guid BookId, Guid CategoryId)
        {
            Faker<BookCategory> bookCategoryGenerator = GetBookCategoryGenerator(BookId, CategoryId);
            List<BookCategory> generatorBookCategory = bookCategoryGenerator.Generate(1);

            return generatorBookCategory;
        }

        public static void InitBogusData()
        {
            Authors.AddRange(GetAuthorGenerator().Generate(AUTHORS));

            Authors.ForEach(author =>
                    Books.AddRange(GetBogusBookData(author.AuthorId)));

            Categories.AddRange(GetCategoryGenerator().Generate(CATEGORIES));

            Books.ForEach(book =>
            {
                var CategoryId = Categories[new Random().Next(0, CATEGORIES - 1)].CategoryId;

                if (!BookCategories.Any(bc => bc.BookId == book.BookId && bc.CategoryId == CategoryId))
                    BookCategories.AddRange(GetBogusBookCategoryData(book.BookId, CategoryId));
            });

            // Don't work with EF Core but work in console(not in db)
            //Books.ForEach(book =>
            //        BookCategories.AddRange(
            //            GetBogusBookCategoryData(
            //                book.BookId,
            //                Categories[new Random().Next(0, CATEGORIES - 1)].CategoryId
            //            )
            //        )
            //    );
        }
    }
}
