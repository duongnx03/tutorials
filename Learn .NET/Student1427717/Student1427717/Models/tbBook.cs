using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student1427717.Models
{
	public class tbBook
	{
		[Key]
		public int Id { get; set; }
        [Required, MaxLength(60)]
        public string? Title { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        public decimal? Price { get; set; }
        [Required, MaxLength(200)]
        public string? ImageUrl { get; set; }

        [NotMapped]
        public IFormFile? UploadImage { get; set; }
    }
}

