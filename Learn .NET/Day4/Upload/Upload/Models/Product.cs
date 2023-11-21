using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Upload.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? Name { get; set; }

    //[BindRequired]: yeu cau dung du lieu
    //[Binever]: khong yeu cau
    public int? Price { get; set; }

    public string? Image { get; set; }

    [NotMapped] // 
    public IFormFile? UploadImage { get; set; }

}
