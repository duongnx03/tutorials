using System;
using Microsoft.EntityFrameworkCore;

namespace Demo_DTO.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }

}

