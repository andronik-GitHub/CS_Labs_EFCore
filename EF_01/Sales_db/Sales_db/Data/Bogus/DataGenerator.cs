using Bogus;
using Sales_db.Data.Models;

namespace Sales_db.Data.Bogus
{
    public class DataGenerator
    {
        public static readonly List<Products> Products = new();
        public static readonly List<Customers> Customers = new();
        public static readonly List<Stores> Stores = new();
        public static readonly List<Sales> Sales = new();

        public const int PRODUCTS = 30;
        public const int CUSTOMERS = 100;
        public const int STORES = 10;
        public const int SALES = 5;


        private static Faker<Sales> GetSaleGenerator(Guid ProductId, Guid CustomerId, Guid StoreId)
        {
            return new Faker<Sales>()
                .RuleFor(s => s.SaleId, _ => Guid.NewGuid())
                .RuleFor(s => s.Date, f => f.Date.Past(5))
                .RuleFor(s => s.ProductId, _ => ProductId)
                .RuleFor(s => s.CustomerId, _ => CustomerId)
                .RuleFor(s => s.StoreId, _ => StoreId);
        }
        private static Faker<Products> GetProductGenerator()
        {
            return new Faker<Products>()
                .RuleFor(p => p.ProductId, _ => Guid.NewGuid())
                .RuleFor(p => p.Name, f => f.Lorem.Word())
                .RuleFor(p => p.Quantity, f => f.Random.Int(0, 10000))
                .RuleFor(p => p.Price, f => f.Random.Decimal(10.0m, 99999.99m));
        }
        public static Faker<Customers> GetCustomerGenerator()
        {
            return new Faker<Customers>()
                .RuleFor(c => c.CustomerId, _ => Guid.NewGuid())
                .RuleFor(c => c.Name, f => f.Name.FullName())
                .RuleFor(c => c.Email, (f, e) => f.Internet.Email(e.Name))
                .RuleFor(c => c.CreaditCardNumber, f => f.Finance.CreditCardNumber());
        }
        public static Faker<Stores> GetStoreGenerator()
        {
            return new Faker<Stores>()
                .RuleFor(s => s.StoreId, _ => Guid.NewGuid())
                .RuleFor(s => s.Name, f => f.Lorem.Word());
        }


        // Для створення вкладених об'єктів Sales
        public static List<Sales> GetBogusSalesData(Guid ProductId, Guid CustomerId, Guid StoreId)
        {
            // Отримуємо об’єкт Faker для створення Sales та зберігаємо його в змінній salesGenerator
            Faker<Sales> salesGenerator = GetSaleGenerator(ProductId, CustomerId, StoreId);
            List<Sales> generateSales = salesGenerator.Generate(SALES); // створення даних в кількості SALES

            return generateSales; // повернення згенерованих даних
        }

        public static void InitBogusData()
        {
            Products.AddRange(
                    GetProductGenerator() // витягування об'єкта Faker<Products> та
                    .Generate(PRODUCTS) // створення даних в кількості PRODUCTS
                );

            Customers.AddRange(
                    GetCustomerGenerator() // витягування об'єкта Faker<Customers> та
                    .Generate(CUSTOMERS) // створення даних в кількості CUSTOMERS
                );

            Stores.AddRange(
                    GetStoreGenerator() // витягування об'єкта Faker<Stores> та
                    .Generate(STORES) // створення даних в кількості STORES
                );

            // Створення і занесення об'єктів Sales по колекціям Products, Customers, Stores
            // SALES == 10 => 10 x 10 = 100 * 2
            for (int i = 0; i < SALES; i++)
                Sales.AddRange(
                        GetBogusSalesData(
                            Products[new Random().Next(0, PRODUCTS)].ProductId,
                            Customers[new Random().Next(0, CUSTOMERS)].CustomerId,
                            Stores[new Random().Next(0, STORES)].StoreId
                        )
                    );
        }
    }
}
