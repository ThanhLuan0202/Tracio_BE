using System;
using System.Collections.Generic;

namespace Tracio.Data.Models;

public partial class BookingProduct
{
    public int ProductBookingId { get; set; }

    public int? BookingId { get; set; }

    public int? ProductId { get; set; }

    public int? Quantity { get; set; }

    public decimal? Subtotal { get; set; }

    public string? Notes { get; set; }

    public virtual Booking? Booking { get; set; }

    public virtual Product? Product { get; set; }
}
