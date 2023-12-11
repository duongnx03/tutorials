using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HW3.Models
{
    public class Item
    {
        [Required]
        [Key]
        public string ItemCode { get; set; }
        [Required]
        public string? ItemName { get; set; }
        [Required]
        public int? Price { get; set; }
        public string? Image { get; set; }

        [NotMapped] //field nay khong nam trong db
        public IFormFile UploadImage { get; set; }
    }
}
