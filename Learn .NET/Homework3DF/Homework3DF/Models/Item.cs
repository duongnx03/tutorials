using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace Homework3DF.Models;

public partial class Item
{
    public string? ItemCode { get; set; }

    [Required]
    public string? ItemName { get; set; }

    [Required]
    public int? Price { get; set; }

    public string? Image { get; set; }

    [NotMapped]// k co trong db
    public IFormFile UploadImage { get; set; }
}
