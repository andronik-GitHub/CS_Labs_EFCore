using Bogus;
using Bogus.DataSets;
using Microsoft.EntityFrameworkCore;
using Sales_db.Data.Models;

namespace Sales_db.Data.Bogus
{
    public class DataGenerator
    {
        // Для збереження згенерованих даних
        public static readonly List<Customers> Customers = new();
        public static readonly List<Products> Products = new();
        public static readonly List<Stores> Stores = new();
        public static readonly List<Sales> Sales = new();

        // Кількість створюваних даних
        private const int CUSTOMERS = 300;
        private const int PRODUCTS = 150;
        private const int STORES = 10;
        private const int SALES = 800;


        // Правила заповнення Sales
        public static Faker<Sales> GetSalesGenerator(Guid ProductId, Guid CustomerId, Guid StoreId)
        {
            return new Faker<Sales>()
                .RuleFor(s => s.SaleId, _ => Guid.NewGuid())
                .RuleFor(s => s.Date, f => f.Date.Past(5))
                .RuleFor(s => s.ProductId, _ => ProductId) // Foreign key
                .RuleFor(s => s.CustomerId, _ => CustomerId) // Foreign key
                .RuleFor(s => s.StoreId, _ => StoreId); // Foreign key
        }

        // Правила заповнення Customers
        public static Faker<Customers> GetCustomersGenerator()
        {
            return new Faker<Customers>()
                .RuleFor(c => c.CustomerId, _ => Guid.NewGuid())
                .RuleFor(c => c.Name, f => f.Name.FullName())
                .RuleFor(c => c.Email, (f, e) => f.Internet.Email(e.Name))
                .RuleFor(c => c.CreaditCardNumber, f => f.Finance.CreditCardNumber())
                .RuleFor(c => c.Personality, f => f.PickRandom<Personality>())/*
                .RuleFor(c => c.Sales, (_, e) =>
                {
                    return GetBogusSalesData(e.CustomerId);
                })*/;
        }

        // Правила заповнення Products
        public static Faker<Products> GetProductsGenerator()
        {
            return new Faker<Products>()
                .RuleFor(p => p.ProductId, _ => Guid.NewGuid())
                .RuleFor(p => p.Name, f => f.Lorem.Word())
                .RuleFor(p => p.Quantity, f => f.Random.Int(0, 10000))
                .RuleFor(p => p.Price, f => f.Random.Decimal(10.0m, 99999.99m))
                .RuleFor(p => p.Personality, f => f.PickRandom<Personality>())/*
                .RuleFor(p => p.Sales, (_, e) =>
                {
                    return GetBogusSalesData(e.ProductId);
                })*/;
        }

        // Правила заповнення Stores
        public static Faker<Stores> GetStoresGenerator()
        {
            return new Faker<Stores>()
                .RuleFor(s => s.StoreId, _ => Guid.NewGuid())
                .RuleFor(s => s.Name, f => f.Lorem.Word())
                .RuleFor(s => s.Personality, f => f.PickRandom<Personality>())/*
                .RuleFor(s => s.Sales, (_, e) =>
                {
                    return GetBogusSalesData(s.StoreId);
                })*/;
        }


        // Для створення вкладених об'єктів Sales
        public static List<Sales> GetBogusSalesData(Guid ProductId, Guid CustomerId, Guid StoreId)
        {
            // Отримуємо об’єкт Faker для створення Sales та зберігаємо його в змінній salesGenerator
            Faker<Sales> salesGenerator = GetSalesGenerator(ProductId, CustomerId, StoreId);
            List<Sales> generateSales = salesGenerator.Generate(SALES); // створення даних в кількості SALES
            //Sales.AddRange(generateSales); // створенні дані додаються в List<Sales> Sales

            return generateSales; // повернення згенерованих даних
        }

        public static void InitBogusData()
        {
            Customers.AddRange(
                    GetCustomersGenerator() // витягування об'єкта Faker<Customers> та
                    .Generate(CUSTOMERS) // створення даних в кількості CUSTOMERS
                );

            Products.AddRange(
                    GetProductsGenerator() // витягування об'єкта Faker<Products> та
                    .Generate(PRODUCTS) // створення даних в кількості PRODUCTS
                );

            Stores.AddRange(
                    GetStoresGenerator() // витягування об'єкта Faker<Stores> та
                    .Generate(STORES) // створення даних в кількості STORES
                );


            // Із-за FK Sales заповнюється після головних таблиць
            for (int i = 0; i < STORES; i++)
                Sales.Add(GetSalesGenerator(
                        Customers[new Random().Next(0, CUSTOMERS)].CustomerId,
                        Products[new Random().Next(0, PRODUCTS)].ProductId,
                        Stores[new Random().Next(0, STORES)].StoreId
                    ));


            // Додавання Sales в інші колекції
            int index = 0;
            Customers.ForEach(c =>
            {
                for (index = 0; index < Sales.Count; index++)
                    if (c.CustomerId == Sales[index].CustomerId)
                    {
                        c.Sales.Add(Sales[index]);
                        break;
                    }
            });
            Products.ForEach(p =>
            {
                for (index = 0; index < Sales.Count; index++)
                    if (p.ProductId == Sales[index].ProductId)
                    {
                        p.Sales.Add(Sales[index]);
                        break;
                    }
            });
            Stores.ForEach(s =>
            {
                for (index = 0; index < Sales.Count; index++)
                    if (s.StoreId == Sales[index].StoreId)
                    {
                        s.Sales.Add(Sales[index]);
                        break;
                    }
            });
        }


        public static List<Products> GetSeededProductsFromDb(SalesContext dbContext)
        {
            using var DBContext = dbContext;
            DBContext.Database.EnsureCreated();
            return DBContext.Products.Include(e => e.Sales).ToList();
        }
        public static List<Customers> GetSeededCustomersFromDb(SalesContext dbContext)
        {
            using var DBContext = dbContext;
            DBContext.Database.EnsureCreated();
            return DBContext.Customers.Include(e => e.Sales).ToList();
        }
        public static List<Stores> GetSeededStoresFromDb(SalesContext dbContext)
        {
            using var DBContext = dbContext;
            DBContext.Database.EnsureCreated();
            return DBContext.Stores.Include(e => e.Sales).ToList();
        }
        public static List<Sales> GetSeededSalesFromDb(SalesContext dbContext)
        {
            using var DBContext = dbContext;
            DBContext.Database.EnsureCreated();
            return DBContext.Sales.ToList();
        }
    }
}
