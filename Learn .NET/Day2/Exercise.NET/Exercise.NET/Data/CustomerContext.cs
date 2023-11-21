using System;
using Exercise.NET.Models;
using Microsoft.EntityFrameworkCore;

namespace Exercise.NET.Data
{
	public class CustomerContext : DbContext
	{
		public CustomerContext(DbContextOptions<CustomerContext> options): base(options) { }

		public DbSet<Customer> Customers { get; set; }
	}
}

