using BillsPaymentSystem.Data.Bogus;
using BillsPaymentSystem.Data.Configurations;
using BillsPaymentSystem.Data.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BillsPaymentSystem.Data.DBContext
{
    public class BillsPaymentSystemContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<CreditCard> CreditCards { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }

        public BillsPaymentSystemContext(DbContextOptions options)
            : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new CreditCardConfiguration());
            modelBuilder.ApplyConfiguration(new BankAccountConfiguration());
            modelBuilder.ApplyConfiguration(new PaymentMethodConfiguration());

            DataGenerator.InitBogusData();
            modelBuilder.Entity<User>().HasData(DataGenerator.Users);
            modelBuilder.Entity<CreditCard>().HasData(DataGenerator.CreditCards);
            modelBuilder.Entity<BankAccount>().HasData(DataGenerator.BankAccounts);
            modelBuilder.Entity<PaymentMethod>().HasData(DataGenerator.PaymentMethods);
        }
    }
}
