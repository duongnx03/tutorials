using CodeFirst.Models;
using Microsoft.EntityFrameworkCore;

using System;
namespace CodeFirst.Data
{
	public class StudentContext: DbContext
	{
		public StudentContext (DbContextOptions<StudentContext> options) : base(options) { }


		public DbSet<Student> Students { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Student>().ToTable("Student");
			base.OnModelCreating(modelBuilder);
		}
	}
}

