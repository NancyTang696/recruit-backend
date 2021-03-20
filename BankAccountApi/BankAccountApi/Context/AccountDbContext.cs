using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAccountApi.Context
{
    public class AccountDbContext : DbContext
    {
        public AccountDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<CreditCard> CreditCards { get; set; }

        public DbSet<AccountCreditCard> AccountCreditCards { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountCreditCard>()
                .HasKey(account => new { account.Name, account.CreditCardNumber });
        }
    }
}
