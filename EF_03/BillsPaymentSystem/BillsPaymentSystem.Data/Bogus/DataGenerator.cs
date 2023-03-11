using BillsPaymentSystem.Data.DBContext;
using BillsPaymentSystem.Data.Models.Entities;
using BillsPaymentSystem.Data.Models.Enums;
using Bogus;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace BillsPaymentSystem.Data.Bogus
{
    public class DataGenerator
    {
        public static DbContextOptionsBuilder<BillsPaymentSystemContext> options = new();

        public static readonly List<User> Users = new();
        public static readonly List<CreditCard> CreditCards = new();
        public static readonly List<BankAccount> BankAccounts = new();
        public static readonly List<PaymentMethod> PaymentMethods = new();

        public const int USERS = 50;
        public const int CREDIT_CARDS = 50;
        public const int BANK_ACCOUNTS = 50;
        public const int PAYMENT_METHODS = 10;


        private static Faker<User> GetUserGenerator()
        {
            return new Faker<User>()
                .RuleFor(u => u.UserId, _ => Guid.NewGuid())
                .RuleFor(u => u.FirtsName, f => f.Name.FirstName())
                .RuleFor(u => u.LastName, f => f.Name.LastName())
                .RuleFor(u => u.Email, f => f.Internet.Email())
                .RuleFor(u => u.Password, f => f.Internet.Password());
        }
        private static Faker<CreditCard> GetCreditCardGenerator()
        {
            return new Faker<CreditCard>()
                .RuleFor(cc => cc.CreditCardId, _ => Guid.NewGuid())
                .RuleFor(cc => cc.Limit, f => f.Random.Decimal(0.0m, 5000.0m))
                .RuleFor(cc => cc.MoneyOwed, f => f.Random.Decimal(0.0m, 5000.0m))
                .RuleFor(cc => cc.ExpirationDate, f => f.Date.Future(10));
        }
        private static Faker<BankAccount> GetBankAccountGenerator()
        {
            return new Faker<BankAccount>()
                .RuleFor(ba => ba.BankAccountId, _ => Guid.NewGuid())
                .RuleFor(ba => ba.Balance, f => f.Random.Decimal(500000.0m, 10000000.0m))
                .RuleFor(ba => ba.BankName, f => f.Company.CompanyName())
                .RuleFor(ba => ba.SWIFT_Code, f => f.Commerce.Ean13());
        }
        private static Faker<PaymentMethod> GetPaymentMethodGenerator
            (Guid UserId, Guid? BankAccountId = null, Guid? CreditCardId = null)
        {
            return new Faker<PaymentMethod>()
                .RuleFor(pm => pm.PaymentMethodId, _ => Guid.NewGuid())
                .RuleFor(pm => pm.Type, f => f.PickRandom<PaymentTypes>())
                .RuleFor(pm => pm.UserId, _ => UserId)
                .RuleFor(pm => pm.BankAccountId, _ => BankAccountId)
                .RuleFor(pm => pm.CreditCardId, _ => CreditCardId);
        }

        private static List<PaymentMethod> GetBogusPaymentMethodData
            (Guid UserId, Guid? BankAccountId = null, Guid? CreditCardId = null)
        {
            Faker<PaymentMethod> paymentMethodGenerator =
                GetPaymentMethodGenerator(UserId, BankAccountId,CreditCardId);
            List<PaymentMethod> generatorPaymentMethod = paymentMethodGenerator.Generate(1);

            return generatorPaymentMethod;
        }

        public static void InitBogusData()
        {
            Users.AddRange(
                    GetUserGenerator()
                    .Generate(USERS)
                );

            CreditCards.AddRange(
                    GetCreditCardGenerator()
                    .Generate(CREDIT_CARDS)
                );

            BankAccounts.AddRange(
                    GetBankAccountGenerator()
                    .Generate(BANK_ACCOUNTS)
                );

            for (int i = 0; i < PAYMENT_METHODS; i++)
            {
                Guid UserId = Users[new Random().Next(0, USERS)].UserId;
                Guid? BankAccountId = BankAccounts[new Random().Next(0, CREDIT_CARDS)].BankAccountId;
                Guid? CreditCardId = CreditCards[new Random().Next(0, CREDIT_CARDS)].CreditCardId;

                while (PaymentMethods.FirstOrDefault(pm => 
                    pm.UserId == UserId || 
                    pm.BankAccountId == BankAccountId ||
                    pm.CreditCardId == CreditCardId) != null)
                {
                    UserId = Users[new Random().Next(0, USERS)].UserId;
                    BankAccountId = BankAccounts[new Random().Next(0, CREDIT_CARDS)].BankAccountId;
                    CreditCardId = CreditCards[new Random().Next(0, CREDIT_CARDS)].CreditCardId;
                }

                if (new Random().Next(0, 100) > 50) BankAccountId = null;
                else CreditCardId = null;

                PaymentMethods.AddRange(
                        GetBogusPaymentMethodData(
                            UserId,
                            BankAccountId,
                            CreditCardId
                        )
                    );
            }
        }

        public static string GetSeededUserFromDb(Guid UserId)
        {
            using var dbContext = new BillsPaymentSystemContext(options.Options);

            dbContext.Database.EnsureCreated();


            var paymentMethods = dbContext.PaymentMethods.FirstOrDefault(x => x.UserId == UserId);

            if (paymentMethods == null) return $"User with Id({UserId}) not found!";
            else
            {
                var stringBuilder = new StringBuilder();

                var user = dbContext.Users.First(u => u.UserId == UserId);
                stringBuilder.AppendLine($"User: {user.FirtsName + " " + user.LastName}");

                if (paymentMethods.BankAccountId == null)
                {
                    var CreditCard = dbContext.CreditCards
                        .First(cc => cc.CreditCardId == paymentMethods.CreditCardId);

                    stringBuilder.AppendLine("Credit Card:");
                    stringBuilder.AppendLine(CreditCard.ToString());
                }
                else
                {
                    var BankAccount = dbContext.BankAccounts
                        .First(ba => ba.BankAccountId == paymentMethods.BankAccountId);

                    stringBuilder.AppendLine("Bank Account:");
                    stringBuilder.AppendLine(BankAccount.ToString());
                }


                return stringBuilder.ToString();
            }
        }

        public static string PayBills(Guid UserId, decimal amount)
        {
            using var dbContext = new BillsPaymentSystemContext(options.Options);

            dbContext.Database.EnsureCreated();


            var paymentMethods = dbContext.PaymentMethods.FirstOrDefault(x => x.UserId == UserId);

            if (paymentMethods == null) return $"User with Id({UserId}) not found!";
            else
            {
                if (paymentMethods.BankAccountId == null)
                {
                    var CreditCard = dbContext.CreditCards
                        .First(cc => cc.CreditCardId == paymentMethods.CreditCardId);

                    if (CreditCard.Withdraw(amount))
                        return $"{amount}$ has been withdrawn from the Credit Card of the user ({UserId}).";
                    else
                        return $"User({UserId}) has insufficient funds from the Credit Card!";
                }
                else
                {
                    var BankAccount = dbContext.BankAccounts
                        .First(ba => ba.BankAccountId == paymentMethods.BankAccountId);

                    if (BankAccount.Withdraw(amount))
                        return $"{amount}$ has been withdrawn from the Bank Account of the user ({UserId}).";
                    else
                        return $"User({UserId}) has insufficient funds from the Bank Account!";
                }
            }
        }
    }
}
