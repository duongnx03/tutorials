using System;
using Microsoft.EntityFrameworkCore;

namespace PretestEAT.Models
{
	public class DatabaseContext : DbContext
	{
		public DatabaseContext(DbContextOptions options) : base(options)
		{

		}

		public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<Employee>().HasData(new Employee[]
			{
               new Employee {EmpID="e1", FirstName="Nguyen Van", LastName=" A", Password="123", Salary=1000},
               new Employee {EmpID="e2", FirstName="Nguyen Van", LastName=" B", Password="123", Salary=1000},
               new Employee {EmpID="e3", FirstName="Nguyen Van", LastName=" C", Password="123", Salary=1000}
            });
        }
    }
}

