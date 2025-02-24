using System;
using System.Collections.Generic;

namespace Tracio.Data.Models;

public partial class Booking
{
    public int BookingId { get; set; }

    public int? UserId { get; set; }

    public DateTime? BookingDate { get; set; }

    public string? Status { get; set; }

    public string? Notes { get; set; }

    public decimal? TotalAmount { get; set; }

    public virtual ICollection<BookingProduct> BookingProducts { get; set; } = new List<BookingProduct>();

    public virtual ICollection<BookingService> BookingServices { get; set; } = new List<BookingService>();

    public virtual User? User { get; set; }
}
