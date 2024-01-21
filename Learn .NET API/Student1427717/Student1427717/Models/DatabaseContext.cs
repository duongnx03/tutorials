using System;
using Microsoft.EntityFrameworkCore;

namespace Student1427717.Models
{
	public class DatabaseContext : DbContext
	{
		public DatabaseContext(DbContextOptions options): base(options)
		{
		}

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>().HasData(new Employee[]
            {
                new Employee{EmployeeId = "e1", Password = "123", EmployeeName = "Tri", Age = 22, Role = true},
                new Employee{EmployeeId = "e2", Password = "123", EmployeeName = "Dien", Age = 20, Role = false},
                new Employee{EmployeeId = "e3", Password = "123", EmployeeName = "Duong", Age = 32, Role = true}
            });
        }


    }
}

