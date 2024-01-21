using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace ExaminationWDA.Models
{
    public partial class TbEmployee
    {
        public int Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public DateTime? BirthDate { get; set; }

        public string? Skills { get; set; }

        public string? Photo { get; set; }

        [NotMapped]
        public IFormFile? UploadImage { get; set; }
    }
}
