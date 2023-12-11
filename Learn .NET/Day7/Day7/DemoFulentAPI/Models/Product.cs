using System;
namespace DemoFulentAPI.Models
{
	public class Product
	{
        public int Id { get; set; }
        public String Name { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}

