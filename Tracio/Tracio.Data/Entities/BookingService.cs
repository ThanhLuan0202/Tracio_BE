using System;
using System.Collections.Generic;

namespace Tracio.Data.Entities;

public partial class BookingService
{
    public int ServiceBookingId { get; set; }

    public int? ServiceId { get; set; }

    public int? BookingId { get; set; }

    public int? Quantity { get; set; }

    public decimal? Subtotal { get; set; }

    public string? Notes { get; set; }

    public virtual Booking? Booking { get; set; }

    public virtual Service? Service { get; set; }
}
