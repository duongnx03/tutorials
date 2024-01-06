using System;
using System.Net;
using System.Numerics;
using Microsoft.EntityFrameworkCore;

namespace Exam1.Models
{
	public class BookDbContext : DbContext
	{
		public BookDbContext()
		{

		}

		public BookDbContext(DbContextOptions options) : base(options)
		{

		}

		public DbSet<Book> Books { get; set; }
        public DbSet<BookDetails> BookDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<BookDetails>(e =>
			{
                e.HasKey(o => o.BookId);
                e.HasOne(o => o.Book).WithMany(o => o.BookDetails).HasForeignKey(o => o.BookId);
            });
			modelBuilder.Entity<Book>().HasData(new Book[]
            {
				new Book {Id = "O001", Title="HiHi", Author="DuongK", PublishedDate="2023-12-11"},
                new Book {Id = "O002", Title="HeHe", Author="TriLor", PublishedDate="2023-12-12"},
                new Book {Id = "O003", Title="HaHa", Author="DienLor", PublishedDate="2023-12-13"}
            });

			modelBuilder.Entity<BookDetails>().HasData(new BookDetails[]
			{
				new BookDetails {BookId = "O001", Genre = "Comic", Price = 10},
                new BookDetails {BookId = "O002", Genre = "Story", Price = 30},
                new BookDetails {BookId = "O003", Genre = "Comic", Price = 18},
            });
        }
    }
}

