using System;
using Microsoft.EntityFrameworkCore;

namespace ExaminationWDACF.Models
{
	public class DatabaseContext : DbContext
	{
		public DatabaseContext(DbContextOptions options) : base(options)
		{

		}

		public DbSet<Account> Accounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Account>()
                .Property(a => a.Balance)
                .HasColumnType("decimal(15, 2)"); // Chỉ định precision và scale

            modelBuilder.Entity<Account>().HasData(new Account[]
			{
				new Account{AccountNo = "A1", AccountName = "Nick", PinCode = "123", Balance = 10000, Role = true},
                new Account{AccountNo = "A2", AccountName = "Alex", PinCode = "123", Balance = 1200, Role = false},
                new Account{AccountNo = "A3", AccountName = "Andy", PinCode = "123", Balance = 35000, Role = false}
            });
        }
    }
}

