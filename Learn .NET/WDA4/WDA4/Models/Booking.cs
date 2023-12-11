using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WDA4.Models;

public partial class Booking
{
    public int Id { get; set; }

    public string? Username { get; set; }

    [Required]
    public int RoomType { get; set; }

    [Required]
    public DateTime BeginDay { get; set; }

    [Required]
    public int DayStay { get; set; }
}
