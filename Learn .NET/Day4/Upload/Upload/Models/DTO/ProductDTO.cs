using System;
namespace Upload.Models.DTO
{
	public class ProductDTO
	{
        public int Id { get; set; }

        public string? Name { get; set; }

        public int? Price { get; set; }

        public string? Image { get; set; }
    }
}

