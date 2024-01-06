using System;
using System.Collections.Generic;

namespace Exam1.Models
{
	public class Book
	{
		public string Id { get; set; }
		public string Title { get; set; }
		public string Author { get; set; }
		public string PublishedDate { get; set; }
		public ICollection<BookDetails> BookDetails { get; set; }
    }
}

