using Microsoft.EntityFrameworkCore;

namespace HW3.Models
{
    public class StockContext : DbContext
    {
        public StockContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Account> Accounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Account>().HasData(
                new Account { Username="user", Password="123"}
            );
        }
    }
}
