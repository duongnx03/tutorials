using System;
namespace Exam1.Models
{
	public class BookDetails
	{
		public string BookId { get; set; }
		public string Genre { get; set; }
		public int Price { get; set; }
		public Book? Book { get; set; }
}
}

