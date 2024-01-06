using Microsoft.EntityFrameworkCore;

namespace LastPretest.Models
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
            modelBuilder.Entity<Account>().HasData(new Account[]
            {
                new Account{Username="user1", Password="123", Balance=1000},
                new Account{Username="user2", Password="123", Balance=1000}
            });
        }
    }
}
