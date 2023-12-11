using System;
using Client.Models;
using Microsoft.EntityFrameworkCore;

namespace Client.Database
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=StudentDb;User=sa;Password=Password.1;TrustServerCertificate=true");
            base.OnConfiguring(optionsBuilder);
        }


    }
}
